using System;
using System.Windows.Forms;

namespace PT4
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjAyNzgwQDMxMzkyZTM0MmUzMEM0dk9wQTcrb21DbFJZeVh5Z0pacFdmclVFZnVnM1k1aGFMNVZZNWJkd0U9");
            Application.EnableVisualStyles();
            Application.Run(PageManager.connexion);
        }
    }
}
