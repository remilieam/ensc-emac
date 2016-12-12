namespace EMACApp
{
    partial class TestDemonstration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDemonstration_Form));
            this.NomTest_Label = new System.Windows.Forms.Label();
            this.Instruction_TextBox = new System.Windows.Forms.TextBox();
            this.TexteDemo_TextBox = new System.Windows.Forms.TextBox();
            this.ImageDemo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Jouer_Button = new System.Windows.Forms.Button();
            this.Suivant_PictureBox = new System.Windows.Forms.PictureBox();
            this.Precedent_PictureBox = new System.Windows.Forms.PictureBox();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDemo_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suivant_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precedent_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NomTest_Label
            // 
            this.NomTest_Label.AutoSize = true;
            this.NomTest_Label.BackColor = System.Drawing.Color.Transparent;
            this.NomTest_Label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTest_Label.ForeColor = System.Drawing.Color.White;
            this.NomTest_Label.Location = new System.Drawing.Point(239, 26);
            this.NomTest_Label.Name = "NomTest_Label";
            this.NomTest_Label.Size = new System.Drawing.Size(0, 37);
            this.NomTest_Label.TabIndex = 0;
            // 
            // Instruction_TextBox
            // 
            this.Instruction_TextBox.Enabled = false;
            this.Instruction_TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction_TextBox.Location = new System.Drawing.Point(52, 89);
            this.Instruction_TextBox.Multiline = true;
            this.Instruction_TextBox.Name = "Instruction_TextBox";
            this.Instruction_TextBox.Size = new System.Drawing.Size(926, 378);
            this.Instruction_TextBox.TabIndex = 1;
            // 
            // TexteDemo_TextBox
            // 
            this.TexteDemo_TextBox.Enabled = false;
            this.TexteDemo_TextBox.Location = new System.Drawing.Point(52, 51);
            this.TexteDemo_TextBox.Multiline = true;
            this.TexteDemo_TextBox.Name = "TexteDemo_TextBox";
            this.TexteDemo_TextBox.Size = new System.Drawing.Size(926, 62);
            this.TexteDemo_TextBox.TabIndex = 2;
            this.TexteDemo_TextBox.Visible = false;
            // 
            // ImageDemo_PictureBox
            // 
            this.ImageDemo_PictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImageDemo_PictureBox.Location = new System.Drawing.Point(52, 89);
            this.ImageDemo_PictureBox.Name = "ImageDemo_PictureBox";
            this.ImageDemo_PictureBox.Size = new System.Drawing.Size(926, 378);
            this.ImageDemo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageDemo_PictureBox.TabIndex = 3;
            this.ImageDemo_PictureBox.TabStop = false;
            this.ImageDemo_PictureBox.Visible = false;
            // 
            // Jouer_Button
            // 
            this.Jouer_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jouer_Button.Location = new System.Drawing.Point(470, 481);
            this.Jouer_Button.Name = "Jouer_Button";
            this.Jouer_Button.Size = new System.Drawing.Size(95, 37);
            this.Jouer_Button.TabIndex = 4;
            this.Jouer_Button.Text = "JOUER";
            this.Jouer_Button.UseVisualStyleBackColor = true;
            this.Jouer_Button.Click += new System.EventHandler(this.Jouer_Button_Click);
            // 
            // Suivant_PictureBox
            // 
            this.Suivant_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Suivant_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Suivant_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suivant_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Suivant_PictureBox.Image")));
            this.Suivant_PictureBox.Location = new System.Drawing.Point(996, 234);
            this.Suivant_PictureBox.Name = "Suivant_PictureBox";
            this.Suivant_PictureBox.Size = new System.Drawing.Size(30, 59);
            this.Suivant_PictureBox.TabIndex = 5;
            this.Suivant_PictureBox.TabStop = false;
            this.Suivant_PictureBox.Click += new System.EventHandler(this.Suivant_PictureBox_Click);
            // 
            // Precedent_PictureBox
            // 
            this.Precedent_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Precedent_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Precedent_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Precedent_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Precedent_PictureBox.Image")));
            this.Precedent_PictureBox.Location = new System.Drawing.Point(8, 234);
            this.Precedent_PictureBox.Name = "Precedent_PictureBox";
            this.Precedent_PictureBox.Size = new System.Drawing.Size(32, 59);
            this.Precedent_PictureBox.TabIndex = 6;
            this.Precedent_PictureBox.TabStop = false;
            this.Precedent_PictureBox.Click += new System.EventHandler(this.Precedent_PictureBox_Click);
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
            this.Menu_Panel.TabIndex = 38;
            this.Menu_Panel.Click += new System.EventHandler(this.Menu_Panel_Click);
            // 
            // TestDemonstration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Instruction_TextBox);
            this.Controls.Add(this.Precedent_PictureBox);
            this.Controls.Add(this.Suivant_PictureBox);
            this.Controls.Add(this.Jouer_Button);
            this.Controls.Add(this.TexteDemo_TextBox);
            this.Controls.Add(this.NomTest_Label);
            this.Controls.Add(this.ImageDemo_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TestDemonstration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consigne et démonstration du test";
            this.Load += new System.EventHandler(this.TestPerception_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageDemo_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suivant_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precedent_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomTest_Label;
        private System.Windows.Forms.TextBox Instruction_TextBox;
        private System.Windows.Forms.TextBox TexteDemo_TextBox;
        private System.Windows.Forms.PictureBox ImageDemo_PictureBox;
        private System.Windows.Forms.Button Jouer_Button;
        private System.Windows.Forms.PictureBox Suivant_PictureBox;
        private System.Windows.Forms.PictureBox Precedent_PictureBox;
        private System.Windows.Forms.Panel Menu_Panel;

    }
}