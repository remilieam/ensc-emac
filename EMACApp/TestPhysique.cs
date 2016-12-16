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
        private int compteur = 0; // Contient le numéro de la question en cours (10 questions au total)
        public TestProblemesPhysiques test; // Contient le test en cours

        // Constructeur du test de problèmes mathématiques (enchaînement des questions)
        public TestPhysique_Form(TestProblemesPhysiques testRecu)
        {
            InitializeComponent();
            this.test = testRecu;
        }

        // Affichage de la première question
        private void TestPhysique_Form_Load(object sender, EventArgs e)
        {
            Terminer_Button.Hide();
            this.AfficherQuestion();
        }

        // Passage à la question suivante
        private void Suivant_Button_Click(object sender, EventArgs e)
        {
            // Cas où le joueur n’a pas répondu à toutes les questions
            if (this.compteur < 10)
            {
                AfficherQuestion();
            }

            // Cas où le joueur a terminé le test
            else
            {
                Reponse_GroupBox.Hide();
                Valider_Button.Hide();
                Suivant_Button.Hide();
                Terminer_Button.Show();
                double resultat = this.test.CalculerResultat();
                MessageBox.Show("Vous avez fini la série !");
                QuestionPhysique_Label.Text = "Votre super résultat est de : " + resultat + " % ";
            }
        }

        // Vérification de la réponse du joueur
        private void Valider_Button_Click(object sender, EventArgs e)
        {
            string indice_reponse = "0";

            // On recupère la valeur du RadioButton sélectionné
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

            // En cas de bonne réponse
            if (indice_reponse == this.test.reponses[this.compteur - 1])
            {
                MessageBox.Show("Bonne réponse ! Bien joué !");
                Suivant_Button.Enabled = true;
                Valider_Button.Enabled = false;
            }

            // En cas de mauvaise réponse
            else
            {
                MessageBox.Show("Erreur. La bonne réponse est : " + this.test.reponses[this.compteur - 1]);
                Suivant_Button.Enabled = true;
                Valider_Button.Enabled = false;
            }
        }

        // Fermeture du formulaire
        private void Terminer_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fermeture du formulaire pour retourner au menu
        private void Menu_Panel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fermeture du formulaire
        private void TestPhysique_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Affichage de la question
        private void AfficherQuestion()
        {
            // Décochage des boutons radios
            Choix1_RadioButton.Checked = false;
            Choix2_RadioButton.Checked = false;
            Choix3_RadioButton.Checked = false;
            Choix4_RadioButton.Checked = false;

            // Gestion des boutons
            Suivant_Button.Enabled = false;
            Valider_Button.Enabled = true;

            // Affichage de la première question question
            QuestionPhysique_Label.Text = "Question n° " + (this.compteur + 1) + " : " + this.test.questions[this.compteur];

            // Affichage de la première image si nécessaire
            if (this.test.imagesQuestion[0] == "")
            {
                PbPhysique_PictureBox.Hide();
            }

            else
            {
                PbPhysique_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_5\\" + this.test.imagesQuestion[0];
            }

            this.compteur++;
        }
    }
}
