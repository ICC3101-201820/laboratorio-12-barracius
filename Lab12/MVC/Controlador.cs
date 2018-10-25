using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace MVC
{
    [Serializable]
    class Controlador
    {
        public Form1 form1;
        public ListaComida comidas;

        public Controlador()
        {
            comidas = new ListaComida();
        }

        public void OnAgregarComida(string n, int ch, int p, int g)
        {
            Comida comida = new Comida(n, ch, p, g);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
        public void OnEliminarComida(Comida comida)
        {
            comidas.Eliminar(comida);
            form1.EliminarComida(comida);
        }
    }
}
