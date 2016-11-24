namespace EMACApp
{
    partial class Home_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            this.TitleHome_Label = new System.Windows.Forms.Label();
            this.ExplicationHome_Label = new System.Windows.Forms.Label();
            this.ContinueHome_Button = new System.Windows.Forms.Button();
            this.ExitHome_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleHome_Label
            // 
            this.TitleHome_Label.AutoSize = true;
            this.TitleHome_Label.BackColor = System.Drawing.Color.Transparent;
            this.TitleHome_Label.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHome_Label.ForeColor = System.Drawing.Color.White;
            this.TitleHome_Label.Location = new System.Drawing.Point(526, 65);
            this.TitleHome_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleHome_Label.Name = "TitleHome_Label";
            this.TitleHome_Label.Size = new System.Drawing.Size(806, 66);
            this.TitleHome_Label.TabIndex = 0;
            this.TitleHome_Label.Text = "Bienvenue sur l’application EMAC !";
            this.TitleHome_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExplicationHome_Label
            // 
            this.ExplicationHome_Label.AutoSize = true;
            this.ExplicationHome_Label.BackColor = System.Drawing.Color.White;
            this.ExplicationHome_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplicationHome_Label.Location = new System.Drawing.Point(506, 231);
            this.ExplicationHome_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExplicationHome_Label.Name = "ExplicationHome_Label";
            this.ExplicationHome_Label.Size = new System.Drawing.Size(956, 351);
            this.ExplicationHome_Label.TabIndex = 1;
            this.ExplicationHome_Label.Text = resources.GetString("ExplicationHome_Label.Text");
            this.ExplicationHome_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExplicationHome_Label.Click += new System.EventHandler(this.ExplicationHomeLabel_Click);
            // 
            // ContinueHome_Button
            // 
            this.ContinueHome_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueHome_Button.Location = new System.Drawing.Point(1060, 655);
            this.ContinueHome_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContinueHome_Button.Name = "ContinueHome_Button";
            this.ContinueHome_Button.Size = new System.Drawing.Size(246, 76);
            this.ContinueHome_Button.TabIndex = 2;
            this.ContinueHome_Button.Text = "Continuer";
            this.ContinueHome_Button.UseVisualStyleBackColor = true;
            this.ContinueHome_Button.Click += new System.EventHandler(this.ContinueButtom_Click);
            // 
            // ExitHome_Button
            // 
            this.ExitHome_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitHome_Button.Location = new System.Drawing.Point(686, 655);
            this.ExitHome_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitHome_Button.Name = "ExitHome_Button";
            this.ExitHome_Button.Size = new System.Drawing.Size(248, 76);
            this.ExitHome_Button.TabIndex = 3;
            this.ExitHome_Button.Text = "Quitter";
            this.ExitHome_Button.UseVisualStyleBackColor = true;
            this.ExitHome_Button.Click += new System.EventHandler(this.ExitButtom_Click);
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1910, 1030);
            this.Controls.Add(this.ExitHome_Button);
            this.Controls.Add(this.ContinueHome_Button);
            this.Controls.Add(this.ExplicationHome_Label);
            this.Controls.Add(this.TitleHome_Label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home_Form";
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleHome_Label;
        private System.Windows.Forms.Label ExplicationHome_Label;
        private System.Windows.Forms.Button ContinueHome_Button;
        private System.Windows.Forms.Button ExitHome_Button;
    }
}