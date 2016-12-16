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
        /// Constructeur pour les tests unitaires.
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
        /// Prend en argument la difficulté du test (false = facile, true = difficile).
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestPerceptionMemoire(bool difficulteTest)
        {
            // Initialisation des attributs
            nom = "";
            consigne = "";
            imagesDemo = new List<string>();
            difficulte = difficulteTest;
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;
            intervalle = (difficulte) ? 2 : 4;
            lettres = new List<string>();

            // Appel aux méthodes implémentant les attributs avec la base de données
            RecupererDemonstration();
            GenererListeQuestions();
            SeparerLettresReponses();
        }

        /// <summary>
        /// Compare la entrée par l’utilisateur à la réponse juste et met à jour son score.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste des erreurs [lettre, réponse juste, réponse du joueur]</returns>
        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            List<string> erreurs = new List<string> { "", "", "" };

            for (int i = 0; i < reponses[numQuestion].Length; i++)
            {
                // Si la réponse du joueur ne correspond pas à la “vraie” réponse
                if (reponses[numQuestion][i] != reponse[i])
                {
                    // Implémentation de la liste contenant son erreur
                    erreurs[0] += lettres[numQuestion][i].ToString();
                    erreurs[1] += reponses[numQuestion][i].ToString();
                    erreurs[2] += reponse[i].ToString();
                }

                // Si la réponse du joueur correspond à la “vraie” réponse
                else
                {
                    // Incrémentation de son score
                    score++;
                }
            }

            return erreurs;
        }

        /// <summary>
        /// Affiche à l’utilisateur ses erreurs.
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

            // On compte le nombre de champs qu’a dû remplir le joueur
            // (Variable car on ne peut pas prédire si la question comporte 3 ou 4 sous-questions
            for (int i = 0; i < reponses.Count; i++)
            {
                nbQuestionsTotales += reponses[i].Length;
            }

            return Math.Round(score * 100.0 / nbQuestionsTotales, 2);
        }

        /// <summary>
        /// Récupère le test (nom et consigne) et ses écrans de démonstration.
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

                    // Récupération du test (consigne et nom)
                    requete.CommandText = "SELECT * FROM Test WHERE Id = " + idTest;
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        nom = reader["Nom"].ToString();
                        consigne = reader["Consigne"].ToString();
                    }
                }

                using (OleDbCommand requete2 = new OleDbCommand())
                {
                    requete2.Connection = connexionBDD;

                    // Récupération de la démonstration
                    requete2.CommandText = "SELECT * FROM Demo WHERE Test = " + idTest;
                    OleDbDataReader reader2 = requete2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            imagesDemo.Add(reader2["ImageDemo"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }
        }

        /// <summary>
        /// Génère une liste de questions aléatoirement grâce aux questions de la base de données.
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
                    requete.CommandText = "SELECT * FROM Questions Q INNER JOIN Images I ON I.Question = Q.Id WHERE Test = " + idTest;
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            questions.Add(reader["Q.Question"].ToString());
                            reponses.Add(reader["Reponse"].ToString());
                            imagesQuestion.Add(reader["ImageQuestion"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }

            // Nouvelles listes contenant les questions, les images et les réponses
            List<string> newQuestions = new List<string>();
            List<string> newReponses = new List<string>();
            List<string> newImages = new List<string>();
            int nombre = nbQuestions;
            Random rnd = new Random();

            // Remplissage des nouvelles listes aléatoirement
            for (int i = 0; i < nombre; i++)
            {
                int indice = rnd.Next(0, questions.Count);
                newQuestions.Add(questions[indice]);
                newReponses.Add(reponses[indice]);
                newImages.Add(imagesQuestion[indice]);

                questions.RemoveAt(indice);
                reponses.RemoveAt(indice);
                imagesQuestion.RemoveAt(indice);
            }

            // Modifications des listes de la classe
            questions = newQuestions;
            reponses = newReponses;
            imagesQuestion = newImages;
        }

        /// <summary>
        /// Sépare les lettres et les chiffres de toutes les réponses du test. 
        /// Par exemple, si la réponse à une question est A2F4H7, on sépare d’un côté A, F et H et de l’autre 2, 4 et 7.
        /// </summary>
        private void SeparerLettresReponses()
        {
            List<string> chiffres = new List<string>();

            for (int i = 0; i < reponses.Count; i++)
            {
                string chaineLettres = "";
                string chaineChiffres = "";

                for (int j = 0; j < reponses[i].Length - 1; j += 2)
                {
                    chaineLettres += reponses[i][j];
                    chaineChiffres += reponses[i][j + 1];
                }

                lettres.Add(chaineLettres);
                chiffres.Add(chaineChiffres);
            }

            reponses = chiffres;
        }
    }
}
