namespace EMACApp
{
    partial class TestResultat_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestResultat_Form));
            this.Resultat_Label = new System.Windows.Forms.Label();
            this.Fond_Panel = new System.Windows.Forms.Panel();
            this.Info_PictureBox = new System.Windows.Forms.PictureBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.AfficherPopUp_Timer = new System.Windows.Forms.Timer(this.components);
            this.Fond_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Resultat_Label
            // 
            this.Resultat_Label.BackColor = System.Drawing.Color.Transparent;
            this.Resultat_Label.Location = new System.Drawing.Point(72, 13);
            this.Resultat_Label.Name = "Resultat_Label";
            this.Resultat_Label.Size = new System.Drawing.Size(214, 60);
            this.Resultat_Label.TabIndex = 0;
            this.Resultat_Label.Text = "Bonjour !";
            this.Resultat_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Fond_Panel
            // 
            this.Fond_Panel.BackColor = System.Drawing.Color.White;
            this.Fond_Panel.Controls.Add(this.Info_PictureBox);
            this.Fond_Panel.Controls.Add(this.Resultat_Label);
            this.Fond_Panel.Location = new System.Drawing.Point(-1, -1);
            this.Fond_Panel.Name = "Fond_Panel";
            this.Fond_Panel.Size = new System.Drawing.Size(296, 94);
            this.Fond_Panel.TabIndex = 1;
            // 
            // Info_PictureBox
            // 
            this.Info_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Info_PictureBox.Image")));
            this.Info_PictureBox.Location = new System.Drawing.Point(13, 13);
            this.Info_PictureBox.Name = "Info_PictureBox";
            this.Info_PictureBox.Size = new System.Drawing.Size(60, 60);
            this.Info_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Info_PictureBox.TabIndex = 1;
            this.Info_PictureBox.TabStop = false;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(207, 99);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // AfficherPopUp_Timer
            // 
            this.AfficherPopUp_Timer.Interval = 3000;
            this.AfficherPopUp_Timer.Tick += new System.EventHandler(this.AfficherPopUp_Timer_Tick);
            // 
            // TestResultat_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 132);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Fond_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestResultat_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Résultat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestResultat_Form_FormClosing);
            this.Load += new System.EventHandler(this.TestResultat_Form_Load);
            this.Fond_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Info_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Resultat_Label;
        private System.Windows.Forms.Panel Fond_Panel;
        private System.Windows.Forms.PictureBox Info_PictureBox;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Timer AfficherPopUp_Timer;
    }
}