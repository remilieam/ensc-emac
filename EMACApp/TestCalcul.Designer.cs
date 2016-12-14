namespace EMACApp
{
    partial class TestCalcul_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCalcul_Form));
            this.NomTest3_Label = new System.Windows.Forms.Label();
            this.Zone_PictureBox = new System.Windows.Forms.PictureBox();
            this.Valider_Button = new System.Windows.Forms.Button();
            this.Reponse_TextBox = new System.Windows.Forms.TextBox();
            this.Egal_Label = new System.Windows.Forms.Label();
            this.Addition_Button = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.Multiplication_Button = new System.Windows.Forms.Button();
            this.Soustraction_Button = new System.Windows.Forms.Button();
            this.AfficherQuestion_Timer = new System.Windows.Forms.Timer(this.components);
            this.Terminer_Button = new System.Windows.Forms.Button();
            this.Decompte_Timer = new System.Windows.Forms.Timer(this.components);
            this.Chrono_Panel = new System.Windows.Forms.Panel();
            this.Decompte_Label = new System.Windows.Forms.Label();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.Progression_Label = new System.Windows.Forms.Label();
            this.Choix_Label = new System.Windows.Forms.Label();
            this.Operation_Label = new System.Windows.Forms.Label();
            this.Resultat_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_PictureBox)).BeginInit();
            this.Chrono_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomTest3_Label
            // 
            this.NomTest3_Label.AutoSize = true;
            this.NomTest3_Label.BackColor = System.Drawing.Color.Transparent;
            this.NomTest3_Label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTest3_Label.ForeColor = System.Drawing.Color.White;
            this.NomTest3_Label.Location = new System.Drawing.Point(400, 35);
            this.NomTest3_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NomTest3_Label.Name = "NomTest3_Label";
            this.NomTest3_Label.Size = new System.Drawing.Size(228, 37);
            this.NomTest3_Label.TabIndex = 30;
            this.NomTest3_Label.Text = "Calcul mental";
            // 
            // Zone_PictureBox
            // 
            this.Zone_PictureBox.BackColor = System.Drawing.Color.White;
            this.Zone_PictureBox.Location = new System.Drawing.Point(161, 163);
            this.Zone_PictureBox.Name = "Zone_PictureBox";
            this.Zone_PictureBox.Size = new System.Drawing.Size(712, 345);
            this.Zone_PictureBox.TabIndex = 32;
            this.Zone_PictureBox.TabStop = false;
            this.Zone_PictureBox.Visible = false;
            // 
            // Valider_Button
            // 
            this.Valider_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider_Button.Location = new System.Drawing.Point(390, 425);
            this.Valider_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Valider_Button.Name = "Valider_Button";
            this.Valider_Button.Size = new System.Drawing.Size(254, 68);
            this.Valider_Button.TabIndex = 33;
            this.Valider_Button.Text = "VALIDER";
            this.Valider_Button.UseVisualStyleBackColor = true;
            this.Valider_Button.Visible = false;
            this.Valider_Button.Click += new System.EventHandler(this.Valider_Button_Click);
            // 
            // Reponse_TextBox
            // 
            this.Reponse_TextBox.BackColor = System.Drawing.Color.White;
            this.Reponse_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Reponse_TextBox.Location = new System.Drawing.Point(544, 285);
            this.Reponse_TextBox.Name = "Reponse_TextBox";
            this.Reponse_TextBox.Size = new System.Drawing.Size(115, 29);
            this.Reponse_TextBox.TabIndex = 35;
            this.Reponse_TextBox.Visible = false;
            // 
            // Egal_Label
            // 
            this.Egal_Label.AutoSize = true;
            this.Egal_Label.BackColor = System.Drawing.Color.White;
            this.Egal_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal_Label.ForeColor = System.Drawing.Color.Black;
            this.Egal_Label.Location = new System.Drawing.Point(505, 288);
            this.Egal_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Egal_Label.Name = "Egal_Label";
            this.Egal_Label.Size = new System.Drawing.Size(21, 22);
            this.Egal_Label.TabIndex = 36;
            this.Egal_Label.Text = "=";
            this.Egal_Label.Visible = false;
            // 
            // Addition_Button
            // 
            this.Addition_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition_Button.Location = new System.Drawing.Point(259, 323);
            this.Addition_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Addition_Button.Name = "Addition_Button";
            this.Addition_Button.Size = new System.Drawing.Size(68, 68);
            this.Addition_Button.TabIndex = 37;
            this.Addition_Button.Text = "+";
            this.Addition_Button.UseVisualStyleBackColor = true;
            this.Addition_Button.Click += new System.EventHandler(this.Addition_Button_Click);
            // 
            // Division_Button
            // 
            this.Division_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division_Button.Location = new System.Drawing.Point(716, 323);
            this.Division_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(68, 68);
            this.Division_Button.TabIndex = 38;
            this.Division_Button.Text = "÷";
            this.Division_Button.UseVisualStyleBackColor = true;
            this.Division_Button.Click += new System.EventHandler(this.Division_Button_Click);
            // 
            // Multiplication_Button
            // 
            this.Multiplication_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication_Button.Location = new System.Drawing.Point(560, 323);
            this.Multiplication_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Multiplication_Button.Name = "Multiplication_Button";
            this.Multiplication_Button.Size = new System.Drawing.Size(68, 68);
            this.Multiplication_Button.TabIndex = 39;
            this.Multiplication_Button.Text = "×";
            this.Multiplication_Button.UseVisualStyleBackColor = true;
            this.Multiplication_Button.Click += new System.EventHandler(this.Multiplication_Button_Click);
            // 
            // Soustraction_Button
            // 
            this.Soustraction_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soustraction_Button.Location = new System.Drawing.Point(407, 323);
            this.Soustraction_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Soustraction_Button.Name = "Soustraction_Button";
            this.Soustraction_Button.Size = new System.Drawing.Size(68, 68);
            this.Soustraction_Button.TabIndex = 40;
            this.Soustraction_Button.Text = "–";
            this.Soustraction_Button.UseVisualStyleBackColor = true;
            this.Soustraction_Button.Click += new System.EventHandler(this.Soustraction_Button_Click);
            // 
            // AfficherQuestion_Timer
            // 
            this.AfficherQuestion_Timer.Tick += new System.EventHandler(this.AfficherQuestion_Timer_Tick);
            // 
            // Terminer_Button
            // 
            this.Terminer_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminer_Button.Location = new System.Drawing.Point(390, 425);
            this.Terminer_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Terminer_Button.Name = "Terminer_Button";
            this.Terminer_Button.Size = new System.Drawing.Size(254, 68);
            this.Terminer_Button.TabIndex = 43;
            this.Terminer_Button.Text = "TERMINER";
            this.Terminer_Button.UseVisualStyleBackColor = true;
            this.Terminer_Button.Visible = false;
            this.Terminer_Button.Click += new System.EventHandler(this.Terminer_Button_Click);
            // 
            // Decompte_Timer
            // 
            this.Decompte_Timer.Interval = 1000;
            this.Decompte_Timer.Tick += new System.EventHandler(this.Decompte_Timer_Tick);
            // 
            // Chrono_Panel
            // 
            this.Chrono_Panel.BackColor = System.Drawing.Color.White;
            this.Chrono_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chrono_Panel.BackgroundImage")));
            this.Chrono_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Chrono_Panel.Controls.Add(this.Decompte_Label);
            this.Chrono_Panel.Location = new System.Drawing.Point(166, 168);
            this.Chrono_Panel.Name = "Chrono_Panel";
            this.Chrono_Panel.Size = new System.Drawing.Size(74, 77);
            this.Chrono_Panel.TabIndex = 44;
            this.Chrono_Panel.Visible = false;
            // 
            // Decompte_Label
            // 
            this.Decompte_Label.AutoSize = true;
            this.Decompte_Label.BackColor = System.Drawing.Color.White;
            this.Decompte_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decompte_Label.ForeColor = System.Drawing.Color.Red;
            this.Decompte_Label.Location = new System.Drawing.Point(28, 34);
            this.Decompte_Label.Name = "Decompte_Label";
            this.Decompte_Label.Size = new System.Drawing.Size(21, 22);
            this.Decompte_Label.TabIndex = 33;
            this.Decompte_Label.Text = "5";
            this.Decompte_Label.Visible = false;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.White;
            this.Menu_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_Panel.BackgroundImage")));
            this.Menu_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Menu_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_Panel.Location = new System.Drawing.Point(975, 483);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(70, 70);
            this.Menu_Panel.TabIndex = 45;
            this.Menu_Panel.Click += new System.EventHandler(this.Menu_Panel_Click);
            // 
            // Progression_Label
            // 
            this.Progression_Label.BackColor = System.Drawing.Color.White;
            this.Progression_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progression_Label.Location = new System.Drawing.Point(161, 99);
            this.Progression_Label.Name = "Progression_Label";
            this.Progression_Label.Size = new System.Drawing.Size(712, 29);
            this.Progression_Label.TabIndex = 46;
            this.Progression_Label.Text = "Progression";
            this.Progression_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Choix_Label
            // 
            this.Choix_Label.BackColor = System.Drawing.Color.White;
            this.Choix_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix_Label.Location = new System.Drawing.Point(162, 163);
            this.Choix_Label.Name = "Choix_Label";
            this.Choix_Label.Size = new System.Drawing.Size(712, 119);
            this.Choix_Label.TabIndex = 47;
            this.Choix_Label.Text = "Cliquez sur le bouton comportant le signe de l’opération";
            this.Choix_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Operation_Label
            // 
            this.Operation_Label.BackColor = System.Drawing.Color.White;
            this.Operation_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation_Label.Location = new System.Drawing.Point(364, 285);
            this.Operation_Label.Name = "Operation_Label";
            this.Operation_Label.Size = new System.Drawing.Size(121, 29);
            this.Operation_Label.TabIndex = 48;
            this.Operation_Label.Text = "Opération";
            this.Operation_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Operation_Label.Visible = false;
            // 
            // Resultat_Label
            // 
            this.Resultat_Label.BackColor = System.Drawing.Color.White;
            this.Resultat_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultat_Label.Location = new System.Drawing.Point(161, 224);
            this.Resultat_Label.Name = "Resultat_Label";
            this.Resultat_Label.Size = new System.Drawing.Size(712, 124);
            this.Resultat_Label.TabIndex = 49;
            this.Resultat_Label.Text = "Résultat";
            this.Resultat_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resultat_Label.Visible = false;
            // 
            // TestCalcul_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Operation_Label);
            this.Controls.Add(this.Progression_Label);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Chrono_Panel);
            this.Controls.Add(this.Egal_Label);
            this.Controls.Add(this.Terminer_Button);
            this.Controls.Add(this.Soustraction_Button);
            this.Controls.Add(this.Multiplication_Button);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Addition_Button);
            this.Controls.Add(this.Reponse_TextBox);
            this.Controls.Add(this.Valider_Button);
            this.Controls.Add(this.NomTest3_Label);
            this.Controls.Add(this.Choix_Label);
            this.Controls.Add(this.Resultat_Label);
            this.Controls.Add(this.Zone_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestCalcul_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul mental";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestCalcul_Form_FormClosing);
            this.Load += new System.EventHandler(this.TestCalcul_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zone_PictureBox)).EndInit();
            this.Chrono_Panel.ResumeLayout(false);
            this.Chrono_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomTest3_Label;
        private System.Windows.Forms.PictureBox Zone_PictureBox;
        private System.Windows.Forms.Button Valider_Button;
        private System.Windows.Forms.TextBox Reponse_TextBox;
        private System.Windows.Forms.Label Egal_Label;
        private System.Windows.Forms.Button Addition_Button;
        private System.Windows.Forms.Button Division_Button;
        private System.Windows.Forms.Button Multiplication_Button;
        private System.Windows.Forms.Button Soustraction_Button;
        private System.Windows.Forms.Timer AfficherQuestion_Timer;
        private System.Windows.Forms.Button Terminer_Button;
        private System.Windows.Forms.Timer Decompte_Timer;
        private System.Windows.Forms.Panel Chrono_Panel;
        private System.Windows.Forms.Label Decompte_Label;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Label Progression_Label;
        private System.Windows.Forms.Label Choix_Label;
        private System.Windows.Forms.Label Operation_Label;
        private System.Windows.Forms.Label Resultat_Label;
    }
}