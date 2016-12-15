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
    public partial class TestDemonstration_Form : Form
    {
        private int compteur = 0;
        private Test test;

        public TestDemonstration_Form(Test testRecu)
        {
            InitializeComponent();
            test = testRecu;
        }

        private void TestPerception_Form_Load(object sender, EventArgs e)
        {
            NomTest_Label.Text = test.nom;
            Consigne_Label.Text = test.consigne + " ";
        }

        private void Suivant_PictureBox_Click(object sender, EventArgs e)
        {
            if (compteur == test.imagesDemo.Count)
            {
                compteur = 0;
            }

            else
            {
                compteur++;
            }

            if(compteur == 0)
            {
                Consigne_Label.Show();
                ImageDemo_PictureBox.Hide();

                Consigne_Label.Text = test.consigne + " ";
            }

            else
            {
                Consigne_Label.Hide();
                ImageDemo_PictureBox.Show();
                //TextDemo_TextBox.Show();

                ImageDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\" + test.imagesDemo[compteur-1];
            }
        }

        private void Precedent_PictureBox_Click(object sender, EventArgs e)
        {
            if (compteur == 0)
            {
                compteur = test.imagesDemo.Count;
            }

            else
            {
                compteur--;
            }

            if (compteur == 0)
            {
                Consigne_Label.Show();
                ImageDemo_PictureBox.Hide();

                Consigne_Label.Text = test.consigne + " " + compteur;
            }

            else
            {
                Consigne_Label.Hide();
                ImageDemo_PictureBox.Show();

                ImageDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\" + test.imagesDemo[compteur - 1];
            }
        }

        private void Jouer_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Fermeture du formulaire pour retourner au menu
        private void Menu_Panel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
