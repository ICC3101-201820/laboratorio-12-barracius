using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Modelo;

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
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Lab12.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controlador controlador = new Controlador();
            Form1 form1 = new Form1();
            controlador.form1 = form1;
            form1.OnAgregarComida += controlador.OnAgregarComida;
            form1.OnEliminarComida += controlador.OnEliminarComida;

            //DESERIALIZAR
            if (new FileInfo("Lab12.bin").Length != 0)
            {
                controlador = (Controlador)formateador.Deserialize(miStream);
                miStream.Close();
            }


            Application.Run(form1);

            //SERIALIZAR

            formateador.Serialize(miStream, controlador);
            miStream.Close();
        }
    }
}
