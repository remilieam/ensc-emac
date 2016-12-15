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

        public TestProblemes(List<string>Rep)
        {
           reponses=Rep;

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
                         
                           
                        }
                    }
                }

                connexionBDD.Close();
            }
            // Nouvelles istes contenant les questions et les réponses
            List<string> newQuestions = new List<string>();
            List<string> newReponses = new List<string>();
            List<string> newImages= new List<string>();
            int nombre = 10;
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
            double nbQuestionsTotales = 0;

            for (int i = 0; i < this.reponses.Count; i++)
            {
                nbQuestionsTotales += this.reponses[i].Length;
            }

            return Math.Round(this.score * 100.0 / nbQuestionsTotales, 2);
        }
    }
}