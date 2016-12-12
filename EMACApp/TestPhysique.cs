using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EMACClass;

namespace EMACApp
{
    public partial class TestPhysique_Form : Form
    {
        private int compteur;
        public TestProblemesPhysiques test;
        public int score;




        private const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";

       
       
        
        public TestPhysique_Form(TestProblemesPhysiques testRecu)
        {
            InitializeComponent();
            test = testRecu;
        }

        public TestPhysique_Form()
        {
           
          
        }

        private void TestPhysique_Load(object sender, EventArgs e)
        {
            Choix1_RadioButton.Checked = false;
            Choix2_RadioButton.Checked = false;
            Choix3_RadioButton.Checked = false;
            Choix4_RadioButton.Checked = false;
            End_Button.Hide();
            Question_TextBox.Enabled = false;
            Suivant_Button.Enabled = false;

            Question_TextBox.Text = "Question n° " + (compteur + 1)+" :  " + test.questions[compteur];
            if (test.imagesQuestion[0] == "")
            {
                PbPhysique_PictureBox.Hide();
            }
            else
            {
                PbPhysique_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_5\\" + test.imagesQuestion[0];
            }

            compteur = 1;
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            if (compteur < 10)
            {
                Suivant_Button.Enabled = false;
                Valider_Button.Enabled = true;
               Question_TextBox.Text = "Question n°  " +(compteur+1)+" :  "+test.questions[compteur];
                if (test.imagesQuestion[compteur] == "")
                {
                    PbPhysique_PictureBox.Hide();
                }
                else
                {
                    PbPhysique_PictureBox.Show();
                    PbPhysique_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_5\\" + test.imagesQuestion[compteur];
                }
                Choix1_RadioButton.Checked = false;
                Choix2_RadioButton.Checked = false;
                Choix3_RadioButton.Checked = false;
                Choix4_RadioButton.Checked = false;
                compteur++;
            }
            else
            {
                Reponse_GroupeBox.Hide();
                Valider_Button.Hide();
                Suivant_Button.Hide();
                End_Button.Show();
                double resultat = test.CalculerResultat();
                MessageBox.Show("Vous avez fini la série! ");
                Question_TextBox.Text = "Votre super résultat est de : " + resultat + " % ";
            }
        }

        private void Valider_Button_Click(object sender, EventArgs e)
        {
            string indice_reponse = "0";
            //On recupère la valeur du radioButton sélectionné
            if (Choix1_RadioButton.Checked)
            {
                indice_reponse = "1";
            }


            if (Choix2_RadioButton.Checked)
            {
                indice_reponse = "2";
            }

            if (Choix3_RadioButton.Checked)
            {
                indice_reponse = "3";
            }
            if (Choix4_RadioButton.Checked)
            {
                indice_reponse = "4";
            }


            test.VerifierReponse(indice_reponse, compteur - 1);

            if (indice_reponse == test.reponses[compteur - 1])
            {
                MessageBox.Show("Bonne réponse ! Bien joué !");
                Suivant_Button.Enabled = true;
                Valider_Button.Enabled = false;



            }
            else
            {
                MessageBox.Show("Erreur. La bonne réponse est  : " + test.reponses[compteur - 1]);
                Suivant_Button.Enabled = true;
                Valider_Button.Enabled = false;
            }
        }

        private void End_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
