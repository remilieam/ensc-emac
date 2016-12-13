using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMACApp
{
    public partial class TestResultat_Form : Form
    {
        private string message;

        public TestResultat_Form(string messageTest)
        {
            InitializeComponent();
            this.message = messageTest;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TestResultat_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AfficherPopUp_Timer_Tick(object sender, EventArgs e)
        {
            AfficherPopUp_Timer.Stop();
            this.DialogResult = DialogResult.OK;
        }

        private void TestResultat_Form_Load(object sender, EventArgs e)
        {
            AfficherPopUp_Timer.Start();
            Resultat_Label.Text = message;
        }
    }
}
