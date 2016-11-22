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
            this.CommenceJeux_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConsigneMaths_TxtBox
            // 
            this.ConsigneMaths_TxtBox.Location = new System.Drawing.Point(12, 12);
            this.ConsigneMaths_TxtBox.Multiline = true;
            this.ConsigneMaths_TxtBox.Name = "ConsigneMaths_TxtBox";
            this.ConsigneMaths_TxtBox.Size = new System.Drawing.Size(538, 227);
            this.ConsigneMaths_TxtBox.TabIndex = 0;
            // 
            // CommenceJeux_Btn
            // 
            this.CommenceJeux_Btn.Location = new System.Drawing.Point(475, 286);
            this.CommenceJeux_Btn.Name = "CommenceJeux_Btn";
            this.CommenceJeux_Btn.Size = new System.Drawing.Size(75, 23);
            this.CommenceJeux_Btn.TabIndex = 1;
            this.CommenceJeux_Btn.Text = "Commencer";
            this.CommenceJeux_Btn.UseVisualStyleBackColor = true;
            // 
            // TestMaths_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 321);
            this.Controls.Add(this.CommenceJeux_Btn);
            this.Controls.Add(this.ConsigneMaths_TxtBox);
            this.Name = "TestMaths_Form";
            this.Text = "TestMaths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsigneMaths_TxtBox;
        private System.Windows.Forms.Button CommenceJeux_Btn;
    }
}