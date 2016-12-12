namespace EMACApp
{
    partial class TestAttention_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestAttention_Form));
            this.NomTest2_Label = new System.Windows.Forms.Label();
            this.AfficherQuestion_Timer = new System.Windows.Forms.Timer(this.components);
            this.ProgressionTest2_TextBox = new System.Windows.Forms.TextBox();
            this.Zone_PictureBox = new System.Windows.Forms.PictureBox();
            this.Terminer_Button = new System.Windows.Forms.Button();
            this.Resultat_TextBox = new System.Windows.Forms.TextBox();
            this.Bouton3_Button = new System.Windows.Forms.Button();
            this.Bouton2_Button = new System.Windows.Forms.Button();
            this.Bouton1_Button = new System.Windows.Forms.Button();
            this.Objet_PictureBox = new System.Windows.Forms.PictureBox();
            this.Regle_TextBox = new System.Windows.Forms.TextBox();
            this.Suivant_Button = new System.Windows.Forms.Button();
            this.Decompte_Label = new System.Windows.Forms.Label();
            this.Chrono_Panel = new System.Windows.Forms.Panel();
            this.Decompte_Timer = new System.Windows.Forms.Timer(this.components);
            this.AfficherPopUp_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Zone_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Objet_PictureBox)).BeginInit();
            this.Chrono_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomTest2_Label
            // 
            this.NomTest2_Label.AutoSize = true;
            this.NomTest2_Label.BackColor = System.Drawing.Color.Transparent;
            this.NomTest2_Label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTest2_Label.ForeColor = System.Drawing.Color.White;
            this.NomTest2_Label.Location = new System.Drawing.Point(312, 23);
            this.NomTest2_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NomTest2_Label.Name = "NomTest2_Label";
            this.NomTest2_Label.Size = new System.Drawing.Size(417, 37);
            this.NomTest2_Label.TabIndex = 2;
            this.NomTest2_Label.Text = "Attention et concentration";
            // 
            // AfficherQuestion_Timer
            // 
            this.AfficherQuestion_Timer.Tick += new System.EventHandler(this.AfficherQuestion_Timer_Tick);
            // 
            // ProgressionTest2_TextBox
            // 
            this.ProgressionTest2_TextBox.BackColor = System.Drawing.Color.White;
            this.ProgressionTest2_TextBox.Enabled = false;
            this.ProgressionTest2_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressionTest2_TextBox.ForeColor = System.Drawing.Color.Black;
            this.ProgressionTest2_TextBox.Location = new System.Drawing.Point(162, 81);
            this.ProgressionTest2_TextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProgressionTest2_TextBox.Name = "ProgressionTest2_TextBox";
            this.ProgressionTest2_TextBox.Size = new System.Drawing.Size(712, 29);
            this.ProgressionTest2_TextBox.TabIndex = 20;
            this.ProgressionTest2_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Zone_PictureBox
            // 
            this.Zone_PictureBox.BackColor = System.Drawing.Color.White;
            this.Zone_PictureBox.Location = new System.Drawing.Point(162, 143);
            this.Zone_PictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Zone_PictureBox.Name = "Zone_PictureBox";
            this.Zone_PictureBox.Size = new System.Drawing.Size(710, 322);
            this.Zone_PictureBox.TabIndex = 29;
            this.Zone_PictureBox.TabStop = false;
            this.Zone_PictureBox.Visible = false;
            // 
            // Terminer_Button
            // 
            this.Terminer_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminer_Button.Location = new System.Drawing.Point(402, 377);
            this.Terminer_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Terminer_Button.Name = "Terminer_Button";
            this.Terminer_Button.Size = new System.Drawing.Size(254, 65);
            this.Terminer_Button.TabIndex = 28;
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
            this.Resultat_TextBox.Location = new System.Drawing.Point(162, 234);
            this.Resultat_TextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Resultat_TextBox.Name = "Resultat_TextBox";
            this.Resultat_TextBox.Size = new System.Drawing.Size(712, 29);
            this.Resultat_TextBox.TabIndex = 22;
            this.Resultat_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resultat_TextBox.Visible = false;
            // 
            // Bouton3_Button
            // 
            this.Bouton3_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouton3_Button.Location = new System.Drawing.Point(553, 374);
            this.Bouton3_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Bouton3_Button.Name = "Bouton3_Button";
            this.Bouton3_Button.Size = new System.Drawing.Size(254, 65);
            this.Bouton3_Button.TabIndex = 27;
            this.Bouton3_Button.Text = "BOUTON 3";
            this.Bouton3_Button.UseVisualStyleBackColor = true;
            this.Bouton3_Button.Visible = false;
            this.Bouton3_Button.Click += new System.EventHandler(this.Bouton3_Button_Click);
            // 
            // Bouton2_Button
            // 
            this.Bouton2_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouton2_Button.Location = new System.Drawing.Point(553, 272);
            this.Bouton2_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Bouton2_Button.Name = "Bouton2_Button";
            this.Bouton2_Button.Size = new System.Drawing.Size(254, 65);
            this.Bouton2_Button.TabIndex = 26;
            this.Bouton2_Button.Text = "BOUTON 2";
            this.Bouton2_Button.UseVisualStyleBackColor = true;
            this.Bouton2_Button.Visible = false;
            this.Bouton2_Button.Click += new System.EventHandler(this.Bouton2_Button_Click);
            // 
            // Bouton1_Button
            // 
            this.Bouton1_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouton1_Button.Location = new System.Drawing.Point(553, 159);
            this.Bouton1_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Bouton1_Button.Name = "Bouton1_Button";
            this.Bouton1_Button.Size = new System.Drawing.Size(254, 65);
            this.Bouton1_Button.TabIndex = 24;
            this.Bouton1_Button.Text = "BOUTON 1";
            this.Bouton1_Button.UseVisualStyleBackColor = true;
            this.Bouton1_Button.Visible = false;
            this.Bouton1_Button.Click += new System.EventHandler(this.Bouton1_Button_Click);
            // 
            // Objet_PictureBox
            // 
            this.Objet_PictureBox.BackColor = System.Drawing.Color.White;
            this.Objet_PictureBox.Location = new System.Drawing.Point(241, 159);
            this.Objet_PictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Objet_PictureBox.Name = "Objet_PictureBox";
            this.Objet_PictureBox.Size = new System.Drawing.Size(251, 280);
            this.Objet_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Objet_PictureBox.TabIndex = 21;
            this.Objet_PictureBox.TabStop = false;
            this.Objet_PictureBox.Visible = false;
            // 
            // Regle_TextBox
            // 
            this.Regle_TextBox.BackColor = System.Drawing.Color.White;
            this.Regle_TextBox.Enabled = false;
            this.Regle_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regle_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Regle_TextBox.Location = new System.Drawing.Point(162, 192);
            this.Regle_TextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Regle_TextBox.Multiline = true;
            this.Regle_TextBox.Name = "Regle_TextBox";
            this.Regle_TextBox.Size = new System.Drawing.Size(712, 121);
            this.Regle_TextBox.TabIndex = 23;
            this.Regle_TextBox.Text = "x\r\n\r\nx\r\nx\r\nx";
            this.Regle_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Suivant_Button
            // 
            this.Suivant_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suivant_Button.Location = new System.Drawing.Point(402, 377);
            this.Suivant_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Suivant_Button.Name = "Suivant_Button";
            this.Suivant_Button.Size = new System.Drawing.Size(254, 65);
            this.Suivant_Button.TabIndex = 25;
            this.Suivant_Button.Text = "SUIVANT";
            this.Suivant_Button.UseVisualStyleBackColor = true;
            this.Suivant_Button.Click += new System.EventHandler(this.Suivant_Button_Click);
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
            // Chrono_Panel
            // 
            this.Chrono_Panel.BackColor = System.Drawing.Color.White;
            this.Chrono_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chrono_Panel.BackgroundImage")));
            this.Chrono_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Chrono_Panel.Controls.Add(this.Decompte_Label);
            this.Chrono_Panel.Location = new System.Drawing.Point(162, 143);
            this.Chrono_Panel.Name = "Chrono_Panel";
            this.Chrono_Panel.Size = new System.Drawing.Size(74, 77);
            this.Chrono_Panel.TabIndex = 36;
            this.Chrono_Panel.Visible = false;
            // 
            // Decompte_Timer
            // 
            this.Decompte_Timer.Interval = 1000;
            this.Decompte_Timer.Tick += new System.EventHandler(this.Decompte_Timer_Tick);
            // 
            // AfficherPopUp_Timer
            // 
            this.AfficherPopUp_Timer.Interval = 3000;
            // 
            // TestAttention_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Chrono_Panel);
            this.Controls.Add(this.Objet_PictureBox);
            this.Controls.Add(this.Terminer_Button);
            this.Controls.Add(this.Resultat_TextBox);
            this.Controls.Add(this.Bouton3_Button);
            this.Controls.Add(this.Bouton2_Button);
            this.Controls.Add(this.Bouton1_Button);
            this.Controls.Add(this.Regle_TextBox);
            this.Controls.Add(this.Suivant_Button);
            this.Controls.Add(this.ProgressionTest2_TextBox);
            this.Controls.Add(this.NomTest2_Label);
            this.Controls.Add(this.Zone_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "TestAttention_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attention et concentration";
            this.Load += new System.EventHandler(this.TestAttention_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zone_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Objet_PictureBox)).EndInit();
            this.Chrono_Panel.ResumeLayout(false);
            this.Chrono_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomTest2_Label;
        private System.Windows.Forms.Timer AfficherQuestion_Timer;
        private System.Windows.Forms.TextBox ProgressionTest2_TextBox;
        private System.Windows.Forms.PictureBox Zone_PictureBox;
        private System.Windows.Forms.Button Terminer_Button;
        private System.Windows.Forms.TextBox Resultat_TextBox;
        private System.Windows.Forms.Button Bouton3_Button;
        private System.Windows.Forms.Button Bouton2_Button;
        private System.Windows.Forms.Button Bouton1_Button;
        private System.Windows.Forms.PictureBox Objet_PictureBox;
        private System.Windows.Forms.TextBox Regle_TextBox;
        private System.Windows.Forms.Button Suivant_Button;
        private System.Windows.Forms.Label Decompte_Label;
        private System.Windows.Forms.Panel Chrono_Panel;
        private System.Windows.Forms.Timer Decompte_Timer;
        private System.Windows.Forms.Timer AfficherPopUp_Timer;
    }
}