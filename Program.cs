using System;
using System.Windows.Forms;

namespace Yahtzee {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmInicio inicio = frmInicio.getInstance();
            Application.Run(inicio);
        }
    }
}
