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
            this.ConsigneMaths_TextBox = new System.Windows.Forms.TextBox();
            this.Answer_GroupBox = new System.Windows.Forms.GroupBox();
            this.Choice4_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choice3_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choice2_RadioButton = new System.Windows.Forms.RadioButton();
            this.Choice1_RadioButton = new System.Windows.Forms.RadioButton();
            this.Valider_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.PbMaths_pictureBox = new System.Windows.Forms.PictureBox();
            this.Answer_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMaths_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsigneMaths_TextBox
            // 
            this.ConsigneMaths_TextBox.Enabled = false;
            this.ConsigneMaths_TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsigneMaths_TextBox.Location = new System.Drawing.Point(2, 12);
            this.ConsigneMaths_TextBox.Multiline = true;
            this.ConsigneMaths_TextBox.Name = "ConsigneMaths_TextBox";
            this.ConsigneMaths_TextBox.Size = new System.Drawing.Size(620, 193);
            this.ConsigneMaths_TextBox.TabIndex = 0;
            this.ConsigneMaths_TextBox.TextChanged += new System.EventHandler(this.ConsigneMaths_TxtBox_TextChanged);
            // 
            // Answer_GroupBox
            // 
            this.Answer_GroupBox.Controls.Add(this.Choice4_RadioButton);
            this.Answer_GroupBox.Controls.Add(this.Choice3_RadioButton);
            this.Answer_GroupBox.Controls.Add(this.Choice2_RadioButton);
            this.Answer_GroupBox.Controls.Add(this.Choice1_RadioButton);
            this.Answer_GroupBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_GroupBox.Location = new System.Drawing.Point(18, 211);
            this.Answer_GroupBox.Name = "Answer_GroupBox";
            this.Answer_GroupBox.Size = new System.Drawing.Size(1004, 160);
            this.Answer_GroupBox.TabIndex = 2;
            this.Answer_GroupBox.TabStop = false;
            this.Answer_GroupBox.Text = "Veuillez cocher votre réponse";
            this.Answer_GroupBox.Enter += new System.EventHandler(this.Answer_groupBox_Enter);
            // 
            // Choice4_RadioButton
            // 
            this.Choice4_RadioButton.AutoSize = true;
            this.Choice4_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice4_RadioButton.Location = new System.Drawing.Point(599, 74);
            this.Choice4_RadioButton.Name = "Choice4_RadioButton";
            this.Choice4_RadioButton.Size = new System.Drawing.Size(97, 26);
            this.Choice4_RadioButton.TabIndex = 4;
            this.Choice4_RadioButton.TabStop = true;
            this.Choice4_RadioButton.Text = " Choix 4";
            this.Choice4_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choice3_RadioButton
            // 
            this.Choice3_RadioButton.AutoSize = true;
            this.Choice3_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice3_RadioButton.Location = new System.Drawing.Point(409, 74);
            this.Choice3_RadioButton.Name = "Choice3_RadioButton";
            this.Choice3_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choice3_RadioButton.TabIndex = 3;
            this.Choice3_RadioButton.TabStop = true;
            this.Choice3_RadioButton.Text = "Choix 3";
            this.Choice3_RadioButton.UseVisualStyleBackColor = true;
            this.Choice3_RadioButton.CheckedChanged += new System.EventHandler(this.Choice3_radioBtn_CheckedChanged);
            // 
            // Choice2_RadioButton
            // 
            this.Choice2_RadioButton.AutoSize = true;
            this.Choice2_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice2_RadioButton.Location = new System.Drawing.Point(232, 74);
            this.Choice2_RadioButton.Name = "Choice2_RadioButton";
            this.Choice2_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choice2_RadioButton.TabIndex = 2;
            this.Choice2_RadioButton.TabStop = true;
            this.Choice2_RadioButton.Text = "Choix 2";
            this.Choice2_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Choice1_RadioButton
            // 
            this.Choice1_RadioButton.AutoSize = true;
            this.Choice1_RadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice1_RadioButton.Location = new System.Drawing.Point(87, 74);
            this.Choice1_RadioButton.Name = "Choice1_RadioButton";
            this.Choice1_RadioButton.Size = new System.Drawing.Size(92, 26);
            this.Choice1_RadioButton.TabIndex = 1;
            this.Choice1_RadioButton.TabStop = true;
            this.Choice1_RadioButton.Text = "Choix 1";
            this.Choice1_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Valider_Button
            // 
            this.Valider_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider_Button.Location = new System.Drawing.Point(130, 423);
            this.Valider_Button.Name = "Valider_Button";
            this.Valider_Button.Size = new System.Drawing.Size(136, 39);
            this.Valider_Button.TabIndex = 3;
            this.Valider_Button.Text = "Valider";
            this.Valider_Button.UseVisualStyleBackColor = true;
            this.Valider_Button.Click += new System.EventHandler(this.Valider_Btn_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Button.Location = new System.Drawing.Point(287, 423);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(220, 39);
            this.Next_Button.TabIndex = 4;
            this.Next_Button.Text = "Question suivante";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Btn_Click);
            // 
            // PbMaths_pictureBox
            // 
            this.PbMaths_pictureBox.Location = new System.Drawing.Point(618, 12);
            this.PbMaths_pictureBox.Name = "PbMaths_pictureBox";
            this.PbMaths_pictureBox.Size = new System.Drawing.Size(404, 193);
            this.PbMaths_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMaths_pictureBox.TabIndex = 5;
            this.PbMaths_pictureBox.TabStop = false;
            this.PbMaths_pictureBox.Click += new System.EventHandler(this.PbMaths_pictureBox_Click);
            // 
            // TestMaths_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 542);
            this.Controls.Add(this.PbMaths_pictureBox);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Valider_Button);
            this.Controls.Add(this.Answer_GroupBox);
            this.Controls.Add(this.ConsigneMaths_TextBox);
            this.Name = "TestMaths_Form";
            this.Text = "TestMaths";
            this.Load += new System.EventHandler(this.TestMaths_Form_Load);
            this.Answer_GroupBox.ResumeLayout(false);
            this.Answer_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMaths_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsigneMaths_TextBox;
        private System.Windows.Forms.GroupBox Answer_GroupBox;
        private System.Windows.Forms.RadioButton Choice4_RadioButton;
        private System.Windows.Forms.RadioButton Choice3_RadioButton;
        private System.Windows.Forms.RadioButton Choice2_RadioButton;
        private System.Windows.Forms.RadioButton Choice1_RadioButton;
        private System.Windows.Forms.Button Valider_Button;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.PictureBox PbMaths_pictureBox;
    }
}