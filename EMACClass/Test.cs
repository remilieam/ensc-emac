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
        public string nom { get; protected set; }
        public string consigne { get; protected set; }
        public List<string> imagesDemo { get; protected set; }
        public List<string> texteDemo { get; protected set; }
        public bool difficulte { get; protected set; }
        public List<string> questions { get; protected set; }
        public List<string> imagesQuestion { get; protected set; }
        public List<string> reponses { get; protected set; }
        public int score { get; protected set; }
        public int intervalle { get; protected set; }

        // Méthodes

        /// <summary>
        /// Permet l’enchaînement des différentes questions
        /// </summary>
        public virtual void Jouer()
        { }

        /// <summary>
        /// Compare la entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste des erreurs (une instance = [réponse juste, réponse du joueur])</returns>
        public List<List<string>> VerifierReponse(string reponse, int numQuestion)
        {
            List<List<string>> erreurs = new List<List<string>>();

            for (int i = 0; i < reponse.Length; i++)
            {
                if (this.reponses[numQuestion][i] != reponse[i])
                {
                    List<string> couple = new List<string>();
                    couple.Add(this.reponses[numQuestion][i].ToString());
                    couple.Add(reponse[i].ToString());
                    erreurs.Add(couple);
                }
            }

            return erreurs;
        }

        /// <summary>
        /// Affiche à l’utilisateur le nombre d’erreurs qu’il a commis avec les réponses qu’il aurait dû mettre.
        /// </summary>
        /// <param name="erreurs">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        /// <param name="numQuestion">Numéro de la question dont on veut afficher les erreurs</param>
        /// <returns>Chaîne de caractères à afficher au joueur</returns>
        public string AfficherErreurs(List<List<string>> erreurs, int numQuestion)
        {
            int nbJuste = this.reponses[numQuestion].Length - erreurs.Count;
            string message;

            if (nbJuste <= 1)
            {
                message = "Vous avez " + nbJuste + " réponse juste !\r\n";
            }

            else
            {
                message = "Vous avez " + nbJuste + " réponses justes !\r\n";
            }

            message += "Voici vous erreurs. Vous avez répondu :\r\n";

            for (int i = 0; i < erreurs.Count; i++)
            {
                message += "  –  " + erreurs[i][1] + " au lieu de " + erreurs[i][0] + "\r\n";
            }

            return message;
        }

        /// <summary>
        /// Met à jour le score de l’utilisateur.
        /// </summary>
        /// <param name="erreurs">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        /// <param name="numQuestion">Numéro de la question dont on calcule le nombre de réponses justes</param>
        public void ModifierScore(List<List<string>> erreurs, int numQuestion)
        {
            this.score += this.reponses[numQuestion].Length - erreurs.Count;
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public double CalculerResultat()
        {
            return this.score / this.questions.Count * 100.0;
        }

        /// <summary>
        /// Récupère la consigne et la démonstration du test dont on entre l'id
        /// </summary>
        /// <param name="idTest">Id du test (entre 1 et 7)</param>
        protected void GetDemonstration(int idTest)
        {
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
        protected void GenerateListQuestions(int idTest, int nbQuestions)
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
                            questions.Add(reader["Q.Question"].ToString());
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
