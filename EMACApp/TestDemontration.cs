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

        // Constructeur du formulaire d’affichage de la consigne et de la démonstration
        public TestDemonstration_Form(Test testRecu)
        {
            InitializeComponent();
            this.test = testRecu;
        }

        // Récupération du nom et de la consigne du test
        private void TestPerception_Form_Load(object sender, EventArgs e)
        {
            NomTest_Label.Text = this.test.nom;
            Consigne_Label.Text = this.test.consigne;
        }

        // Affichage de l’écran suivant
        private void Suivant_PictureBox_Click(object sender, EventArgs e)
        {
            if (this.compteur == this.test.imagesDemo.Count)
            {
                this.compteur = 0;
            }

            else
            {
                this.compteur++;
            }

            if (this.compteur == 0)
            {
                Consigne_Label.Show();
                ImageDemo_PictureBox.Hide();
            }

            else
            {
                Consigne_Label.Hide();
                ImageDemo_PictureBox.Show();
                ImageDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\" + this.test.imagesDemo[this.compteur - 1];
            }
        }

        // Affichage de l’écran précédent
        private void Precedent_PictureBox_Click(object sender, EventArgs e)
        {
            if (this.compteur == 0)
            {
                this.compteur = this.test.imagesDemo.Count;
            }

            else
            {
                this.compteur--;
            }

            if (this.compteur == 0)
            {
                Consigne_Label.Show();
                ImageDemo_PictureBox.Hide();
            }

            else
            {
                Consigne_Label.Hide();
                ImageDemo_PictureBox.Show();
                ImageDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\" + this.test.imagesDemo[this.compteur - 1];
            }
        }

        // Fermeture du formulaire pour accéder au test
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
