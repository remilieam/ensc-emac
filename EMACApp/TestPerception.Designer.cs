namespace EMACApp
{
    partial class TestPerception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPerception));
            this.NameTest1_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTest1_Label
            // 
            this.NameTest1_Label.AutoSize = true;
            this.NameTest1_Label.BackColor = System.Drawing.Color.Transparent;
            this.NameTest1_Label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTest1_Label.ForeColor = System.Drawing.Color.White;
            this.NameTest1_Label.Location = new System.Drawing.Point(666, 63);
            this.NameTest1_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameTest1_Label.Name = "NameTest1_Label";
            this.NameTest1_Label.Size = new System.Drawing.Size(664, 47);
            this.NameTest1_Label.TabIndex = 1;
            this.NameTest1_Label.Text = "Perception et mémoire associative";
            // 
            // TestPerception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1910, 1030);
            this.Controls.Add(this.NameTest1_Label);
            this.Name = "TestPerception";
            this.Text = "Perception et mémoire associative";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTest1_Label;
    }
}