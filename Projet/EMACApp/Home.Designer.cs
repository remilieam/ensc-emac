namespace EMACApp
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.TitleHomeLabel = new System.Windows.Forms.Label();
            this.ExplicationHomeLabel = new System.Windows.Forms.Label();
            this.ContinueHomeButtom = new System.Windows.Forms.Button();
            this.ExitHomeButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleHomeLabel
            // 
            this.TitleHomeLabel.AutoSize = true;
            this.TitleHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHomeLabel.Location = new System.Drawing.Point(44, 12);
            this.TitleHomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleHomeLabel.Name = "TitleHomeLabel";
            this.TitleHomeLabel.Size = new System.Drawing.Size(386, 29);
            this.TitleHomeLabel.TabIndex = 0;
            this.TitleHomeLabel.Text = "Bienvenue sur l’application EMAC !";
            this.TitleHomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExplicationHomeLabel
            // 
            this.ExplicationHomeLabel.AutoSize = true;
            this.ExplicationHomeLabel.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplicationHomeLabel.Location = new System.Drawing.Point(26, 72);
            this.ExplicationHomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExplicationHomeLabel.Name = "ExplicationHomeLabel";
            this.ExplicationHomeLabel.Size = new System.Drawing.Size(403, 119);
            this.ExplicationHomeLabel.TabIndex = 1;
            this.ExplicationHomeLabel.Text = resources.GetString("ExplicationHomeLabel.Text");
            this.ExplicationHomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContinueHomeButtom
            // 
            this.ContinueHomeButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueHomeButtom.Location = new System.Drawing.Point(278, 216);
            this.ContinueHomeButtom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContinueHomeButtom.Name = "ContinueHomeButtom";
            this.ContinueHomeButtom.Size = new System.Drawing.Size(89, 28);
            this.ContinueHomeButtom.TabIndex = 2;
            this.ContinueHomeButtom.Text = "Continuer";
            this.ContinueHomeButtom.UseVisualStyleBackColor = true;
            this.ContinueHomeButtom.Click += new System.EventHandler(this.ContinueButtom_Click);
            // 
            // ExitHomeButtom
            // 
            this.ExitHomeButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitHomeButtom.Location = new System.Drawing.Point(94, 216);
            this.ExitHomeButtom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitHomeButtom.Name = "ExitHomeButtom";
            this.ExitHomeButtom.Size = new System.Drawing.Size(89, 28);
            this.ExitHomeButtom.TabIndex = 3;
            this.ExitHomeButtom.Text = "Quitter";
            this.ExitHomeButtom.UseVisualStyleBackColor = true;
            this.ExitHomeButtom.Click += new System.EventHandler(this.ExitButtom_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 271);
            this.Controls.Add(this.ExitHomeButtom);
            this.Controls.Add(this.ContinueHomeButtom);
            this.Controls.Add(this.ExplicationHomeLabel);
            this.Controls.Add(this.TitleHomeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleHomeLabel;
        private System.Windows.Forms.Label ExplicationHomeLabel;
        private System.Windows.Forms.Button ContinueHomeButtom;
        private System.Windows.Forms.Button ExitHomeButtom;
    }
}