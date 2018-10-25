using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class Comida
    {
        public string nombre;
        public int carbohidratos;
        public int proteinas;
        public int grasas;

        public Comida(string n,int ch,int p, int g)
        {
            nombre = n;
            carbohidratos = ch;
            proteinas = p;
            grasas = g;
        }
        public int Calorias()
        {
            int calorias = 4 * carbohidratos + 4 * proteinas + 9 * grasas;
            return calorias;
        }
        public override string ToString()
        {
            return $"{nombre} (carbohidratos: {carbohidratos}, proteinas: {proteinas}, grasas: {grasas}, calorias: {Calorias()})";
        }
    }
}
