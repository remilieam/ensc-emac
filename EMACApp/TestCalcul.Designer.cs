namespace EMACApp
{
    partial class TestCalcul_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCalcul_Form));
            this.ProgressTest3_TextBox = new System.Windows.Forms.TextBox();
            this.NameTest3_Label = new System.Windows.Forms.Label();
            this.Area_PictureBox = new System.Windows.Forms.PictureBox();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Operation_TextBlox = new System.Windows.Forms.TextBox();
            this.Answer_TextBox = new System.Windows.Forms.TextBox();
            this.Equal_Label = new System.Windows.Forms.Label();
            this.Addition_Button = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.Multiplication_Button = new System.Windows.Forms.Button();
            this.Subtraction_Button = new System.Windows.Forms.Button();
            this.Choice_TextBox = new System.Windows.Forms.TextBox();
            this.DisplayQuestion_Timer = new System.Windows.Forms.Timer(this.components);
            this.End_Button = new System.Windows.Forms.Button();
            this.Result_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Area_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressTest3_TextBox
            // 
            this.ProgressTest3_TextBox.BackColor = System.Drawing.Color.White;
            this.ProgressTest3_TextBox.Enabled = false;
            this.ProgressTest3_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressTest3_TextBox.ForeColor = System.Drawing.Color.Black;
            this.ProgressTest3_TextBox.Location = new System.Drawing.Point(161, 99);
            this.ProgressTest3_TextBox.Name = "ProgressTest3_TextBox";
            this.ProgressTest3_TextBox.Size = new System.Drawing.Size(712, 29);
            this.ProgressTest3_TextBox.TabIndex = 31;
            this.ProgressTest3_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProgressTest3_TextBox.Visible = false;
            // 
            // NameTest3_Label
            // 
            this.NameTest3_Label.AutoSize = true;
            this.NameTest3_Label.BackColor = System.Drawing.Color.Transparent;
            this.NameTest3_Label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTest3_Label.ForeColor = System.Drawing.Color.White;
            this.NameTest3_Label.Location = new System.Drawing.Point(400, 35);
            this.NameTest3_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameTest3_Label.Name = "NameTest3_Label";
            this.NameTest3_Label.Size = new System.Drawing.Size(228, 37);
            this.NameTest3_Label.TabIndex = 30;
            this.NameTest3_Label.Text = "Calcul mental";
            // 
            // Area_PictureBox
            // 
            this.Area_PictureBox.BackColor = System.Drawing.Color.White;
            this.Area_PictureBox.Location = new System.Drawing.Point(161, 163);
            this.Area_PictureBox.Name = "Area_PictureBox";
            this.Area_PictureBox.Size = new System.Drawing.Size(712, 345);
            this.Area_PictureBox.TabIndex = 32;
            this.Area_PictureBox.TabStop = false;
            this.Area_PictureBox.Visible = false;
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Button.Location = new System.Drawing.Point(390, 418);
            this.Confirm_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(254, 68);
            this.Confirm_Button.TabIndex = 33;
            this.Confirm_Button.Text = "VALIDER";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Visible = false;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Operation_TextBlox
            // 
            this.Operation_TextBlox.BackColor = System.Drawing.Color.White;
            this.Operation_TextBlox.Enabled = false;
            this.Operation_TextBlox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation_TextBlox.ForeColor = System.Drawing.Color.Black;
            this.Operation_TextBlox.Location = new System.Drawing.Point(276, 285);
            this.Operation_TextBlox.Name = "Operation_TextBlox";
            this.Operation_TextBlox.Size = new System.Drawing.Size(267, 29);
            this.Operation_TextBlox.TabIndex = 34;
            this.Operation_TextBlox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Operation_TextBlox.Visible = false;
            // 
            // Answer_TextBox
            // 
            this.Answer_TextBox.BackColor = System.Drawing.Color.White;
            this.Answer_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Answer_TextBox.Location = new System.Drawing.Point(602, 285);
            this.Answer_TextBox.Name = "Answer_TextBox";
            this.Answer_TextBox.Size = new System.Drawing.Size(123, 29);
            this.Answer_TextBox.TabIndex = 35;
            this.Answer_TextBox.Visible = false;
            // 
            // Equal_Label
            // 
            this.Equal_Label.AutoSize = true;
            this.Equal_Label.BackColor = System.Drawing.Color.White;
            this.Equal_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_Label.ForeColor = System.Drawing.Color.Black;
            this.Equal_Label.Location = new System.Drawing.Point(563, 288);
            this.Equal_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Equal_Label.Name = "Equal_Label";
            this.Equal_Label.Size = new System.Drawing.Size(21, 22);
            this.Equal_Label.TabIndex = 36;
            this.Equal_Label.Text = "=";
            this.Equal_Label.Visible = false;
            // 
            // Addition_Button
            // 
            this.Addition_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition_Button.Location = new System.Drawing.Point(259, 323);
            this.Addition_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Addition_Button.Name = "Addition_Button";
            this.Addition_Button.Size = new System.Drawing.Size(68, 68);
            this.Addition_Button.TabIndex = 37;
            this.Addition_Button.Text = "+";
            this.Addition_Button.UseVisualStyleBackColor = true;
            this.Addition_Button.Click += new System.EventHandler(this.Addition_Button_Click);
            // 
            // Division_Button
            // 
            this.Division_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division_Button.Location = new System.Drawing.Point(716, 323);
            this.Division_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(68, 68);
            this.Division_Button.TabIndex = 38;
            this.Division_Button.Text = "÷";
            this.Division_Button.UseVisualStyleBackColor = true;
            this.Division_Button.Click += new System.EventHandler(this.Division_Button_Click);
            // 
            // Multiplication_Button
            // 
            this.Multiplication_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication_Button.Location = new System.Drawing.Point(560, 323);
            this.Multiplication_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Multiplication_Button.Name = "Multiplication_Button";
            this.Multiplication_Button.Size = new System.Drawing.Size(68, 68);
            this.Multiplication_Button.TabIndex = 39;
            this.Multiplication_Button.Text = "×";
            this.Multiplication_Button.UseVisualStyleBackColor = true;
            this.Multiplication_Button.Click += new System.EventHandler(this.Multiplication_Button_Click);
            // 
            // Subtraction_Button
            // 
            this.Subtraction_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction_Button.Location = new System.Drawing.Point(407, 323);
            this.Subtraction_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Subtraction_Button.Name = "Subtraction_Button";
            this.Subtraction_Button.Size = new System.Drawing.Size(68, 68);
            this.Subtraction_Button.TabIndex = 40;
            this.Subtraction_Button.Text = "–";
            this.Subtraction_Button.UseVisualStyleBackColor = true;
            this.Subtraction_Button.Click += new System.EventHandler(this.Subtraction_Button_Click);
            // 
            // Choice_TextBox
            // 
            this.Choice_TextBox.BackColor = System.Drawing.Color.White;
            this.Choice_TextBox.Enabled = false;
            this.Choice_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Choice_TextBox.Location = new System.Drawing.Point(161, 203);
            this.Choice_TextBox.Multiline = true;
            this.Choice_TextBox.Name = "Choice_TextBox";
            this.Choice_TextBox.Size = new System.Drawing.Size(712, 52);
            this.Choice_TextBox.TabIndex = 41;
            this.Choice_TextBox.Text = "Cliquez sur le bouton comportant le signe de l’opération\r\nsur laquelle vous voule" +
    "z vous tester.";
            this.Choice_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // End_Button
            // 
            this.End_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Button.Location = new System.Drawing.Point(390, 418);
            this.End_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.End_Button.Name = "End_Button";
            this.End_Button.Size = new System.Drawing.Size(254, 68);
            this.End_Button.TabIndex = 43;
            this.End_Button.Text = "TERMINER";
            this.End_Button.UseVisualStyleBackColor = true;
            this.End_Button.Visible = false;
            this.End_Button.Click += new System.EventHandler(this.End_Button_Click);
            // 
            // Result_TextBox
            // 
            this.Result_TextBox.BackColor = System.Drawing.Color.White;
            this.Result_TextBox.Enabled = false;
            this.Result_TextBox.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Result_TextBox.Location = new System.Drawing.Point(161, 244);
            this.Result_TextBox.Name = "Result_TextBox";
            this.Result_TextBox.Size = new System.Drawing.Size(712, 29);
            this.Result_TextBox.TabIndex = 42;
            this.Result_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Result_TextBox.Visible = false;
            // 
            // TestCalcul_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.Equal_Label);
            this.Controls.Add(this.End_Button);
            this.Controls.Add(this.Result_TextBox);
            this.Controls.Add(this.Choice_TextBox);
            this.Controls.Add(this.Subtraction_Button);
            this.Controls.Add(this.Multiplication_Button);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Addition_Button);
            this.Controls.Add(this.Answer_TextBox);
            this.Controls.Add(this.Operation_TextBlox);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.ProgressTest3_TextBox);
            this.Controls.Add(this.NameTest3_Label);
            this.Controls.Add(this.Area_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestCalcul_Form";
            this.Text = "Calcul mental";
            ((System.ComponentModel.ISupportInitialize)(this.Area_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProgressTest3_TextBox;
        private System.Windows.Forms.Label NameTest3_Label;
        private System.Windows.Forms.PictureBox Area_PictureBox;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.TextBox Operation_TextBlox;
        private System.Windows.Forms.TextBox Answer_TextBox;
        private System.Windows.Forms.Label Equal_Label;
        private System.Windows.Forms.Button Addition_Button;
        private System.Windows.Forms.Button Division_Button;
        private System.Windows.Forms.Button Multiplication_Button;
        private System.Windows.Forms.Button Subtraction_Button;
        private System.Windows.Forms.TextBox Choice_TextBox;
        private System.Windows.Forms.Timer DisplayQuestion_Timer;
        private System.Windows.Forms.Button End_Button;
        private System.Windows.Forms.TextBox Result_TextBox;
    }
}