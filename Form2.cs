using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APE1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //para que abra el programa1
            Programa1 nuevoFormulario = new Programa1(); // Crea la nueva ventana
            nuevoFormulario.Show(); // Muestra Form2 sin cerrar Form1
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //para que abra el programa2
            Programa2cs nuevoFormulario = new Programa2cs(); // Crea la nueva ventana
            nuevoFormulario.Show(); // Muestra Form2 sin cerrar Form1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //para que abra el programa3
            Programa3 nuevoFormulario = new Programa3(); // Crea la nueva ventana
            nuevoFormulario.Show(); // Muestra Form2 sin cerrar Form1
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //para que abra el programa4
            Programa4 nuevoFormulario = new Programa4(); // Crea la nueva ventana
            nuevoFormulario.Show(); // Muestra Form2 sin cerrar Form1

        }

    }
}
