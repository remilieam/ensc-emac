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
    public partial class TestCalcul_Form : Form
    {
        private TestCalculMental test; // Contient le test en cours
        private int compteurQuestion = 0; // Contient le numéro de la question en cours (10 questions au total)
        private int decompte; // Pour faire le décompte pour l’affichage des questions

        // Constructeur du test de calcul (enchaînement des questions)
        public TestCalcul_Form(TestCalculMental testRecu)
        {
            InitializeComponent();
            this.test = testRecu;

            if (test.difficulte)
            {
                DisplayQuestion_Timer.Interval = this.test.intervalle * 1000;
                DisplayQuestion_Timer.Tick += new EventHandler(DisplayQuestionTimer_Tick);
                CountTime_Timer.Tick += new EventHandler(CountTimeTimerTick);
            }
        }

        // Génération d’une liste d’additions et appel de la fonction affichant la première question
        private void Addition_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Addition");
            this.Hide_First_Interface();
            this.Show_Question();
        }

        // Génération d’une liste de soustractions et appel de la fonction affichant la première question
        private void Subtraction_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Soustraction");
            this.Hide_First_Interface();
            this.Show_Question();
        }

        // Génération d’une liste de multiplications et appel de la fonction affichant la première question
        private void Multiplication_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Multiplication");
            this.Hide_First_Interface();
            this.Show_Question();
        }

        // Génération d’une liste de divisions et appel de la fonction affichant la première question
        private void Division_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Division");
            this.Hide_First_Interface();
            this.Show_Question();
        }

        // Masquage de l’interface permettant à l’utilisateur de choisir l’opération sur laquelle il veut se tester
        private void Hide_First_Interface()
        {
            Choice_TextBox.Hide();
            Addition_Button.Hide();
            Subtraction_Button.Hide();
            Multiplication_Button.Hide();
            Division_Button.Hide();
        }

        // Affichage de la question
        private void Show_Question()
        {
            ProgressTest3_TextBox.Text = "Question " + (this.compteurQuestion + 1) + " sur " + this.test.questions.Count;
            Operation_TextBlox.Text = this.test.questions[this.compteurQuestion];
            Answer_TextBox.Clear();

            Area_PictureBox.Show();
            Equal_Label.Show();
            ProgressTest3_TextBox.Show();
            Operation_TextBlox.Show();
            Answer_TextBox.Show();
            Confirm_Button.Show();

            // Démarrage du chronomètre en mode difficile
            if (test.difficulte)
            {
                decompte = test.intervalle;
                Timer_Panel.Show();
                CountDisplay_Label.Show();
                CountDisplay_Label.Text = decompte.ToString();
                CountTime_Timer.Start();
                DisplayQuestion_Timer.Start();
            }
        }

        // Décompte
        public void CountTimeTimerTick(object sender, EventArgs e)
        {
            decompte--;
            CountDisplay_Label.Text = decompte.ToString();
        }

        // Événement si le chronomètre atteint 5 secondes
        private void DisplayQuestionTimer_Tick(object sender, EventArgs e)
        {
            CountTime_Timer.Stop();
            Timer_Panel.Hide();
            CountDisplay_Label.Hide();

            DisplayQuestion_Timer.Stop();
            this.Show_Answer("0");
        }

        // Appel de la fonction affichant la réponse
        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (test.difficulte)
            {
                CountTime_Timer.Stop();
                Timer_Panel.Hide();
                CountDisplay_Label.Hide();

                DisplayQuestion_Timer.Stop();
            }

            this.Show_Answer(Answer_TextBox.Text);
        }

        // Affichage du message disant si la réponse est correcte ou non
        private void Show_Answer(string reponseJoueur)
        {
            List<string> erreurJoueur = this.test.VerifierReponse(reponseJoueur, this.compteurQuestion);

            if (erreurJoueur.Count == 0)
            {
                if (MessageBox.Show("Bravo ! Votre calcul est correct !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    this.Next_Question();
                }
            }

            else
            {
                string message = this.test.AfficherErreur(erreurJoueur);

                if (MessageBox.Show(message, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    this.Next_Question();
                }
            }
        }

        // Gestion du passage à la question suivante ou au résultat
        private void Next_Question()
        {
            Area_PictureBox.Hide();
            Equal_Label.Hide();
            ProgressTest3_TextBox.Hide();
            Operation_TextBlox.Hide();
            Answer_TextBox.Hide();
            Confirm_Button.Hide();

            if (compteurQuestion < 9)
            {
                this.compteurQuestion++;
                this.Show_Question();
            }

            else
            {
                this.Show_Result();
            }
        }

        // Affichage du résultat (proportion de bonnes réponses du joueur)
        private void Show_Result()
        {
            Result_TextBox.Text = "Vous avez un taux de réussite de " + this.test.CalculerResultat() + " % !";
            Result_TextBox.Show();
            End_Button.Show();
        }

        // Fermeture du formulaire
        private void End_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
