namespace EMACApp
{
    partial class TestMaths_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMaths_Form));
            this.Valider_Button = new System.Windows.Forms.Button();
            this.Suivant_Button = new System.Windows.Forms.Button();
            this.PbMaths_PictureBox = new System.Windows.Forms.PictureBox();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.QuestionMaths_Label = new System.Windows.Forms.Label();
            this.NomTest4_Label = new System.Windows.Forms.Label();
            this.Fond_Panel = new System.Windows.Forms.Panel();
            this.Terminer_Button = new System.Windows.Forms.Button();
            this.Reponse_GroupBox = new System.Windows.Forms.GroupBox();
            this.Choix4_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choix3_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choix2_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choix1_RadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PbMaths_PictureBox)).BeginInit();
            this.Fond_Panel.SuspendLayout();
            this.Reponse_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Valider_Button
            // 
            this.Valider_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider_Button.Location = new System.Drawing.Point(200, 374);
            this.Valider_Button.Name = "Valider_Button";
            this.Valider_Button.Size = new System.Drawing.Size(136, 39);
            this.Valider_Button.TabIndex = 3;
            this.Valider_Button.Text = "Valider";
            this.Valider_Button.UseVisualStyleBackColor = true;
            this.Valider_Button.Click += new System.EventHandler(this.Valider_Button_Click);
            // 
            // Suivant_Button
            // 
            this.Suivant_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suivant_Button.Location = new System.Drawing.Point(438, 374);
            this.Suivant_Button.Name = "Suivant_Button";
            this.Suivant_Button.Size = new System.Drawing.Size(220, 39);
            this.Suivant_Button.TabIndex = 4;
            this.Suivant_Button.Text = "Question suivante";
            this.Suivant_Button.UseVisualStyleBackColor = true;
            this.Suivant_Button.Click += new System.EventHandler(this.Suivant_Button_Click);
            // 
            // PbMaths_PictureBox
            // 
            this.PbMaths_PictureBox.BackColor = System.Drawing.Color.White;
            this.PbMaths_PictureBox.Location = new System.Drawing.Point(630, 92);
            this.PbMaths_PictureBox.Name = "PbMaths_PictureBox";
            this.PbMaths_PictureBox.Size = new System.Drawing.Size(318, 228);
            this.PbMaths_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMaths_PictureBox.TabIndex = 5;
            this.PbMaths_PictureBox.TabStop = false;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.White;
            this.Menu_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_Panel.BackgroundImage")));
            this.Menu_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Menu_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_Panel.Location = new System.Drawing.Point(971, 479);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(70, 70);
            this.Menu_Panel.TabIndex = 45;
            this.Menu_Panel.Click += new System.EventHandler(this.Menu_Panel_Click);
            // 
            // QuestionMaths_Label
            // 
            this.QuestionMaths_Label.BackColor = System.Drawing.Color.White;
            this.QuestionMaths_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionMaths_Label.ForeColor = System.Drawing.Color.Black;
            this.QuestionMaths_Label.Location = new System.Drawing.Point(93, 92);
            this.QuestionMaths_Label.Name = "QuestionMaths_Label";
            this.QuestionMaths_Label.Size = new System.Drawing.Size(539, 231);
            this.QuestionMaths_Label.TabIndex = 46;
            this.QuestionMaths_Label.Text = "Blabla";
            this.QuestionMaths_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NomTest4_Label
            // 
            this.NomTest4_Label.AutoSize = true;
            this.NomTest4_Label.BackColor = System.Drawing.Color.Transparent;
            this.NomTest4_Label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTest4_Label.ForeColor = System.Drawing.Color.White;
            this.NomTest4_Label.Location = new System.Drawing.Point(310, 25);
            this.NomTest4_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NomTest4_Label.Name = "NomTest4_Label";
            this.NomTest4_Label.Size = new System.Drawing.Size(424, 37);
            this.NomTest4_Label.TabIndex = 49;
            this.NomTest4_Label.Text = "Problèmes mathématiques";
            // 
            // Fond_Panel
            // 
            this.Fond_Panel.BackColor = System.Drawing.Color.White;
            this.Fond_Panel.Controls.Add(this.Valider_Button);
            this.Fond_Panel.Controls.Add(this.Suivant_Button);
            this.Fond_Panel.Location = new System.Drawing.Point(93, 89);
            this.Fond_Panel.Name = "Fond_Panel";
            this.Fond_Panel.Size = new System.Drawing.Size(859, 439);
            this.Fond_Panel.TabIndex = 52;
            // 
            // Terminer_Button
            // 
            this.Terminer_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminer_Button.Location = new System.Drawing.Point(395, 448);
            this.Terminer_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Terminer_Button.Name = "Terminer_Button";
            this.Terminer_Button.Size = new System.Drawing.Size(254, 68);
            this.Terminer_Button.TabIndex = 53;
            this.Terminer_Button.Text = "TERMINER";
            this.Terminer_Button.UseVisualStyleBackColor = true;
            this.Terminer_Button.Visible = false;
            this.Terminer_Button.Click += new System.EventHandler(this.Terminer_Button_Click);
            // 
            // Reponse_GroupBox
            // 
            this.Reponse_GroupBox.BackColor = System.Drawing.Color.White;
            this.Reponse_GroupBox.Controls.Add(this.Choix4_RadioButton);
            this.Reponse_GroupBox.Controls.Add(this.Choix3_RadioButton);
            this.Reponse_GroupBox.Controls.Add(this.Choix2_RadioButton);
            this.Reponse_GroupBox.Controls.Add(this.Choix1_RadioButton);
            this.Reponse_GroupBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse_GroupBox.Location = new System.Drawing.Point(293, 326);
            this.Reponse_GroupBox.Name = "Reponse_GroupBox";
            this.Reponse_GroupBox.Size = new System.Drawing.Size(458, 106);
            this.Reponse_GroupBox.TabIndex = 54;
            this.Reponse_GroupBox.TabStop = false;
            this.Reponse_GroupBox.Text = "Veuillez cocher votre réponse";
            // 
            // Choix4_RadioButton
            // 
            this.Choix4_RadioButton.AutoSize = true;
            this.Choix4_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix4_RadioButton.Location = new System.Drawing.Point(340, 52);
            this.Choix4_RadioButton.Name = "Choix4_RadioButton";
            this.Choix4_RadioButton.Size = new System.Drawing.Size(97, 26);
            this.Choix4_RadioButton.TabIndex = 4;
            this.Choix4_RadioButton.TabStop = true;
            this.Choix4_RadioButton.Text = " Choix 4";
            this.Choix4_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choix3_RadioButton
            // 
            this.Choix3_RadioButton.AutoSize = true;
            this.Choix3_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix3_RadioButton.Location = new System.Drawing.Point(232, 52);
            this.Choix3_RadioButton.Name = "Choix3_RadioButton";
            this.Choix3_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choix3_RadioButton.TabIndex = 3;
            this.Choix3_RadioButton.TabStop = true;
            this.Choix3_RadioButton.Text = "Choix 3";
            this.Choix3_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choix2_RadioButton
            // 
            this.Choix2_RadioButton.AutoSize = true;
            this.Choix2_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix2_RadioButton.Location = new System.Drawing.Point(124, 52);
            this.Choix2_RadioButton.Name = "Choix2_RadioButton";
            this.Choix2_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choix2_RadioButton.TabIndex = 2;
            this.Choix2_RadioButton.TabStop = true;
            this.Choix2_RadioButton.Text = "Choix 2";
            this.Choix2_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choix1_RadioButton
            // 
            this.Choix1_RadioButton.AutoSize = true;
            this.Choix1_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix1_RadioButton.Location = new System.Drawing.Point(16, 52);
            this.Choix1_RadioButton.Name = "Choix1_RadioButton";
            this.Choix1_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choix1_RadioButton.TabIndex = 1;
            this.Choix1_RadioButton.TabStop = true;
            this.Choix1_RadioButton.Text = "Choix 1";
            this.Choix1_RadioButton.UseVisualStyleBackColor = true;
            // 
            // TestMaths_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Reponse_GroupBox);
            this.Controls.Add(this.NomTest4_Label);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.PbMaths_PictureBox);
            this.Controls.Add(this.QuestionMaths_Label);
            this.Controls.Add(this.Terminer_Button);
            this.Controls.Add(this.Fond_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestMaths_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problèmes mathématiques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestMaths_Form_FormClosing);
            this.Load += new System.EventHandler(this.TestMaths_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbMaths_PictureBox)).EndInit();
            this.Fond_Panel.ResumeLayout(false);
            this.Reponse_GroupBox.ResumeLayout(false);
            this.Reponse_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Valider_Button;
        private System.Windows.Forms.Button Suivant_Button;
        private System.Windows.Forms.PictureBox PbMaths_PictureBox;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Label QuestionMaths_Label;
        private System.Windows.Forms.Label NomTest4_Label;
        private System.Windows.Forms.Panel Fond_Panel;
        private System.Windows.Forms.Button Terminer_Button;
        private System.Windows.Forms.GroupBox Reponse_GroupBox;
        private System.Windows.Forms.RadioButton Choix4_RadioButton;
        private System.Windows.Forms.RadioButton Choix3_RadioButton;
        private System.Windows.Forms.RadioButton Choix2_RadioButton;
        private System.Windows.Forms.RadioButton Choix1_RadioButton;
    }
}