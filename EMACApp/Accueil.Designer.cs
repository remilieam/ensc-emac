namespace EMACApp
{
    partial class Accueil_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil_Form));
            this.TitreAccueil_Label = new System.Windows.Forms.Label();
            this.ExplicationAccueil_Label = new System.Windows.Forms.Label();
            this.Continuer_Button = new System.Windows.Forms.Button();
            this.Quitter_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitreAccueil_Label
            // 
            this.TitreAccueil_Label.AutoSize = true;
            this.TitreAccueil_Label.BackColor = System.Drawing.Color.Transparent;
            this.TitreAccueil_Label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAccueil_Label.ForeColor = System.Drawing.Color.White;
            this.TitreAccueil_Label.Location = new System.Drawing.Point(254, 46);
            this.TitreAccueil_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitreAccueil_Label.Name = "TitreAccueil_Label";
            this.TitreAccueil_Label.Size = new System.Drawing.Size(557, 37);
            this.TitreAccueil_Label.TabIndex = 0;
            this.TitreAccueil_Label.Text = "Bienvenue sur l’application EMAC !";
            this.TitreAccueil_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExplicationAccueil_Label
            // 
            this.ExplicationAccueil_Label.BackColor = System.Drawing.Color.White;
            this.ExplicationAccueil_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplicationAccueil_Label.Location = new System.Drawing.Point(246, 126);
            this.ExplicationAccueil_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExplicationAccueil_Label.Name = "ExplicationAccueil_Label";
            this.ExplicationAccueil_Label.Size = new System.Drawing.Size(565, 246);
            this.ExplicationAccueil_Label.TabIndex = 1;
            this.ExplicationAccueil_Label.Text = resources.GetString("ExplicationAccueil_Label.Text");
            this.ExplicationAccueil_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Continuer_Button
            // 
            this.Continuer_Button.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuer_Button.Location = new System.Drawing.Point(562, 426);
            this.Continuer_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Continuer_Button.Name = "Continuer_Button";
            this.Continuer_Button.Size = new System.Drawing.Size(164, 43);
            this.Continuer_Button.TabIndex = 2;
            this.Continuer_Button.Text = "CONTINUER";
            this.Continuer_Button.UseVisualStyleBackColor = true;
            this.Continuer_Button.Click += new System.EventHandler(this.Continuer_Buttom_Click);
            // 
            // Quitter_Button
            // 
            this.Quitter_Button.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter_Button.Location = new System.Drawing.Point(303, 426);
            this.Quitter_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Quitter_Button.Name = "Quitter_Button";
            this.Quitter_Button.Size = new System.Drawing.Size(164, 43);
            this.Quitter_Button.TabIndex = 3;
            this.Quitter_Button.Text = "QUITTER";
            this.Quitter_Button.UseVisualStyleBackColor = true;
            this.Quitter_Button.Click += new System.EventHandler(this.Quitter_Buttom_Click);
            // 
            // Accueil_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Quitter_Button);
            this.Controls.Add(this.Continuer_Button);
            this.Controls.Add(this.ExplicationAccueil_Label);
            this.Controls.Add(this.TitreAccueil_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Accueil_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accueil_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreAccueil_Label;
        private System.Windows.Forms.Label ExplicationAccueil_Label;
        private System.Windows.Forms.Button Continuer_Button;
        private System.Windows.Forms.Button Quitter_Button;
    }
}