using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controlador controlador = new Controlador();
            Form1 form1 = new Form1();
            controlador.form1 = form1;
            form1.OnAgregarComida += controlador.OnAgregarComida;
            form1.OnEliminarComida += controlador.OnEliminarComida;
            Application.Run(form1);
        }
    }
}
