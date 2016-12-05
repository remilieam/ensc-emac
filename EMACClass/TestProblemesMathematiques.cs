using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestProblemesMathematiques : TestProblemes
    {
        private bool difficulteTest;

        // Attributs inhérents à la classe
        private int idTest=4;
        private int nbQuestions = 10;



        /*  public TestProblemesMathematiques(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
              : base(difficulteTest, intervalleTest, donneesTest)
          {
              nom = "Problèmes mathématiques";
          }
          */
        public TestProblemesMathematiques(bool difficulteTest) : base(difficulteTest)
        {
            nom = "Problèmes Mathématiques";
            consigne = "";
            imagesDemo = new List<string>();
            texteDemo = new List<string>();
            difficulte = difficulteTest;
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;
            compteur = 0;

            RecupererDemonstration();
            GenererListeQuestions();

        }


        protected override void GenererListeQuestions()
        {
            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            // Creation d'une requete
            using (connexionBDD)
            {

                connexionBDD.Open();
                using (OleDbCommand requete2 = new OleDbCommand())
                {
                    requete2.Connection = connexionBDD;
                    if (difficulte == true)
                    {
                        requete2.CommandText = "SELECT * FROM Questions q LEFT JOIN Images i ON i.Question=q.Id WHERE Test=4 and type='Difficile'";
                        OleDbDataReader reader2 = requete2.ExecuteReader();

                        // Si le resultat comporte des lignes
                        //    if(reader2.HasRows)
                        while (reader2.Read())
                        {
                            //reader2.Read();

                            // ConsigneMaths_TxtBox.Text = "Question :" + reader2["Question"];
                            questions.Add((string)reader2["Q.Question"]);
                            imagesQuestion.Add(reader2["ImageQuestion"].ToString());
                            reponses.Add(reader2["Reponse"].ToString());
                        }
                    }

                    else
                    {
                        requete2.CommandText = "SELECT * FROM Questions q LEFT JOIN Images i ON i.Question=q.Id WHERE Test=4 and type='Facile'";
                        OleDbDataReader reader2 = requete2.ExecuteReader();

                        // Si le resultat comporte des lignes
                        //    if(reader2.HasRows)
                        while (reader2.Read())
                        {
                            //reader2.Read();

                            // ConsigneMaths_TxtBox.Text = "Question :" + reader2["Question"];
                            questions.Add((string)reader2["Q.Question"]);
                            imagesQuestion.Add(reader2["ImageQuestion"].ToString());

                            reponses.Add(reader2["Reponse"].ToString());
                        }
                    }
                }
                connexionBDD.Close();
            }

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
        /// Compare la réponse entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste avec des erreurs ([réponse juste, réponse du joueur])</returns>
        public List<string> VerifierBouton(string reponse, int numQuestion)
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


        public override double CalculerResultat()
        {
            return Math.Round(this.score * 100.0 / 10);
        }




    }
}
  
