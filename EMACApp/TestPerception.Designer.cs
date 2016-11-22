namespace EMACApp
{
    partial class TestPerceptionForm
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
            this.ImageTest1PictureBox = new System.Windows.Forms.PictureBox();
            this.ConsigneTest1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTest1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageTest1PictureBox
            // 
            this.ImageTest1PictureBox.Location = new System.Drawing.Point(12, 12);
            this.ImageTest1PictureBox.Name = "ImageTest1PictureBox";
            this.ImageTest1PictureBox.Size = new System.Drawing.Size(830, 476);
            this.ImageTest1PictureBox.TabIndex = 0;
            this.ImageTest1PictureBox.TabStop = false;
            // 
            // ConsigneTest1Label
            // 
            this.ConsigneTest1Label.AutoSize = true;
            this.ConsigneTest1Label.Location = new System.Drawing.Point(297, 111);
            this.ConsigneTest1Label.Name = "ConsigneTest1Label";
            this.ConsigneTest1Label.Size = new System.Drawing.Size(264, 25);
            this.ConsigneTest1Label.TabIndex = 1;
            this.ConsigneTest1Label.Text = "Retenez les chiffres dans les \r\n";
            this.ConsigneTest1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestPerceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 500);
            this.Controls.Add(this.ConsigneTest1Label);
            this.Controls.Add(this.ImageTest1PictureBox);
            this.Name = "TestPerceptionForm";
            this.Text = "Perception et mémoire associative";
            this.Load += new System.EventHandler(this.TestPerceptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageTest1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageTest1PictureBox;
        private System.Windows.Forms.Label ConsigneTest1Label;
    }
}