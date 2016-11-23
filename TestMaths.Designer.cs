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
            this.ConsigneMaths_TxtBox = new System.Windows.Forms.TextBox();
            this.Begin_Btn = new System.Windows.Forms.Button();
            this.Answer_groupBox = new System.Windows.Forms.GroupBox();
            this.Choice4_radioBtn = new System.Windows.Forms.RadioButton();
            this.Choice3_radioBtn = new System.Windows.Forms.RadioButton();
            this.Choice2_radioBtn = new System.Windows.Forms.RadioButton();
            this.Choice1_radioBtn = new System.Windows.Forms.RadioButton();
            this.Valider_Btn = new System.Windows.Forms.Button();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.Answer_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsigneMaths_TxtBox
            // 
            this.ConsigneMaths_TxtBox.Location = new System.Drawing.Point(17, 12);
            this.ConsigneMaths_TxtBox.Multiline = true;
            this.ConsigneMaths_TxtBox.Name = "ConsigneMaths_TxtBox";
            this.ConsigneMaths_TxtBox.Size = new System.Drawing.Size(538, 117);
            this.ConsigneMaths_TxtBox.TabIndex = 0;
            this.ConsigneMaths_TxtBox.TextChanged += new System.EventHandler(this.ConsigneMaths_TxtBox_TextChanged);
            // 
            // Begin_Btn
            // 
            this.Begin_Btn.Location = new System.Drawing.Point(475, 286);
            this.Begin_Btn.Name = "Begin_Btn";
            this.Begin_Btn.Size = new System.Drawing.Size(75, 23);
            this.Begin_Btn.TabIndex = 1;
            this.Begin_Btn.Text = "Commencer";
            this.Begin_Btn.UseVisualStyleBackColor = true;
            this.Begin_Btn.Click += new System.EventHandler(this.Begin_Btn_Click);
            // 
            // Answer_groupBox
            // 
            this.Answer_groupBox.Controls.Add(this.Choice4_radioBtn);
            this.Answer_groupBox.Controls.Add(this.Choice3_radioBtn);
            this.Answer_groupBox.Controls.Add(this.Choice2_radioBtn);
            this.Answer_groupBox.Controls.Add(this.Choice1_radioBtn);
            this.Answer_groupBox.Location = new System.Drawing.Point(32, 143);
            this.Answer_groupBox.Name = "Answer_groupBox";
            this.Answer_groupBox.Size = new System.Drawing.Size(502, 137);
            this.Answer_groupBox.TabIndex = 2;
            this.Answer_groupBox.TabStop = false;
            this.Answer_groupBox.Text = "Veuillez cocher votre réponse";
            this.Answer_groupBox.Enter += new System.EventHandler(this.Answer_groupBox_Enter);
            // 
            // Choice4_radioBtn
            // 
            this.Choice4_radioBtn.AutoSize = true;
            this.Choice4_radioBtn.Location = new System.Drawing.Point(369, 56);
            this.Choice4_radioBtn.Name = "Choice4_radioBtn";
            this.Choice4_radioBtn.Size = new System.Drawing.Size(63, 17);
            this.Choice4_radioBtn.TabIndex = 4;
            this.Choice4_radioBtn.TabStop = true;
            this.Choice4_radioBtn.Text = " Choix 4";
            this.Choice4_radioBtn.UseVisualStyleBackColor = true;
            // 
            // Choice3_radioBtn
            // 
            this.Choice3_radioBtn.AutoSize = true;
            this.Choice3_radioBtn.Location = new System.Drawing.Point(245, 56);
            this.Choice3_radioBtn.Name = "Choice3_radioBtn";
            this.Choice3_radioBtn.Size = new System.Drawing.Size(60, 17);
            this.Choice3_radioBtn.TabIndex = 3;
            this.Choice3_radioBtn.TabStop = true;
            this.Choice3_radioBtn.Text = "Choix 3";
            this.Choice3_radioBtn.UseVisualStyleBackColor = true;
            this.Choice3_radioBtn.CheckedChanged += new System.EventHandler(this.Choice3_radioBtn_CheckedChanged);
            // 
            // Choice2_radioBtn
            // 
            this.Choice2_radioBtn.AutoSize = true;
            this.Choice2_radioBtn.Location = new System.Drawing.Point(145, 56);
            this.Choice2_radioBtn.Name = "Choice2_radioBtn";
            this.Choice2_radioBtn.Size = new System.Drawing.Size(60, 17);
            this.Choice2_radioBtn.TabIndex = 2;
            this.Choice2_radioBtn.TabStop = true;
            this.Choice2_radioBtn.Text = "Choix 2";
            this.Choice2_radioBtn.UseVisualStyleBackColor = true;
            // 
            // Choice1_radioBtn
            // 
            this.Choice1_radioBtn.AutoSize = true;
            this.Choice1_radioBtn.Location = new System.Drawing.Point(28, 56);
            this.Choice1_radioBtn.Name = "Choice1_radioBtn";
            this.Choice1_radioBtn.Size = new System.Drawing.Size(60, 17);
            this.Choice1_radioBtn.TabIndex = 1;
            this.Choice1_radioBtn.TabStop = true;
            this.Choice1_radioBtn.Text = "Choix 1";
            this.Choice1_radioBtn.UseVisualStyleBackColor = true;
            // 
            // Valider_Btn
            // 
            this.Valider_Btn.Location = new System.Drawing.Point(32, 286);
            this.Valider_Btn.Name = "Valider_Btn";
            this.Valider_Btn.Size = new System.Drawing.Size(75, 23);
            this.Valider_Btn.TabIndex = 3;
            this.Valider_Btn.Text = "Valider";
            this.Valider_Btn.UseVisualStyleBackColor = true;
            this.Valider_Btn.Click += new System.EventHandler(this.Valider_Btn_Click);
            // 
            // Next_Btn
            // 
            this.Next_Btn.Location = new System.Drawing.Point(125, 286);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(136, 23);
            this.Next_Btn.TabIndex = 4;
            this.Next_Btn.Text = "Question suivante";
            this.Next_Btn.UseVisualStyleBackColor = true;
            this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
            // 
            // TestMaths_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 321);
            this.Controls.Add(this.Next_Btn);
            this.Controls.Add(this.Valider_Btn);
            this.Controls.Add(this.Answer_groupBox);
            this.Controls.Add(this.Begin_Btn);
            this.Controls.Add(this.ConsigneMaths_TxtBox);
            this.Name = "TestMaths_Form";
            this.Text = "TestMaths";
            this.Load += new System.EventHandler(this.TestMaths_Form_Load);
            this.Answer_groupBox.ResumeLayout(false);
            this.Answer_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsigneMaths_TxtBox;
        private System.Windows.Forms.Button Begin_Btn;
        private System.Windows.Forms.GroupBox Answer_groupBox;
        private System.Windows.Forms.RadioButton Choice4_radioBtn;
        private System.Windows.Forms.RadioButton Choice3_radioBtn;
        private System.Windows.Forms.RadioButton Choice2_radioBtn;
        private System.Windows.Forms.RadioButton Choice1_radioBtn;
        private System.Windows.Forms.Button Valider_Btn;
        private System.Windows.Forms.Button Next_Btn;
    }
}