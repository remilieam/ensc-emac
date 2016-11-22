using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMACApp
{
    public partial class TestForm : Form
    {
        private const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestTextBox.Clear();

            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            using (connexionBDD)
            {
                // Ouverture de la connexion
                connexionBDD.Open();

                // Creation d'une requete
                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;
                    requete.CommandText = "SELECT * FROM Questions";
                    OleDbDataReader reader = requete.ExecuteReader();

                    // Si le resultat comporte des lignes
                    if (reader.HasRows)
                    {
                        // reader.Read() passe a la ligne suivante et renvoit false a la fin du DataReader
                        while (reader.Read())
                        {
                            // Recuperation des valeur + constitution de la ligne
                            string ligne = reader["Id"] + "Question : " + reader["Question"] + "\r\nRéponse : " + reader["Reponse"] + "\r\n\r\n";

                            // Ajout de la ligne au textbox
                            TestTextBox.Text += ligne;
                        }
                    }
                }

                using (OleDbCommand requete2 = new OleDbCommand())
                {
                    requete2.Connection = connexionBDD;
                    requete2.CommandText = "SELECT * FROM Images WHERE Question = 4";
                    OleDbDataReader reader2 = requete2.ExecuteReader();

                    // Si le resultat comporte des lignes
                    if (reader2.HasRows)
                    {
                        reader2.Read();
                        string lien = "..\\..\\..\\EMACApp\\" + reader2["ImageQuestion"];
                        TestTextBox.Text += lien;
                        pictureBox1.ImageLocation = "..\\..\\..\\EMACApp\\" + reader2["ImageQuestion"];
                    }
                }

                // Fermeture de la connexion
                connexionBDD.Close();
            }
        }

        private void TestTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
