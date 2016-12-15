using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EMACApp
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try
            {
                Application.Run(new Accueil_Form());
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
