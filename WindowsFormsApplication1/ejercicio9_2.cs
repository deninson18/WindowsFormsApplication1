using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ejercicio9_2 : Form
    {
        public struct Cuenta
        {
            private string nombre;
            private string apellido;
            private int numero;

            public Cuenta(string nom,string ape,int num)
            {
                this.nombre = nom;
                this.apellido = ape;
                this.numero = num;
            }

            public string Imprimir()
            {
                return this.nombre + " " + this.apellido +" "+ this.numero.ToString(); 
            }

        }

       
        public ejercicio9_2()
        {
         
            InitializeComponent();
        }

        private void ejercicio9_2_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta(NombretextBox.Text, ApellidotextBox.Text, Convert.ToInt32(NumerotextBox.Text));

            richTextBox2.Text = c.Imprimir();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
