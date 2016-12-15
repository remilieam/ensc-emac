using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestPerceptionMemoire : Test
    {
        // Attributs inhérents à la classe
        public List<string> lettres { get; private set; }
        private readonly int idTest = 1;
        private readonly int nbQuestions = 10;

        /// <summary>
        /// Constructeur pour les tests unitaires
        /// </summary>
        /// <param name="reponsesTest">Liste des réponses</param>
        /// <param name="lettresTest">Liste des lettres des réponses</param>
        public TestPerceptionMemoire(List<string> reponsesTest, List<string> lettresTest)
        {
            reponses = reponsesTest;
            lettres = lettresTest;
        }

        /// <summary>
        /// Construit un nouveau test “Perception et mémoire associative”.
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile)
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestPerceptionMemoire(bool difficulteTest)
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
            intervalle = (difficulte) ? 2 : 4;
            lettres = new List<string>();

            RecupererDemonstration();
            GenererListeQuestions();
            SeparerLettresReponses();
        }

        /// <summary>
        /// Compare la entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste des erreurs [lettre, réponse juste, réponse du joueur]</returns>
        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            List<string> erreurs = new List<string> { "", "", "" };

            for (int i = 0; i < this.reponses[numQuestion].Length; i++)
            {
                if (this.reponses[numQuestion][i] != reponse[i])
                {
                    erreurs[0] += this.lettres[numQuestion][i].ToString();
                    erreurs[1] += this.reponses[numQuestion][i].ToString();
                    erreurs[2] += reponse[i].ToString();
                }

                else
                {
                    this.score++;
                }
            }

            return erreurs;
        }

        /// <summary>
        /// Affiche à l’utilisateur le nombre d’erreurs qu’il a commis avec les réponses qu’il aurait dû mettre.
        /// </summary>
        /// <param name="erreurs">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        /// <returns>Chaîne de caractères à afficher au joueur</returns>
        public override string AfficherErreur(List<string> erreurs)
        {
            string message = "Vous avez commis des erreurs. Vous avez répondu :\r\n";

            for (int i = 0; i < erreurs[0].Length; i++)
            {
                message += "  –  en " + erreurs[0][i] + ", " + ((erreurs[2][i].ToString() == " ") ? "rien" : erreurs[2][i].ToString()) + " au lieu de " + erreurs[1][i] + "\r\n";
            }

            return message;
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public override double CalculerResultat()
        {
            double nbQuestionsTotales = 0;

            for (int i = 0; i < this.reponses.Count; i++)
            {
                nbQuestionsTotales += this.reponses[i].Length;
            }

            return Math.Round(this.score * 100.0 / nbQuestionsTotales, 2);
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

                    // Récupération des questions du test avec l’image associée
                    requete.CommandText = "SELECT * FROM Questions Q INNER JOIN Images I ON I.Question = Q.Id WHERE Test = " + this.idTest;
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.questions.Add(reader["Q.Question"].ToString());
                            this.reponses.Add(reader["Reponse"].ToString());
                            this.imagesQuestion.Add(reader["ImageQuestion"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }

            // Nouvelles listes contenant les questions, les images et les réponses
            List<string> newQuestions = new List<string>();
            List<string> newReponses = new List<string>();
            List<string> newImages = new List<string>();
            int nombre = this.nbQuestions;
            Random rnd = new Random();

            // Remplissage des nouvelles listes aléatoirement
            for (int i = 0; i < nombre; i++)
            {
                int indice = rnd.Next(0, this.questions.Count);
                newQuestions.Add(this.questions[indice]);
                newReponses.Add(this.reponses[indice]);
                newImages.Add(this.imagesQuestion[indice]);

                this.questions.RemoveAt(indice);
                this.reponses.RemoveAt(indice);
                this.imagesQuestion.RemoveAt(indice);
            }

            // Modifications des listes de la classe
            this.questions = newQuestions;
            this.reponses = newReponses;
            this.imagesQuestion = newImages;
        }

        /// <summary>
        /// Sépare les lettres et les chiffres de toutes les réponses du test. 
        /// Par exemple, si la réponse à une question est A2F4H7, on sépare d’un côté A, F et H et de l’autre 2, 4 et 7.
        /// </summary>
        private void SeparerLettresReponses()
        {
            List<string> chiffres = new List<string>();

            for (int i = 0; i < this.reponses.Count; i++)
            {
                string chaineLettres = "";
                string chaineChiffres = "";

                for (int j = 0; j < this.reponses[i].Length - 1; j += 2)
                {
                    chaineLettres += this.reponses[i][j];
                    chaineChiffres += this.reponses[i][j + 1];
                }

                this.lettres.Add(chaineLettres);
                chiffres.Add(chaineChiffres);
            }

            this.reponses = chiffres;
        }
    }
}
