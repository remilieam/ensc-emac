﻿namespace EMACApp
{
    partial class TestPhysique_Form
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
            this.Question_TextBox = new System.Windows.Forms.TextBox();
            this.Answer_groupeBox = new System.Windows.Forms.GroupBox();
            this.Choice2_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choice4_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choice3_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choice1_RadioButton = new System.Windows.Forms.RadioButton();
            this.Next_Button = new System.Windows.Forms.Button();
            this.Valider_Button = new System.Windows.Forms.Button();
            this.PbPhysique_pictureBox = new System.Windows.Forms.PictureBox();
            this.Answer_groupeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPhysique_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Question_TextBox
            // 
            this.Question_TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question_TextBox.Location = new System.Drawing.Point(25, 12);
            this.Question_TextBox.Multiline = true;
            this.Question_TextBox.Name = "Question_TextBox";
            this.Question_TextBox.Size = new System.Drawing.Size(681, 133);
            this.Question_TextBox.TabIndex = 0;
            // 
            // Answer_groupeBox
            // 
            this.Answer_groupeBox.Controls.Add(this.Choice4_RadioButton);
            this.Answer_groupeBox.Controls.Add(this.Choice3_RadioButton);
            this.Answer_groupeBox.Controls.Add(this.Choice1_RadioButton);
            this.Answer_groupeBox.Controls.Add(this.Choice2_RadioButton);
            this.Answer_groupeBox.Location = new System.Drawing.Point(53, 167);
            this.Answer_groupeBox.Name = "Answer_groupeBox";
            this.Answer_groupeBox.Size = new System.Drawing.Size(702, 131);
            this.Answer_groupeBox.TabIndex = 1;
            this.Answer_groupeBox.TabStop = false;
            this.Answer_groupeBox.Text = "Veuillez sélectionner votre réponse";
            // 
            // Choice2_RadioButton
            // 
            this.Choice2_RadioButton.AutoSize = true;
            this.Choice2_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice2_RadioButton.Location = new System.Drawing.Point(232, 52);
            this.Choice2_RadioButton.Name = "Choice2_RadioButton";
            this.Choice2_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choice2_RadioButton.TabIndex = 3;
            this.Choice2_RadioButton.TabStop = true;
            this.Choice2_RadioButton.Text = "Choix 2";
            this.Choice2_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choice4_RadioButton
            // 
            this.Choice4_RadioButton.AutoSize = true;
            this.Choice4_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice4_RadioButton.Location = new System.Drawing.Point(556, 52);
            this.Choice4_RadioButton.Name = "Choice4_RadioButton";
            this.Choice4_RadioButton.Size = new System.Drawing.Size(97, 26);
            this.Choice4_RadioButton.TabIndex = 7;
            this.Choice4_RadioButton.TabStop = true;
            this.Choice4_RadioButton.Text = " Choix 4";
            this.Choice4_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choice3_RadioButton
            // 
            this.Choice3_RadioButton.AutoSize = true;
            this.Choice3_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice3_RadioButton.Location = new System.Drawing.Point(397, 52);
            this.Choice3_RadioButton.Name = "Choice3_RadioButton";
            this.Choice3_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choice3_RadioButton.TabIndex = 6;
            this.Choice3_RadioButton.TabStop = true;
            this.Choice3_RadioButton.Text = "Choix 3";
            this.Choice3_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choice1_RadioButton
            // 
            this.Choice1_RadioButton.AutoSize = true;
            this.Choice1_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice1_RadioButton.Location = new System.Drawing.Point(47, 52);
            this.Choice1_RadioButton.Name = "Choice1_RadioButton";
            this.Choice1_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choice1_RadioButton.TabIndex = 5;
            this.Choice1_RadioButton.TabStop = true;
            this.Choice1_RadioButton.Text = "Choix 1";
            this.Choice1_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Next_Button
            // 
            this.Next_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Button.Location = new System.Drawing.Point(297, 344);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(220, 39);
            this.Next_Button.TabIndex = 5;
            this.Next_Button.Text = "Question suivante";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Valider_Button
            // 
            this.Valider_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider_Button.Location = new System.Drawing.Point(100, 344);
            this.Valider_Button.Name = "Valider_Button";
            this.Valider_Button.Size = new System.Drawing.Size(136, 39);
            this.Valider_Button.TabIndex = 6;
            this.Valider_Button.Text = "Valider";
            this.Valider_Button.UseVisualStyleBackColor = true;
            this.Valider_Button.Click += new System.EventHandler(this.Valider_Button_Click);
            // 
            // PbPhysique_pictureBox
            // 
            this.PbPhysique_pictureBox.Location = new System.Drawing.Point(437, 12);
            this.PbPhysique_pictureBox.Name = "PbPhysique_pictureBox";
            this.PbPhysique_pictureBox.Size = new System.Drawing.Size(404, 133);
            this.PbPhysique_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPhysique_pictureBox.TabIndex = 7;
            this.PbPhysique_pictureBox.TabStop = false;
            // 
            // TestPhysique_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 409);
            this.Controls.Add(this.PbPhysique_pictureBox);
            this.Controls.Add(this.Valider_Button);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Answer_groupeBox);
            this.Controls.Add(this.Question_TextBox);
            this.Name = "TestPhysique_Form";
            this.Text = "TestPhysique";
            this.Load += new System.EventHandler(this.TestPhysique_Load);
            this.Answer_groupeBox.ResumeLayout(false);
            this.Answer_groupeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPhysique_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Question_TextBox;
        private System.Windows.Forms.GroupBox Answer_groupeBox;
        private System.Windows.Forms.RadioButton Choice2_RadioButton;
        private System.Windows.Forms.RadioButton Choice4_RadioButton;
        private System.Windows.Forms.RadioButton Choice3_RadioButton;
        private System.Windows.Forms.RadioButton Choice1_RadioButton;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.Button Valider_Button;
        private System.Windows.Forms.PictureBox PbPhysique_pictureBox;
    }
}