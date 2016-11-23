using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EMACApp
{
    public partial class TestMaths_Form : Form
    {
        List<string> question = new List<string>();
        private int compteur;


        private const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";
        public TestMaths_Form()
        {
            InitializeComponent();
            Answer_groupBox.Hide();
            Choice1_radioBtn.Hide();
            Choice2_radioBtn.Hide();
            Choice3_radioBtn.Hide();
            Choice4_radioBtn.Hide();
            Valider_Btn.Hide();

            Next_Btn.Hide();
            
        }
        OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

        private void TestMaths_Form_Load(object sender, EventArgs e)
        {
            // OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);
            using (connexionBDD)
            {
                // Ouverture de la connexion
                connexionBDD.Open();

                // Creation d'une requete
                using (OleDbCommand requete = new OleDbCommand())
                {
                    requete.Connection = connexionBDD;
                    // TODO faire un If afin de récupérer le niveau et de différer la consigne
                    requete.CommandText = "SELECT * FROM Test WHERE Id=6";
                    OleDbDataReader reader = requete.ExecuteReader();

                    // Si le resultat comporte des lignes
                    if (reader.HasRows)
                    {
                        // reader.Read() passe a la ligne suivante et renvoit false a la fin du DataReader
                        while (reader.Read())
                        {
                            // Recuperation des valeur + constitution de la ligne
                            string ligne = "Consigne :\r\n " + reader["Consigne"];

                            // Ajout de la ligne au textbox
                            ConsigneMaths_TxtBox.Text += ligne;
                        }
                        connexionBDD.Close();
                    }
                }
            }
        }




        private void ConsigneMaths_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Begin_Btn_Click(object sender, EventArgs e)
        {
            Answer_groupBox.Show();
            Choice1_radioBtn.Show();
            Choice1_radioBtn.Checked = false;
            Choice2_radioBtn.Show();
            Choice2_radioBtn.Checked = false;
            Choice3_radioBtn.Show();
            Choice3_radioBtn.Checked = false;
            Choice4_radioBtn.Show();
            Choice4_radioBtn.Checked = false;
            Valider_Btn.Show();
            Next_Btn.Show();
            Begin_Btn.Hide();
            Next_Btn.Enabled = false;





            OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);

            // Creation d'une requete
            using (connexionBDD)
            {

                connexionBDD.Open();
                using (OleDbCommand requete2 = new OleDbCommand())
                {
                    requete2.Connection = connexionBDD;
                    requete2.CommandText = "SELECT * FROM Questions WHERE Test=5 ";
                    OleDbDataReader reader2 = requete2.ExecuteReader();

                    // Si le resultat comporte des lignes
                    //    if(reader2.HasRows)
                    while (reader2.Read()) 
                    {
                        //reader2.Read();
                        
                        // ConsigneMaths_TxtBox.Text = "Question :" + reader2["Question"];
                        question.Add((string)reader2["Question"]);
                        ConsigneMaths_TxtBox.Text =(string) question[0];
                        compteur = 1;

                    }
                }
            }
        }










        private void Next_Btn_Click(object sender, EventArgs e)
        {
            if (compteur < question.Count)
            {
                Next_Btn.Enabled = false;
                Valider_Btn.Enabled = true;
                ConsigneMaths_TxtBox.Text = question[compteur];
                compteur++;
            }
            else
            {
                MessageBox.Show("Vous avez fini!");
            }
        }
      
        private void Valider_Btn_Click(object sender, EventArgs e)
        {   string indice_reponse="0";
            //On recupère la valeur du radioButton sélectionné
            if (Choice1_radioBtn.Checked)
            {
                indice_reponse = "1";
            }

        
            if (Choice2_radioBtn.Checked)
            {
                indice_reponse = "2" ;
            }

            if (Choice3_radioBtn.Checked)
            {
                indice_reponse = "3";
            }
            if (Choice4_radioBtn.Checked)
            {
                indice_reponse = "4";
            }
        

            // on recupère la bonne réponse dans la BDD

        OleDbConnection connexionBDD = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDD);
            using (connexionBDD)
            {

                connexionBDD.Open();
                using (OleDbCommand requete3 = new OleDbCommand())
                { //Affiner la requête selon le niveau de difficulté
                    requete3.Connection = connexionBDD;
                    requete3.CommandText = "SELECT * FROM Questions  ";
                    OleDbDataReader reader3 = requete3.ExecuteReader();

                    // Si le resultat comporte des lignes
                    if (reader3.HasRows)
                    {
                        reader3.Read();
                        
                        
                       if (indice_reponse == (string)reader3["Reponse"])
                       {
                            MessageBox.Show("Bonne réponse ! Bien joué !");
                            Next_Btn.Enabled = true;
                            Valider_Btn.Enabled = false;
                        }
                       else
                        {
                          MessageBox.Show("Erreur. La bonne réponse est  :"+ reader3["Reponse"]);
                            Next_Btn.Enabled = true;
                            Valider_Btn.Enabled = false;
                        }



                    }
                    
                }
            }
        }

        private void Choice3_radioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Answer_groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
    }


