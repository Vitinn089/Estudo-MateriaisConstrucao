using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin formLogin = new frmLogin();
            formLogin.ShowDialog();
            if (formLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmPrincipal(formLogin.idUsuario));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
