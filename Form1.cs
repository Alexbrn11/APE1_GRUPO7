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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            //mejoras en el boton abrir
            btnabrir.BackColor = Color.LightBlue;
            btnabrir.FlatStyle = FlatStyle.Flat;
            btnabrir.FlatAppearance.BorderSize = 2;
          
            //para que abra el form2
            Form2 nuevoFormulario = new Form2(); // Crea la nueva ventana
            nuevoFormulario.Show(); // Muestra Form2 sin cerrar Form1
            this.Hide();
        

    }

        
    }
}
