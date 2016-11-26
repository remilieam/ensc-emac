﻿using System;
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
        private int idTest = 3;
        private int nbQuestions = 10;

        public TestCalculMental(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
        {
            nom = "Calcul mental";
            difficulte = difficulteTest;
            score = 0;
            intervalle = intervalleTest;
        }
        
        /// <summary>
        /// Construit un nouveau test “Attention et concentration”.
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile)
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestCalculMental(bool difficulteTest)
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

            RecupererDemonstration();
            GenererListeQuestions();
        }

        /// <summary>
        /// Compare la réponse entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numSerie">Numéro de la série à laquelle appartient la question</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste avec des erreurs ([réponse juste, réponse du joueur])</returns>
        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            List<string> erreurs = new List<string>();

            if (this.reponses[numQuestion].ToString() != reponse)
            {
                erreurs.Add(this.reponses[numQuestion].ToString());
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
        /// <param name="erreur">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        /// <returns>Chaîne de caractères à afficher au joueur</returns>
        public override string AfficherErreur(List<string> erreur)
        {
            if (erreur[1] == "0")
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
            return this.score * 100.0 / this.nbQuestions;
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

                    // Récupération des questions du test
                    requete.CommandText = "SELECT TOP " + this.nbQuestions + " * FROM Questions WHERE Test = " + this.idTest + " ORDER BY RND([Id])";
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.questions.Add(reader["Question"].ToString());
                            this.reponses.Add(reader["Reponse"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }
        }
    }
}
