using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class Test
    {
        // Lien vers la base de données
        private const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";

        // Attributs
        public string nom;
        public string consigne;
        public List<string> imagesDemo;
        public List<string> texteDemo;
        public bool difficulte;
        public List<string> questions;
        public List<string> imagesQuestion;
        public List<string> reponses;
        public int score;
        public int intervalle;

        // Méthodes

        /// <summary>
        /// Permet l’enchaînement des différentes questions
        /// </summary>
        public virtual void Jouer()
        { }

        /// <summary>
        /// Gère l’affichage de la consigne et de la démonstration (succession d’écrans avec texte et image).
        /// </summary>
        public void AfficherDemonstration()
        {
            
        }

        /// <summary>
        /// Compare la entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <returns>Liste des erreurs (une instance = [réponse du joueur, réponse juste])</returns>
        public List<object> VerifierReponse(string reponse)
        { return new List<object>(); }

        /// <summary>
        /// Affiche à l’utilisateur le nombre d’erreurs qu’il a commis avec les réponses qu’il aurait dû mettre.
        /// </summary>
        /// <param name="erreurs">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        public void AfficherErreurs(List<object> erreurs)
        { }

        /// <summary>
        /// Met à jour le score de l’utilisateur.
        /// </summary>
        /// <param name="erreurs">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        public void ModifierScore(List<object> erreurs)
        { }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public double CalculerResultat()
        { return 0; }

        /// <summary>
        /// Récupère la consigne et la démonstration du test dont on entre l'id
        /// </summary>
        /// <param name="idTest">Id du test (entre 1 et 7)</param>
        public void GetDemonstration(int idTest)
        {
            imagesDemo.Clear();
            texteDemo.Clear();

            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            using (connexionBDD)
            {
                connexionBDD.Open();

                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;

                    // Récupération du test
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
                            texteDemo.Add(reader2["TexteDemo"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }
        }
        /// <summary>
        /// Génère une liste de question en prennant l'id du test et le nombre de questions à récupérer.
        /// </summary>
        /// <param name="idTest">Id du test (entre 1 et 7)</param>
        /// <param name="nbQuestions">Nombre de questions du test (10 ou 15)</param>
        public void GenerateListQuestions(int idTest, int nbQuestions)
        {
            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            using (connexionBDD)
            {
                connexionBDD.Open();

                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;

                    // Récupération des 10 questions du test
                    requete.CommandText = "SELECT TOP " + nbQuestions + " * FROM Questions Q INNER JOIN Images I ON I.Question = Q.Id WHERE Q.Test = " + idTest + " ORDER BY RND([Q.Id])";
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            questions.Add(reader["Question"].ToString());
                            reponses.Add(reader["Reponse"].ToString());
                            imagesQuestion.Add(reader["ImageQuestion"].ToString());
                        }
                    }

                }

                connexionBDD.Close();
            }
        }
    }
}
