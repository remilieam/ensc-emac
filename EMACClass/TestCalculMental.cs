using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestCalculMental : Test
    {
        // Attributs inhérents à la classe
        private readonly int idTest = 3;
        private readonly int nbQuestions = 10;
        private string operation = "";

        /// <summary>
        /// Constructeur pour les tests unitaires.
        /// </summary>
        /// <param name="reponsesTest">Liste des réponses</param>
        public TestCalculMental(List<string> reponsesTest)
        {
            reponses = reponsesTest;
        }

        /// <summary>
        /// Construit un nouveau test “Attention et concentration”.
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile).
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestCalculMental(bool difficulteTest)
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
            intervalle = (difficulte) ? 5 : 0;

            // Appel à une méthode implémentant certains attributs avec la base de données
            RecupererDemonstration();
        }

        /// <summary>
        /// Compare la réponse entrée par l’utilisateur à la réponse juste et met à jour son score.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numQuestion">Numéro de la question à vérifier (0 à 10)</param>
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
        /// Affiche à l’utilisateur son erreur.
        /// </summary>
        /// <param name="erreur">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        /// <returns>Chaîne de caractères à afficher au joueur</returns>
        public override string AfficherErreur(List<string> erreur)
        {
            // Cas où le joueur n’a pas eu le temps de répondre et/ou valider sa réponse
            // Cas où le joueur valide sans avoir au préalable donner de réponse
            if (erreur[1] == "0" || erreur[1] == "")
            {
                return "Vous n’avez pas entré de résultat.\r\nPour information, il fallait trouver " + erreur[0] + ".";
            }

            return "Vous avez calculé " + erreur[1] + " et il fallait calculer " + erreur[0] + ".";
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public override double CalculerResultat()
        {
            return Math.Round(score * 100.0 / reponses.Count, 2); ;
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

                    // Récupération des questions du test
                    requete.CommandText = "SELECT * FROM Questions WHERE Test = " + idTest + " AND Type = '" + operation + "'";
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            questions.Add(reader["Question"].ToString());
                            reponses.Add(reader["Reponse"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }

            // Nouvelles istes contenant les questions et les réponses
            List<string> newQuestions = new List<string>();
            List<string> newReponses = new List<string>();
            int nombre = nbQuestions;
            Random rnd = new Random();

            // Remplissage des nouvelles listes aléatoirement
            for (int i = 0; i < nombre; i++)
            {
                int indice = rnd.Next(0, questions.Count);
                newQuestions.Add(questions[indice]);
                newReponses.Add(reponses[indice]);

                questions.RemoveAt(indice);
                reponses.RemoveAt(indice);
            }

            // Modifications des listes de la classe
            questions = newQuestions;
            reponses = newReponses;
        }

        /// <summary>
        /// Pour générer la liste de questions après que l’utilisateur ait choisi l’opération sur laquelle il désire se tester.
        /// </summary>
        /// <param name="signe">Chaîne de caractères contenant l’opération choisi par l’utilisateur</param>
        public void GenererQuestions(string signe)
        {
            operation = signe;
            GenererListeQuestions();
        }
    }
}
