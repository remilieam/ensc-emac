using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestAttentionConcentration : Test
    {
        // Attributs inhérents à la classe
        public List<List<string>> imagesSeries { get; private set; }
        private readonly int idTest = 2;
        private readonly int nbQuestions = 3;

        /// <summary>
        /// Constructeur pour les tests unitaires
        /// </summary>
        /// <param name="reponsesTest"></param>
        public TestAttentionConcentration(List<string> reponsesTest)
        {
            reponses = reponsesTest;
        }

        /// <summary>
        /// Construit un nouveau test “Attention et concentration”.
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile)
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestAttentionConcentration(bool difficulteTest)
        {
            nom = "";
            consigne = "";
            imagesDemo = new List<string>();
            texteDemo = new List<string>();
            difficulte = difficulteTest;
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;
            intervalle = (difficulte) ? 3 : 0;
            imagesSeries = new List<List<string>>();

            RecupererDemonstration();
            GenererListeQuestions();
        }

        /// <summary>
        /// Compare la réponse entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numQuestion">Numéro de la question totale (0 à 14)</param>
        /// <returns>Liste avec des erreurs ([réponse juste, réponse du joueur])</returns>
        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            int question = numQuestion / 5;
            int serie = numQuestion % 5;

            List<string> erreurs = new List<string>();

            if (this.reponses[serie][question].ToString() != reponse)
            {
                erreurs.Add(this.reponses[serie][question].ToString());
                erreurs.Add(reponse.ToString());
            }

            else
            {
                this.score++;
            }

            return erreurs;
        }

        /// <summary>
        /// Affiche à l’utilisateur son erreur.
        /// </summary>
        /// <param name="erreur">Liste obtenue grâce à la méthode “VerifierBouton”</param>
        /// <returns>Chaîne de caractères à afficher au joueur</returns>
        public override string AfficherErreur(List<string> erreur)
        {
            if (erreur[1] == "0")
            {
                return "Vous n’avez cliqué sur aucun bouton.\r\nPour information, il fallait appuyer sur bouton " + erreur[0] + ".";
            }

            return "Vous avez cliqué sur le bouton " + erreur[1] + " au lieu du bouton " + erreur[0] + ".";
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public override double CalculerResultat()
        {
            return Math.Round(this.score / (this.reponses.Count * 5.0) * 100.0, 2);
        }

        /// <summary>
        /// Récupère la consigne et la démonstration du test dont on entre l'id
        /// </summary>
        protected override void RecupererDemonstration()
        {
            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            using (connexionBDD)
            {
                connexionBDD.Open();

                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;

                    // Récupération du test
                    requete.CommandText = "SELECT * FROM Test WHERE Id = " + this.idTest;
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        this.nom = reader["Nom"].ToString();
                        this.consigne = reader["Consigne"].ToString();
                    }
                }

                using (OleDbCommand requete2 = new OleDbCommand())
                {
                    requete2.Connection = connexionBDD;

                    // Récupération de la démonstration
                    requete2.CommandText = "SELECT * FROM Demo WHERE Test = " + this.idTest;
                    OleDbDataReader reader2 = requete2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            this.imagesDemo.Add(reader2["ImageDemo"].ToString());
                            this.texteDemo.Add(reader2["TexteDemo"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }
        }

        /// <summary>
        /// Génère une liste de question en prennant l'id du test et le nombre de questions à récupérer.
        /// </summary>
        protected override void GenererListeQuestions()
        {
            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            using (connexionBDD)
            {
                connexionBDD.Open();

                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;

                    // Récupération des questions du test et des images associées
                    string requeteSql;

                    if (this.difficulte)
                    {
                        requeteSql = "SELECT * FROM Questions WHERE Test = " + this.idTest;
                    }

                    else
                    {
                        List<string> types = new List<string> { "PC", "CP", "CF", "FC", "PF", "FP" };
                        Random alea = new Random();
                        int num = alea.Next(0, types.Count);
                        requeteSql = "SELECT * FROM Questions WHERE Test = " + this.idTest + " AND Type = '" + types[num] + "'";
                    }

                    requete.CommandText = requeteSql;
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.questions.Add(reader["Question"].ToString());
                            this.reponses.Add(reader["Reponse"].ToString());
                            List<string> imagesSerie = new List<string>();

                            using (OleDbCommand requete2 = new OleDbCommand())
                            {
                                requete2.Connection = connexionBDD;

                                // Récupération des questions du test
                                requete2.CommandText = "SELECT * FROM Images WHERE Question = " + reader["Id"];
                                OleDbDataReader reader2 = requete2.ExecuteReader();

                                if (reader2.HasRows)
                                {
                                    while (reader2.Read())
                                    {
                                        imagesSerie.Add(reader2["ImageQuestion"].ToString());
                                    }
                                }
                            }

                            this.imagesSeries.Add(imagesSerie);
                        }
                    }
                }

                connexionBDD.Close();
            }

            // Nouvelles listes contenant les questions, les images et les réponses
            List<string> newQuestions = new List<string>();
            List<string> newReponses = new List<string>();
            List<List<string>> newImages = new List<List<string>>();
            int nombre = this.nbQuestions;
            Random rnd = new Random();

            // Remplissage des nouvelles listes aléatoirement
            for (int i = 0; i < nombre; i++)
            {
                int indice = rnd.Next(0, this.questions.Count);
                newQuestions.Add(this.questions[indice]);
                newReponses.Add(this.reponses[indice]);
                newImages.Add(this.imagesSeries[indice]);

                this.questions.RemoveAt(indice);
                this.reponses.RemoveAt(indice);
                this.imagesSeries.RemoveAt(indice);
            }

            // Modifications des listes de la classe
            this.questions = newQuestions;
            this.reponses = newReponses;
            this.imagesSeries = newImages;
        }
    }
}
