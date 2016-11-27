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
        private int idTest;
        private int nbQuestions = 10;



        /*  public TestProblemesMathematiques(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
              : base(difficulteTest, intervalleTest, donneesTest)
          {
              nom = "Problèmes mathématiques";
          }
          */
        public TestProblemesMathematiques(bool difficulteTest) : base(difficulteTest)
        {
            nom = "";
            consigne = "";
            imagesDemo = new List<string>();
            texteDemo = new List<string>();
            difficulte = difficulteTest;
            if (difficulte == false)
            {
                idTest = 4;
            }
            else
            {
                idTest = 5;
            }
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;
            compteur = 0;


            RecupererDemonstration();
            GenererListeQuestions();

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


        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            List<string> erreurs = new List<string>();
            erreurs.Add("");

            for (int i = 0; i < this.reponses[numQuestion].Length; i++)
            {
                if (this.reponses[numQuestion][i] != reponse[i])
                {
                    erreurs.Add(this.reponses[numQuestion].ToString());
                    erreurs.Add(reponse.ToString());
                }

                else
                {
                    this.score++;
                }
            }

            return erreurs;
        }
        public override string AfficherErreur(List<string> erreur)
        {
            if (erreur[1] == "0")
            {
                return "Vous n’avez cliqué sur aucun bouton.\r\nPour information, il fallait appuyer sur bouton " + erreur[0] + ".";
            }

            return "Vous avez cliqué sur le bouton " + erreur[1] + " au lieu du bouton " + erreur[0] + ".";
        }
    }
}
