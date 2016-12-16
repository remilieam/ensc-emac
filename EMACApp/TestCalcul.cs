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
        }

        #region Méthodes liées à des actions sur les composants du formulaire

        // Fermeture du formulaire
        private void TestCalcul_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.test.difficulte)
            {
                AfficherQuestion_Timer.Stop();
                Decompte_Timer.Stop();
            }

            this.DialogResult = DialogResult.OK;
        }

        // Définition du chronomètre si le joueur a choisi le mode difficile
        private void TestCalcul_Form_Load(object sender, EventArgs e)
        {
            if (this.test.difficulte)
            {
                AfficherQuestion_Timer.Interval = this.test.intervalle * 1000;
            }
        }

        // Génération d’une liste d’additions et appel de la fonction affichant la première question
        private void Addition_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Addition");
            this.ChangerInterface();
            this.AfficherQuestion();
        }

        // Génération d’une liste de soustractions et appel de la fonction affichant la première question
        private void Soustraction_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Soustraction");
            this.ChangerInterface();
            this.AfficherQuestion();
        }

        // Génération d’une liste de multiplications et appel de la fonction affichant la première question
        private void Multiplication_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Multiplication");
            this.ChangerInterface();
            this.AfficherQuestion();
        }

        // Génération d’une liste de divisions et appel de la fonction affichant la première question
        private void Division_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Division");
            this.ChangerInterface();
            this.AfficherQuestion();
        }

        // Appel de la fonction affichant la réponse
        private void Valider_Button_Click(object sender, EventArgs e)
        {
            // Masquage et arrêt du chronomètre
            if (this.test.difficulte)
            {
                Decompte_Timer.Stop();
                Chrono_Panel.Hide();
                Decompte_Label.Hide();

                AfficherQuestion_Timer.Stop();
            }

            this.AfficherReponse(Reponse_TextBox.Text);
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

        #endregion

        #region Méthodes liées à des timers

        // Décompte
        public void Decompte_Timer_Tick(object sender, EventArgs e)
        {
            this.decompte--;
            Decompte_Label.Text = this.decompte.ToString();
        }

        // Événement si le chronomètre atteint 5 secondes
        private void AfficherQuestion_Timer_Tick(object sender, EventArgs e)
        {
            Decompte_Timer.Stop();
            Chrono_Panel.Hide();
            Decompte_Label.Hide();

            AfficherQuestion_Timer.Stop();
            this.AfficherReponse("0");
        }

        #endregion

        #region Méthodes auxiliaires

        // Masquage de l’interface permettant à l’utilisateur de choisir l’opération sur laquelle il veut se tester
        // Affichage de l’interface permettant à l’utilisateur de répondre à la première question
        private void ChangerInterface()
        {
            Choix_Label.Hide();
            Addition_Button.Hide();
            Soustraction_Button.Hide();
            Multiplication_Button.Hide();
            Division_Button.Hide();

            Zone_PictureBox.Show();
            Egal_Label.Show();
            Progression_Label.Show();
            Operation_Label.Show();
            Reponse_TextBox.Show();
            Valider_Button.Show();
        }

        // Affichage de la question
        private void AfficherQuestion()
        {
            Progression_Label.Text = "Question " + (this.compteurQuestion + 1) + " sur " + this.test.questions.Count;
            Operation_Label.Text = this.test.questions[this.compteurQuestion];
            Reponse_TextBox.Clear();

            // Démarrage et affichage du chronomètre en mode difficile
            if (this.test.difficulte)
            {
                this.decompte = this.test.intervalle;
                Decompte_Label.Text = this.decompte.ToString();
                Chrono_Panel.Show();
                Decompte_Label.Show();
                Decompte_Timer.Start();
                AfficherQuestion_Timer.Start();
            }
        }

        // Affichage du message disant si la réponse est correcte ou non
        private void AfficherReponse(string reponseJoueur)
        {
            List<string> erreurJoueur = this.test.VerifierReponse(reponseJoueur, this.compteurQuestion);

            // Cas où le joueur n’a pas commis d’erreur
            if (erreurJoueur.Count == 0)
            {
                TestResultat_Form resultat = new TestResultat_Form("Bravo ! Votre calcul est correct !");

                if (resultat.ShowDialog() == DialogResult.OK)
                {
                    resultat.Close();
                    this.PasserQuestionSuivante();
                }
            }

            // Cas où le joueur a fait une erreur
            else
            {
                TestResultat_Form resultat = new TestResultat_Form(this.test.AfficherErreur(erreurJoueur));

                if (resultat.ShowDialog() == DialogResult.OK)
                {
                    resultat.Close();
                    this.PasserQuestionSuivante();
                }
            }
        }

        // Gestion du passage à la question suivante ou au résultat
        private void PasserQuestionSuivante()
        {
            if (this.compteurQuestion < 9)
            {
                this.compteurQuestion++;
                this.AfficherQuestion();
            }

            else
            {
                this.AfficherResultat();
            }
        }

        // Affichage du résultat (proportion de bonnes réponses du joueur)
        private void AfficherResultat()
        {
            // Masquage de la dernière question
            Zone_PictureBox.Hide();
            Egal_Label.Hide();
            Progression_Label.Hide();
            Operation_Label.Hide();
            Reponse_TextBox.Hide();
            Valider_Button.Hide();

            Resultat_Label.Text = "Vous avez un taux de réussite de " + this.test.CalculerResultat() + " % !";
            Resultat_Label.Show();
            Terminer_Button.Show();
        }

        #endregion
    }
}
