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
    public partial class Programa1 : Form
    {
        public Programa1()
        {
            InitializeComponent();
        }

        private void Programa1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtTamaño.Text);
                dgvMatrizA.ColumnCount = n;
                dgvMatrizA.RowCount = n;
                dgvMatrizB.ColumnCount = n;
                dgvMatrizB.RowCount = n;

                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dgvMatrizA[j, i].Value = rand.Next(1, 10);
                        dgvMatrizB[j, i].Value = rand.Next(1, 10);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int[,] MultiplicarMatrices(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] resultado = new int[n, n];

            Parallel.For(0, n, i =>
            {
                for (int j = 0; j < n; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < n; k++)
                    {
                        suma += A[i, k] * B[k, j];
                    }
                    resultado[i, j] = suma;
                }
            });

            return resultado;
        }

        private void bntMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgvMatrizA.RowCount;
                int[,] A = new int[n, n];
                int[,] B = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = Convert.ToInt32(dgvMatrizA[j, i].Value);
                        B[i, j] = Convert.ToInt32(dgvMatrizB[j, i].Value);
                    }
                }

                int[,] resultado = MultiplicarMatrices(A, B);

                dgvResultado.ColumnCount = n;
                dgvResultado.RowCount = n;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dgvResultado[j, i].Value = resultado[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la multiplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

            dgvMatrizA.Rows.Clear(); // Limpiar la matriz A
            dgvMatrizB.Rows.Clear(); // Limpiar la matriz B
            dgvResultado.Rows.Clear(); // Limpiar la matriz de resultado
            txtTamaño.Clear();
        }

        
    }
    
}
