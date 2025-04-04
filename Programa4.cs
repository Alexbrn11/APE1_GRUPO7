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
    public partial class Programa4 : Form
    {
        public Programa4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                double[,] matrix = ReadMatrix(txtMatriz.Text);
                if (!IsSymmetric(matrix))
                {
                    MessageBox.Show("La matriz no es simétrica. Introduzca una matriz válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int n = matrix.GetLength(0);
                double[] eigenvalues = JacobiMethod(matrix, out int iterations);

                // Mostrar resultados
                lblAutovalores.Text = "Respuesta" + string.Join(", ", eigenvalues.Select(x => x.ToString("F4")));
                lblIteraciones.Text = "Respuesta" + iterations;
                DisplayMatrix(matrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la entrada de datos: " + ex.Message);
            }
        }

        private double[,] ReadMatrix(string input)
        {
            string[] rows = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int n = rows.Length;
            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = rows[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (values.Length != n) throw new Exception("La matriz debe ser cuadrada.");
                for (int j = 0; j < n; j++)
                    matrix[i, j] = double.Parse(values[j]);
            }

            return matrix;
        }

        private bool IsSymmetric(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (matrix[i, j] != matrix[j, i])
                        return false;
            return true;
        }

        private double[] JacobiMethod(double[,] matrix, out int iterations)
        {
            int n = matrix.GetLength(0);
            double tolerance = 1e-10;
            double maxOffDiagonal;
            iterations = 0;

            do
            {
                maxOffDiagonal = 0.0;
                int p = 0, q = 0;

                // Encontrar el mayor elemento fuera de la diagonal
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(matrix[i, j]) > maxOffDiagonal)
                        {
                            maxOffDiagonal = Math.Abs(matrix[i, j]);
                            p = i;
                            q = j;
                        }
                    }
                }

                if (maxOffDiagonal < tolerance)
                    break;

                double theta = 0.5 * Math.Atan2(2 * matrix[p, q], matrix[q, q] - matrix[p, p]);
                double cos = Math.Cos(theta);
                double sin = Math.Sin(theta);

                double app = matrix[p, p];
                double aqq = matrix[q, q];
                matrix[p, p] = cos * cos * app - 2 * sin * cos * matrix[p, q] + sin * sin * aqq;
                matrix[q, q] = sin * sin * app + 2 * sin * cos * matrix[p, q] + cos * cos * aqq;
                matrix[p, q] = matrix[q, p] = 0.0;

                for (int i = 0; i < n; i++)
                {
                    if (i != p && i != q)
                    {
                        double aip = matrix[i, p];
                        double aiq = matrix[i, q];
                        matrix[i, p] = matrix[p, i] = cos * aip - sin * aiq;
                        matrix[i, q] = matrix[q, i] = sin * aip + cos * aiq;
                    }
                }

                iterations++;

            } while (maxOffDiagonal > tolerance);

            double[] eigenvalues = new double[n];
            for (int i = 0; i < n; i++)
                eigenvalues[i] = matrix[i, i];

            return eigenvalues;
        }

        private void DisplayMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            dgvMatriz.ColumnCount = n;
            dgvMatriz.RowCount = n;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dgvMatriz.Rows[i].Cells[j].Value = matrix[i, j].ToString("F4");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMatriz.Clear();
            lblAutovalores.Clear();
            lblIteraciones.Clear();
            dgvMatriz.ClearSelection();
        }
    } }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
 
