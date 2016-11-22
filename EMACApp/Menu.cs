using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EMACClass;

namespace EMACApp
{
    public partial class MenuForm : Form
    {
        // Chemin vers la base de données
        private const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            HomeForm home = new HomeForm();
            home.Show();
        }

        private void ReturnMenuButtom_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm home = new HomeForm();
            home.Show();
        }

        private void Test1EasyMenuButtom_Click(object sender, EventArgs e)
        {
            // Variables contenant les informations de la série de questions
            string nom = "";
            string consigne = "";
            List<string> regles = new List<string>();
            List<string> reponses = new List<string>();
            List<string> imagesDemo = new List<string>();
            List<string> texteDemo = new List<string>();
            List<string> ecrans = new List<string>();

            // Récupération des données depuis la base de données
            GenerateListQuestions(1, 10, nom, consigne, regles, reponses, imagesDemo, texteDemo, ecrans);

            /*#region Récupération des données depuis la base de données

            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            using (connexionBDD)
            {
                connexionBDD.Open();

                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;

                    // Récupération du test
                    requete.CommandText = "SELECT  * FROM Test WHERE Id = 1";
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        nom= reader["Nom"].ToString();
                        consigne = reader["Consigne"].ToString();
                    }
                    
                    // Récupération des 10 questions du test
                    requete.CommandText = "SELECT TOP 10 * FROM Questions Q INNER JOIN Images I ON I.Question = Q.Id WHERE Q.Test = 1 ORDER BY RND([Q.Id])";
                    reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            regles.Add(reader["Question"].ToString());
                            reponses.Add(reader["Reponse"].ToString());
                            ecrans.Add(reader["ImageQuestion"].ToString());
                        }
                    }

                    // Récupération de la démonstration
                    requete.CommandText = "SELECT * FROM Demo WHERE Test = 1";
                    reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            imagesDemo.Add(reader["ImageDemo"].ToString());
                            texteDemo.Add(reader["TexteDemo"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }

            #endregion*/

            // Instanciation du test
            TestPerceptionMemoire test = new TestPerceptionMemoire(nom, consigne, imagesDemo, false, regles, ecrans, reponses, 4);
            TestPerceptionForm testPerception = new TestPerceptionForm();
            testPerception.Show();
            testPerception.G
        }

        private void GenerateListQuestions(int idTest, int nbQuestions, string nom, string consigne, List<string> regles, List<string> reponses, List<string> imagesDemo, List<string> texteDemo, List<string> ecrans)
        {
            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            using (connexionBDD)
            {
                connexionBDD.Open();

                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;

                    // Récupération du test
                    requete.CommandText = "SELECT  * FROM Test WHERE Id = " + idTest;
                    OleDbDataReader reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        nom = reader["Nom"].ToString();
                        consigne = reader["Consigne"].ToString();
                    }

                    // Récupération des 10 questions du test
                    requete.CommandText = "SELECT TOP " + nbQuestions + " * FROM Questions Q INNER JOIN Images I ON I.Question = Q.Id WHERE Q.Test = " + idTest + " ORDER BY RND([Q.Id])";
                    reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            regles.Add(reader["Question"].ToString());
                            reponses.Add(reader["Reponse"].ToString());
                            ecrans.Add(reader["ImageQuestion"].ToString());
                        }
                    }

                    // Récupération de la démonstration
                    requete.CommandText = "SELECT * FROM Demo WHERE Test = " + idTest;
                    reader = requete.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            imagesDemo.Add(reader["ImageDemo"].ToString());
                            texteDemo.Add(reader["TexteDemo"].ToString());
                        }
                    }
                }

                connexionBDD.Close();
            }
        }
    }
}
