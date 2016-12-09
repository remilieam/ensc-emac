using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestProblemes : Test
    {
        protected int compteur;
        protected int nbquestion = 10;
        protected int idTest;

        public TestProblemes(bool difficulteTest)
        {
            difficulte = difficulteTest;

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
                        requete2.CommandText = "SELECT * FROM Questions q LEFT JOIN Images i ON i.Question=q.Id WHERE Test="+idTest+" and type='Difficile'";
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
                        requete2.CommandText = "SELECT * FROM Questions q LEFT JOIN Images i ON i.Question=q.Id WHERE Test=" + idTest + " and type='Facile'";
                        OleDbDataReader reader2 = requete2.ExecuteReader();

                        // Si le resultat comporte des lignes
                        //    if(reader2.HasRows)
                        while (reader2.Read())
                        {
                            //reader2.Read();

                            // ConsigneMaths_TxtBox.Text = "Question :" + reader2["Question"];
                            questions.Add((string)reader2["Q.Question"]);
                            imagesQuestion.Add(reader2["ImageQuestion"].ToString());
                            // Génération aléatoire des questions
                            reponses.Add(reader2["Reponse"].ToString());
                            Random rnd = new Random();
                            //questions.Sort((x, y) => rnd.Next(-1, 2));
                         
                            //reponses.Sort((x, y) => rnd.Next(-1, 2));
                            //imagesQuestion.Sort((x, y) => rnd.Next(-1, 2));
                            //for (int i = 0; i < questions.Count; i++)
                            //{
                               // questions[i] = questions[rnd.Next(0, questions.Count)];
                               // reponses[i] = reponses[rnd.Next(0, questions.Count)];
                               // imagesQuestion[i] = imagesQuestion[rnd.Next(0, questions.Count)];
                            //}
                           
                        }
                    }
                }

                connexionBDD.Close();
            }

        }

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

        public override string AfficherErreur(List<string> erreur)
        {
            return "";
        }

        public override double CalculerResultat()
        {
            return Math.Round(this.score * 100.0 / 10);
        }
    }
}