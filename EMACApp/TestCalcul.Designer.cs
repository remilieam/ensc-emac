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
            this.ProgressionTest3_TextBox = new System.Windows.Forms.TextBox();
            this.NomTest3_Label = new System.Windows.Forms.Label();
            this.Zone_PictureBox = new System.Windows.Forms.PictureBox();
            this.Valider_Button = new System.Windows.Forms.Button();
            this.Operation_TextBlox = new System.Windows.Forms.TextBox();
            this.Reponse_TextBox = new System.Windows.Forms.TextBox();
            this.Egal_Label = new System.Windows.Forms.Label();
            this.Addition_Button = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.Multiplication_Button = new System.Windows.Forms.Button();
            this.Soustraction_Button = new System.Windows.Forms.Button();
            this.Choix_TextBox = new System.Windows.Forms.TextBox();
            this.AfficherQuestion_Timer = new System.Windows.Forms.Timer(this.components);
            this.Terminer_Button = new System.Windows.Forms.Button();
            this.Resultat_TextBox = new System.Windows.Forms.TextBox();
            this.Decompte_Timer = new System.Windows.Forms.Timer(this.components);
            this.Chrono_Panel = new System.Windows.Forms.Panel();
            this.Decompte_Label = new System.Windows.Forms.Label();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Zone_PictureBox)).BeginInit();
            this.Chrono_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressionTest3_TextBox
            // 
            this.ProgressionTest3_TextBox.BackColor = System.Drawing.Color.White;
            this.ProgressionTest3_TextBox.Enabled = false;
            this.ProgressionTest3_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressionTest3_TextBox.ForeColor = System.Drawing.Color.Black;
            this.ProgressionTest3_TextBox.Location = new System.Drawing.Point(161, 99);
            this.ProgressionTest3_TextBox.Name = "ProgressionTest3_TextBox";
            this.ProgressionTest3_TextBox.Size = new System.Drawing.Size(712, 29);
            this.ProgressionTest3_TextBox.TabIndex = 31;
            this.ProgressionTest3_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProgressionTest3_TextBox.Visible = false;
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
            // Operation_TextBlox
            // 
            this.Operation_TextBlox.BackColor = System.Drawing.Color.White;
            this.Operation_TextBlox.Enabled = false;
            this.Operation_TextBlox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation_TextBlox.ForeColor = System.Drawing.Color.Black;
            this.Operation_TextBlox.Location = new System.Drawing.Point(276, 285);
            this.Operation_TextBlox.Name = "Operation_TextBlox";
            this.Operation_TextBlox.Size = new System.Drawing.Size(267, 29);
            this.Operation_TextBlox.TabIndex = 34;
            this.Operation_TextBlox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Operation_TextBlox.Visible = false;
            // 
            // Reponse_TextBox
            // 
            this.Reponse_TextBox.BackColor = System.Drawing.Color.White;
            this.Reponse_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Reponse_TextBox.Location = new System.Drawing.Point(602, 285);
            this.Reponse_TextBox.Name = "Reponse_TextBox";
            this.Reponse_TextBox.Size = new System.Drawing.Size(123, 29);
            this.Reponse_TextBox.TabIndex = 35;
            this.Reponse_TextBox.Visible = false;
            // 
            // Egal_Label
            // 
            this.Egal_Label.AutoSize = true;
            this.Egal_Label.BackColor = System.Drawing.Color.White;
            this.Egal_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal_Label.ForeColor = System.Drawing.Color.Black;
            this.Egal_Label.Location = new System.Drawing.Point(563, 288);
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
            // Choix_TextBox
            // 
            this.Choix_TextBox.BackColor = System.Drawing.Color.White;
            this.Choix_TextBox.Enabled = false;
            this.Choix_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Choix_TextBox.Location = new System.Drawing.Point(161, 203);
            this.Choix_TextBox.Multiline = true;
            this.Choix_TextBox.Name = "Choix_TextBox";
            this.Choix_TextBox.Size = new System.Drawing.Size(712, 52);
            this.Choix_TextBox.TabIndex = 41;
            this.Choix_TextBox.Text = "Cliquez sur le bouton comportant le signe de l’opération\r\nsur laquelle vous voule" +
    "z vous tester.";
            this.Choix_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Resultat_TextBox
            // 
            this.Resultat_TextBox.BackColor = System.Drawing.Color.White;
            this.Resultat_TextBox.Enabled = false;
            this.Resultat_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultat_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Resultat_TextBox.Location = new System.Drawing.Point(161, 244);
            this.Resultat_TextBox.Name = "Resultat_TextBox";
            this.Resultat_TextBox.Size = new System.Drawing.Size(712, 29);
            this.Resultat_TextBox.TabIndex = 42;
            this.Resultat_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resultat_TextBox.Visible = false;
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
            this.Chrono_Panel.Location = new System.Drawing.Point(161, 163);
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
            // TestCalcul_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Chrono_Panel);
            this.Controls.Add(this.Egal_Label);
            this.Controls.Add(this.Terminer_Button);
            this.Controls.Add(this.Resultat_TextBox);
            this.Controls.Add(this.Choix_TextBox);
            this.Controls.Add(this.Soustraction_Button);
            this.Controls.Add(this.Multiplication_Button);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Addition_Button);
            this.Controls.Add(this.Reponse_TextBox);
            this.Controls.Add(this.Operation_TextBlox);
            this.Controls.Add(this.Valider_Button);
            this.Controls.Add(this.ProgressionTest3_TextBox);
            this.Controls.Add(this.NomTest3_Label);
            this.Controls.Add(this.Zone_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestCalcul_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul mental";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestCalcul_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Zone_PictureBox)).EndInit();
            this.Chrono_Panel.ResumeLayout(false);
            this.Chrono_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProgressionTest3_TextBox;
        private System.Windows.Forms.Label NomTest3_Label;
        private System.Windows.Forms.PictureBox Zone_PictureBox;
        private System.Windows.Forms.Button Valider_Button;
        private System.Windows.Forms.TextBox Operation_TextBlox;
        private System.Windows.Forms.TextBox Reponse_TextBox;
        private System.Windows.Forms.Label Egal_Label;
        private System.Windows.Forms.Button Addition_Button;
        private System.Windows.Forms.Button Division_Button;
        private System.Windows.Forms.Button Multiplication_Button;
        private System.Windows.Forms.Button Soustraction_Button;
        private System.Windows.Forms.TextBox Choix_TextBox;
        private System.Windows.Forms.Timer AfficherQuestion_Timer;
        private System.Windows.Forms.Button Terminer_Button;
        private System.Windows.Forms.TextBox Resultat_TextBox;
        private System.Windows.Forms.Timer Decompte_Timer;
        private System.Windows.Forms.Panel Chrono_Panel;
        private System.Windows.Forms.Label Decompte_Label;
        private System.Windows.Forms.Panel Menu_Panel;
    }
}