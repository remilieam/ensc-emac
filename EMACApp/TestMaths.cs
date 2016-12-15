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

        private void TestMaths_Form_Load(object sender, EventArgs e)
        {
            Choix1_RadioButton.Checked = false;
            Choix2_RadioButton.Checked = false;
            Choix3_RadioButton.Checked = false;
            Choix4_RadioButton.Checked = false;
            Suivant_Button.Enabled = false;
            Terminer_Button.Hide();

            QuestionMaths_Label.Text = "Question n° " + (compteur + 1) + " : " + test.questions[0];

            if (test.imagesQuestion[0] == "")
            {
                PbMaths_PictureBox.Hide();
            }

            else
            {
                PbMaths_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_4\\" + test.imagesQuestion[0];
            }

            compteur = 1;
        }

        private void Suivant_Button_Click(object sender, EventArgs e)
        {
            if (compteur < 10)
            {
                Suivant_Button.Enabled = false;
                Valider_Button.Enabled = true;

                QuestionMaths_Label.Text = "Question n° " + (compteur + 1) + " : " + test.questions[compteur];

                if (test.imagesQuestion[compteur] == "")
                {
                    PbMaths_PictureBox.Hide();
                }

                else
                {
                    PbMaths_PictureBox.Show();
                    PbMaths_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_4\\" + test.imagesQuestion[compteur];
                }

                Choix1_RadioButton.Checked = false;
                Choix2_RadioButton.Checked = false;
                Choix3_RadioButton.Checked = false;
                Choix4_RadioButton.Checked = false;
                compteur++;
            }

            else
            {
                Reponse_GroupBox.Hide();
                Valider_Button.Hide();
                Suivant_Button.Hide();
                Terminer_Button.Show();
                double resultat = test.CalculerResultat();
                MessageBox.Show("Vous avez fini la série !");
                QuestionMaths_Label.Text = "Votre super résultat est de : " + resultat + " % ";
            }
        }

        private void Valider_Button_Click(object sender, EventArgs e)
        {
            string indice_reponse = "0";

            // On recupère la valeur du radioButton sélectionné
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
                MessageBox.Show("Erreur. La bonne réponse est : " + test.reponses[compteur - 1]);
                Suivant_Button.Enabled = true;
                Valider_Button.Enabled = false;
            }
        }

        private void Terminer_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Panel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestMaths_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
