using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using EMACClass;

namespace EMACApp
{
    public partial class TestMaths_Form : Form
    {
        
        private int compteur;
        public TestProblemesMathematiques test;
        public int score;
       



        private const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";


        public TestMaths_Form(TestProblemesMathematiques testRecu)
        {
            InitializeComponent();
            test = testRecu;

           
        }

        public TestMaths_Form()
        {
            InitializeComponent();
           
            
          
            
            ConsigneMaths_TextBox.Enabled = false;
          

        }

        private void TestMaths_Form_Load(object sender, EventArgs e)
        {
            Choice1_RadioButton.Checked= false;
            Choice2_RadioButton.Checked = false;
            Choice3_RadioButton.Checked = false;
            Choice4_RadioButton.Checked = false;
         
            ReturnMenu_Button.Hide();
            Next_Button.Enabled = false;
            ConsigneMaths_TextBox.Text = test.questions[0] + test.imagesQuestion.Count + " " + test.questions.Count;
            if (test.imagesQuestion[0] == "")
            {
                PbMaths_pictureBox.Hide();
            }
            else
            {
                PbMaths_pictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_4\\" + test.imagesQuestion[0];
            }

            compteur = 1;
        }

        private void ConsigneMaths_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Next_Btn_Click(object sender, EventArgs e)
        {
            if (compteur < 10)
            {
                Next_Button.Enabled = false;
                Valider_Button.Enabled = true;
                ConsigneMaths_TextBox.Text = test.questions[compteur];
                if (test.imagesQuestion[compteur] == "")
                {
                    PbMaths_pictureBox.Hide();
                }
                else
                {
                    PbMaths_pictureBox.Show();
                    PbMaths_pictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_4\\" + test.imagesQuestion[compteur];
                }
                Choice1_RadioButton.Checked = false;
                Choice2_RadioButton.Checked = false;
                Choice3_RadioButton.Checked = false;
                Choice4_RadioButton.Checked = false;
                compteur++;
            }
            else
            {
                
                PbMaths_pictureBox.Hide();
                Valider_Button.Hide();
                Next_Button.Hide();
                Answer_GroupBox.Hide();
                ReturnMenu_Button.Show();
                double resultat =test.CalculerResultat() ;
                MessageBox.Show("Vous avez fini la série! ");
                ConsigneMaths_TextBox.Text = "Votre super résultat est de : " + resultat + " % ";
            }
        }

        private void Valider_Btn_Click(object sender, EventArgs e)
        {
            
            string indice_reponse = "0";
            //On recupère la valeur du radioButton sélectionné
            if (Choice1_RadioButton.Checked)
            {
                indice_reponse = "1";
            }


            if (Choice2_RadioButton.Checked)
            {
                indice_reponse = "2";
            }

            if (Choice3_RadioButton.Checked)
            {
                indice_reponse = "3";
            }
            if (Choice4_RadioButton.Checked)
            {
                indice_reponse = "4";
            }


            test.VerifierReponse(indice_reponse, compteur - 1);

            if (indice_reponse == test.reponses[compteur-1])
              {
                            MessageBox.Show("Bonne réponse ! Bien joué !");
                            Next_Button.Enabled = true;
                            Valider_Button.Enabled = false;
                              
               
              
              }
                        else
                        {
                            MessageBox.Show("Erreur. La bonne réponse est  : " + test.reponses[compteur-1] );
                            Next_Button.Enabled = true;
                            Valider_Button.Enabled = false;
                        }
           
        }

        private void Choice3_radioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Answer_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PbMaths_pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}


