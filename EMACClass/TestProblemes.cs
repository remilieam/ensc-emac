using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestProblemes : Test
    {
        // Attributs inhérents à la classe
        protected readonly int nbquestion = 10;
        protected int idTest;

        /// <summary>
        /// Constructeur pour les tests unitaires.
        /// </summary>
        /// <param name="Rep">Liste des réponses</param>
        public TestProblemes(List<string> Rep)
        {
            reponses = Rep;
        }

        /// <summary>
        /// Initialise l’attribut “difficulte” du test (false = facile, true = difficile).
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestProblemes(bool difficulteTest)
        {
            difficulte = difficulteTest;
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

                // Création d’une requête
                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;

                    if (difficulte == true)
                    {
                        requete.CommandText = "SELECT * FROM Questions q LEFT JOIN Images i ON i.Question = q.Id WHERE Test = " + idTest + " and type = 'Difficile'";
                        OleDbDataReader reader = requete.ExecuteReader();

                        while (reader.Read())
                        {
                            questions.Add((string)reader["Q.Question"]);
                            imagesQuestion.Add(reader["ImageQuestion"].ToString());
                            reponses.Add(reader["Reponse"].ToString());
                        }
                    }

                    else
                    {
                        requete.CommandText = "SELECT * FROM Questions q LEFT JOIN Images i ON i.Question = q.Id WHERE Test = " + idTest + " and type = 'Facile'";
                        OleDbDataReader reader = requete.ExecuteReader();

                        while (reader.Read())
                        {
                            questions.Add((string)reader["Q.Question"]);
                            imagesQuestion.Add(reader["ImageQuestion"].ToString());
                            reponses.Add(reader["Reponse"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }

            // Nouvelles listes contenant les questions et les réponses
            List<string> newQuestions = new List<string>();
            List<string> newReponses = new List<string>();
            List<string> newImages= new List<string>();
            int nombre = nbquestion;
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
        /// Compare la entrée par l’utilisateur à la réponse juste et met à jour son score.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste avec l’éventuel erreur du joueur ([réponse juste, réponse du joueur])</returns>
        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            List<string> erreurs = new List<string>();

            // Si la réponse du joueur ne correspond pas à la “vraie” réponse
            if (reponses[numQuestion].ToString() != reponse)
            {
                // Implémentation de la liste contenant son erreur
                erreurs.Add(reponses[numQuestion].ToString());
                erreurs.Add(reponse.ToString());
            }

            // Si la réponse du joueur correspond à la “vraie” réponse
            else
            {
                // Incrémentation de son score
                score++;
            }

            return erreurs;
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public override double CalculerResultat()
        {
            return Math.Round(score * 100.0 / reponses.Count, 2);
        }

        public override string AfficherErreur(List<string> erreurs)
        {
            throw new NotImplementedException();
        }
    }
}