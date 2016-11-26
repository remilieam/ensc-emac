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
    public partial class TestAttention_Form : Form
    {
        private TestAttentionConcentration test; // Contient le test en cours
        private int compteurSerie = 0; // Contient le numéro de la série en cours (3 séries au total)
        private int compteurQuestion = 0; // Contient le numéro de la question en cours (5 questions par série)
        private string chaineReponse = ""; // Contient les réponses du joueur pour la série en cours

        // Constructeur du test d’attention (enchaînement des questions)
        public TestAttention_Form(TestAttentionConcentration testRecu)
        {
            InitializeComponent();
            test = testRecu;
        }

        // Affichage de la première règle et définition du chronomètre si le joueur a choisi le mode difficile
        private void TestAttention_Form_Load(object sender, EventArgs e)
        {
            Progress_TextBox.Text = "Série : " + (compteurSerie + 1) + "        Question : " + (compteurQuestion + 1);

            if (test.difficulte)
            {
                Rule_TextBox.Text = "Consigne de la série " + compteurSerie + " :\r\n\r\n" + test.questions[compteurSerie];
                DisplayQuestion_Timer.Interval = test.intervalle * 1000;
            }

            else
            {
                Rule_TextBox.Text = "Consigne pour les 3 séries de questions :\r\n\r\n" + test.questions[compteurSerie];
            }
        }
        
        // Appel de la fonction qui affiche la question
        private void Next_Button_Click(object sender, EventArgs e)
        {
            Rule_TextBox.Hide();
            Next_Button.Hide();

            this.AfficherQuestion();
        }

        private void AfficherConsigne()
        {
            Progress_TextBox.Text = "Série : " + (compteurSerie + 1) + "            Question : " + (compteurQuestion + 1);

            if (test.difficulte)
            {
                Rule_TextBox.Text = "Consigne de la série " + compteurSerie + " :\r\n\r\n" + test.questions[compteurSerie];
            }

            Rule_TextBox.Show();
            Next_Button.Show();
        }

        // Affichage de l’image et des boutons
        private void AfficherQuestion()
        {
            Progress_TextBox.Text = "Série : " + (compteurSerie + 1) + "        Question : " + (compteurQuestion + 1);

            Object_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_2\\" + test.imagesSeries[compteurSerie][compteurQuestion];
            Object_PictureBox.Show();
            Area_PictureBox.Show();
            Button3_Button.Show();

            if (compteurQuestion != 0)
            {
                Button2_Button.Show();
                Button1_Button.Show();
            }

            if (test.difficulte)
            {
                DisplayQuestion_Timer.Start();
                DisplayQuestion_Timer.Tick += new EventHandler(DisplayQuestionTimerTick);
            }
        }

        // Affichage de la réponse dans le cas où on n’a pas répondu à temps
        public void DisplayQuestionTimerTick(object sender, EventArgs e)
        {
            DisplayQuestion_Timer.Stop();
            this.AfficherReponse("0");
        }

        // Affichage de la réponse dans le cas où on a appuyé sur le bouton 1
        private void Button1_Button_Click(object sender, EventArgs e)
        {
            DisplayQuestion_Timer.Stop();
            this.AfficherReponse("1");
        }

        // Affichage de la réponse dans le cas où on a appuyé sur le bouton 2
        private void Button2_Button_Click(object sender, EventArgs e)
        {
            DisplayQuestion_Timer.Stop();
            this.AfficherReponse("2");
        }

        // Affichage de la réponse dans le cas où on a appuyé sur le bouton 3
        private void Button3_Button_Click(object sender, EventArgs e)
        {
            DisplayQuestion_Timer.Stop();
            this.AfficherReponse("3");
        }

        // Affichage de la réponse selon si elle est juste ou non
        private void AfficherReponse(string reponseJoueur)
        {
            chaineReponse += reponseJoueur;

            List<string> erreurJoueur = test.VerifierBouton(reponseJoueur, compteurSerie, compteurQuestion);

            if (erreurJoueur.Count == 0)
            {
                if (MessageBox.Show("OK ! Vous avez choisi le bon bouton !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    this.PasserQuestionSuivante();
                }
            }

            else
            {
                string message = test.AfficherErreur(erreurJoueur);

                if (MessageBox.Show(message, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    this.PasserQuestionSuivante();
                }
            }
        }

        // Gestion du passage à la question suivante
        private void PasserQuestionSuivante()
        {
            Object_PictureBox.Hide();
            Area_PictureBox.Hide();
            Button1_Button.Hide();
            Button2_Button.Hide();
            Button3_Button.Hide();

            // Cas où on n’en est pas à la dernière série de questions
            if (compteurSerie < 2)
            {
                // Cas où on n’est pas à la dernière question de la série
                if (compteurQuestion < 4)
                {
                    // Passage à la question suivante
                    compteurQuestion++;
                    this.AfficherQuestion();
                }

                // Cas où on vient de faire la dernière question de la série
                else
                {
                    // Passage à la série suivante
                    compteurSerie++;
                    compteurQuestion = 0;
                    chaineReponse = "";
                    if (test.difficulte) { this.AfficherConsigne(); }
                    else { this.AfficherQuestion(); }
                }
            }

            // Cas où on en train de faire la dernière série
            else
            {
                // Cas où on n’est pas à la dernière question de la dernière série
                if (compteurQuestion < 4)
                {
                    // Passage à la question suivante
                    compteurQuestion++;
                    this.AfficherQuestion();
                }

                // Cas où on vient de faire la dernière question de la dernière série
                else
                {
                    // Affichage du résultat final
                    this.AfficherResultat();
                }
            }
        }

        // Affichage du résultat à l’issue des 3 séries de 5 questions
        private void AfficherResultat()
        {
            Result_TextBox.Text = "Vous avez un taux de réussite de " + test.CalculerResultat() + " % !";
            Result_TextBox.Show();
            End_Button.Show();
        }

        // Fermeture du formulaire à la fin du test
        private void End_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
