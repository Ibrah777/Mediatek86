using System;
using System.Windows.Forms;

namespace mediatek86
{
    /// <summary>
    /// Point d'entrée de l'application MediaTek86
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.FrmConnexion());
        }
    }
}
