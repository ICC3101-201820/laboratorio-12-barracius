using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace MVC
{
    public delegate void AgregarComidaDelegate(string n, int ch, int p, int g);
    public delegate void EliminarComidaDelegate(Comida comida);
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate OnEliminarComida;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                OnAgregarComida.Invoke(NombreTexto.Text, int.Parse(CarbohidratosTexto.Text), int.Parse(ProteinasTexto.Text), int.Parse(GrasasTexto.Text));
            }
        }

        public void AgregarComida(Comida comida)
        {
            comidasList.Items.Add(comida);
        }

        private void EliminarSeleccionBoton_Click(object sender, EventArgs e)
        {
            if (OnEliminarComida != null)
            {
                OnEliminarComida.Invoke((Comida)comidasList.SelectedItem);
            }
            
        }
        public void EliminarComida(Comida comida)
        {
            comidasList.Items.Remove(comida);
        }

        private void comidasList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
