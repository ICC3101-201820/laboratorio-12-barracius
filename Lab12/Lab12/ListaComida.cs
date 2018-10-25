using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Modelo
{
    [Serializable]
    public class ListaComida
    {
        List<Comida> comidas;

        public ListaComida()
        {
            comidas = new List<Comida>();
        }
        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
        public void Eliminar(Comida comida)
        {
            comidas.Remove(comida);
        }
        public void Serializar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Lab12.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            formateador.Serialize(miStream, comidas);
            miStream.Close();
        }
        public void Deserializar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Lab12.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            comidas = (List<Comida>)formateador.Deserialize(miStream);
            miStream.Close();
        }
    }
}
