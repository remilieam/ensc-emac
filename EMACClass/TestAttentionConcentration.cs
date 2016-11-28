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
            SeparerImages();
        }

        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compare la réponse entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numSerie">Numéro de la série à laquelle appartient la question</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste avec des erreurs ([réponse juste, réponse du joueur])</returns>
        public List<string> VerifierBouton(string reponse, int numSerie, int numQuestion)
        {
            List<string> erreurs = new List<string>();

            if (this.reponses[numSerie][numQuestion].ToString() != reponse)
            {
                erreurs.Add(this.reponses[numSerie][numQuestion].ToString());
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
                        requeteSql = "SELECT TOP " + this.nbQuestions + " * FROM Questions WHERE Test = " + this.idTest + " ORDER BY RND([Id])";
                    }

                    else
                    {
                        string type = "";

                        using (OleDbCommand requete3 = new OleDbCommand())
                        {
                            requete3.Connection = connexionBDD;

                            // Récupération des questions du test
                            requete3.CommandText = "SELECT TOP 1 Type FROM Questions WHERE Test = " + this.idTest + " ORDER BY RND([Id])";
                            OleDbDataReader reader3 = requete3.ExecuteReader();

                            if (reader3.HasRows)
                            {
                                reader3.Read();
                                type = reader3["Type"].ToString();
                            }
                        }

                        requeteSql = "SELECT TOP " + this.nbQuestions + " * FROM Questions WHERE Test = " + this.idTest + " AND Type = '" + type + "' ORDER BY RND([Id])";
                    }

                    requete.CommandText = requeteSql;
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.questions.Add(reader["Question"].ToString());
                            this.reponses.Add(reader["Reponse"].ToString());

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
                                        this.imagesQuestion.Add(reader2["ImageQuestion"].ToString());
                                    }
                                }
                            }
                        }
                    }
                }

                connexionBDD.Close();
            }
        }

        /// <summary>
        /// Sépare les images pour chaque série en les regroupant par paquet de 5.
        /// </summary>
        private void SeparerImages()
        {
            int nbImages = 0;

            for (int i = 0; i < this.questions.Count; i++)
            {
                List<string> imagesSerie = new List<string>();

                for (int j = 0; j < 5; j++)
                {
                    imagesSerie.Add(imagesQuestion[nbImages]);
                    nbImages++;
                }

                imagesSeries.Add(imagesSerie);
            }
        }
    }
}
