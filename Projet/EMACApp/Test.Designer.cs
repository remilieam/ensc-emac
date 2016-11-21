namespace EMACApp
{
    partial class TestForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestButton = new System.Windows.Forms.Button();
            this.TestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(364, 298);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 38);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Voir";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // TestTextBox
            // 
            this.TestTextBox.Location = new System.Drawing.Point(12, 12);
            this.TestTextBox.Multiline = true;
            this.TestTextBox.Name = "TestTextBox";
            this.TestTextBox.Size = new System.Drawing.Size(781, 267);
            this.TestTextBox.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 348);
            this.Controls.Add(this.TestTextBox);
            this.Controls.Add(this.TestButton);
            this.Name = "TestForm";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TextBox TestTextBox;
    }
}

