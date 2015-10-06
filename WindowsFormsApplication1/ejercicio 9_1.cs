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
    public partial class ejercicio9_1 : Form
    {
        struct Tienda
        {
           private string producto;
            int cantidad;
            public Tienda(string pro, int cant)
            {
                this.producto = pro;
                this.cantidad = cant;
            }

            public string mostrar()
            {
                return this.producto +"  "+ this.cantidad.ToString();
            }

        }
        
        public ejercicio9_1()
        {
            InitializeComponent();
        }

        private void ejercicio9_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tienda t = new Tienda(ProductotextBox.Text,Convert.ToInt32(CantidadtextBox2.Text));
            richTextBox1.Text = t.mostrar();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
