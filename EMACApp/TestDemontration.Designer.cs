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
            this.NameTest_Label = new System.Windows.Forms.Label();
            this.Instruction_TextBox = new System.Windows.Forms.TextBox();
            this.TextDemo_TextBox = new System.Windows.Forms.TextBox();
            this.PictureDemo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Play_Button = new System.Windows.Forms.Button();
            this.Next_PictureBox = new System.Windows.Forms.PictureBox();
            this.Previous_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDemo_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTest_Label
            // 
            this.NameTest_Label.AutoSize = true;
            this.NameTest_Label.BackColor = System.Drawing.Color.Transparent;
            this.NameTest_Label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTest_Label.ForeColor = System.Drawing.Color.White;
            this.NameTest_Label.Location = new System.Drawing.Point(239, 26);
            this.NameTest_Label.Name = "NameTest_Label";
            this.NameTest_Label.Size = new System.Drawing.Size(0, 37);
            this.NameTest_Label.TabIndex = 0;
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
            this.Instruction_TextBox.TextChanged += new System.EventHandler(this.Instruction_TextBox_TextChanged);
            // 
            // TextDemo_TextBox
            // 
            this.TextDemo_TextBox.Enabled = false;
            this.TextDemo_TextBox.Location = new System.Drawing.Point(52, 51);
            this.TextDemo_TextBox.Multiline = true;
            this.TextDemo_TextBox.Name = "TextDemo_TextBox";
            this.TextDemo_TextBox.Size = new System.Drawing.Size(926, 62);
            this.TextDemo_TextBox.TabIndex = 2;
            this.TextDemo_TextBox.Visible = false;
            // 
            // PictureDemo_PictureBox
            // 
            this.PictureDemo_PictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureDemo_PictureBox.Location = new System.Drawing.Point(52, 89);
            this.PictureDemo_PictureBox.Name = "PictureDemo_PictureBox";
            this.PictureDemo_PictureBox.Size = new System.Drawing.Size(926, 378);
            this.PictureDemo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureDemo_PictureBox.TabIndex = 3;
            this.PictureDemo_PictureBox.TabStop = false;
            this.PictureDemo_PictureBox.Visible = false;
            // 
            // Play_Button
            // 
            this.Play_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Button.Location = new System.Drawing.Point(470, 481);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(95, 37);
            this.Play_Button.TabIndex = 4;
            this.Play_Button.Text = "JOUER";
            this.Play_Button.UseVisualStyleBackColor = true;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // Next_PictureBox
            // 
            this.Next_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Next_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Next_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Next_PictureBox.Image")));
            this.Next_PictureBox.Location = new System.Drawing.Point(996, 234);
            this.Next_PictureBox.Name = "Next_PictureBox";
            this.Next_PictureBox.Size = new System.Drawing.Size(30, 59);
            this.Next_PictureBox.TabIndex = 5;
            this.Next_PictureBox.TabStop = false;
            this.Next_PictureBox.Click += new System.EventHandler(this.Next_PictureBox_Click);
            // 
            // Previous_PictureBox
            // 
            this.Previous_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Previous_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Previous_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Previous_PictureBox.Image")));
            this.Previous_PictureBox.Location = new System.Drawing.Point(8, 234);
            this.Previous_PictureBox.Name = "Previous_PictureBox";
            this.Previous_PictureBox.Size = new System.Drawing.Size(32, 59);
            this.Previous_PictureBox.TabIndex = 6;
            this.Previous_PictureBox.TabStop = false;
            this.Previous_PictureBox.Click += new System.EventHandler(this.Previous_PictureBox_Click);
            // 
            // TestDemonstration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Previous_PictureBox);
            this.Controls.Add(this.Next_PictureBox);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.PictureDemo_PictureBox);
            this.Controls.Add(this.TextDemo_TextBox);
            this.Controls.Add(this.Instruction_TextBox);
            this.Controls.Add(this.NameTest_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TestDemonstration_Form";
            this.Text = "Consigne et démonstration du test";
            this.Load += new System.EventHandler(this.TestPerceptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureDemo_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTest_Label;
        private System.Windows.Forms.TextBox Instruction_TextBox;
        private System.Windows.Forms.TextBox TextDemo_TextBox;
        private System.Windows.Forms.PictureBox PictureDemo_PictureBox;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.PictureBox Next_PictureBox;
        private System.Windows.Forms.PictureBox Previous_PictureBox;

    }
}