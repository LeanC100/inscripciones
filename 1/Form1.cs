using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        Cola Cola = new Cola();
        Cola ColaHombres = new Cola();
        Cola ColaMujeres = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        // funciones
        public string sexo()
        {
            string sexo;
            if (rbtnHombre.Checked == true) sexo = rbtnHombre.Text;
            else sexo = rbtnMujer.Text;
            return sexo;
        }

        public void MostrarCola()
        {

            listboxInscriptos.Items.Add(Cola.BuscarUltimo(Cola.Inicio));

        }
        // Form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || (rbtnHombre.Checked == false && rbtnMujer.Checked == false))
            {
                MessageBox.Show("Debe ingresar un nombre válido");
            }
            else
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Nombre = txtNombre.Text;
                nuevoNodo.Sexo = sexo();
                Cola.AddCola(nuevoNodo);
                if (nuevoNodo.Sexo == "Hombre")
                {

                    listboxHombres.Items.Add(ColaHombres.BuscarUltimo(Cola.Inicio));
                }
                else
                {
                    listbosMojeres.Items.Add(ColaMujeres.BuscarUltimo(Cola.Inicio));
                }
                MostrarCola();

            }
        }
    }
}
