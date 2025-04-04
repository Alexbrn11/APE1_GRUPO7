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
    public partial class Programa2cs : Form
    {
        public Programa2cs()
        {
            InitializeComponent();
        }


        private void btnmatriz_Click(object sender, EventArgs e)
        {
            int numEcuaciones;

            // Verificar que el usuario haya ingresado un número válido de ecuaciones
            if (int.TryParse(txtnmecuacio.Text, out numEcuaciones) && numEcuaciones > 0)
            {
                // Limpiar el DataGridView antes de generarlo
                dgvcoefi.Rows.Clear();
                dgvcoefi.Columns.Clear();

                // Generar las columnas para los coeficientes y el término independiente
                for (int i = 0; i < numEcuaciones; i++)
                {
                    dgvcoefi.Columns.Add("Col" + i, "X" + (i + 1)); // X1, X2, ..., Xn
                }
                dgvcoefi.Columns.Add("TérminoIndependiente", "Término Independiente");

                // Ajustar el número de filas según el número de ecuaciones
                for (int i = 0; i < numEcuaciones; i++)
                {
                    dgvcoefi.Rows.Add();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido de ecuaciones.");
            }
        }

        private void btnresolver_Click(object sender, EventArgs e)
        {
            int numEcuaciones;
            if (int.TryParse(txtnmecuacio.Text, out numEcuaciones) && numEcuaciones > 0)
            {
                double[,] matriz = new double[numEcuaciones, numEcuaciones + 1];

                // Llenar la matriz con los valores del DataGridView
                for (int i = 0; i < numEcuaciones; i++)
                {
                    for (int j = 0; j < numEcuaciones; j++)
                    {
                        matriz[i, j] = Convert.ToDouble(dgvcoefi.Rows[i].Cells[j].Value);
                    }
                    matriz[i, numEcuaciones] = Convert.ToDouble(dgvcoefi.Rows[i].Cells[numEcuaciones].Value);
                }

                // Llamar a la función de eliminación de Gauss
                var soluciones = EliminarGauss(matriz, numEcuaciones);

                // Mostrar los resultados o mensaje de error
                if (soluciones == null)
                {
                    txtresultado.Text = "El sistema no tiene solución.";
                }
                else if (soluciones.Length == 0)
                {
                    txtresultado.Text = "El sistema tiene infinitas soluciones.";
                }
                else
                {
                    txtresultado.Text = "Soluciones:\r\n";
                    for (int i = 0; i < numEcuaciones; i++)
                    {
                        txtresultado.Text += $"X{i + 1} = {soluciones[i]:F2}\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido de ecuaciones.");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView y los resultados
            dgvcoefi.Rows.Clear();
            dgvcoefi.Columns.Clear();
            txtnmecuacio.Text = "";
            txtresultado.Text = "";
        }

        // Método para resolver el sistema de ecuaciones por eliminación de Gauss
        private double[] EliminarGauss(double[,] matriz, int n)
        {
            double[] soluciones = new double[n];

            // Eliminación de Gauss
            for (int i = 0; i < n; i++)
            {
                // Buscar el máximo en la columna para estabilidad numérica
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matriz[k, i]) > Math.Abs(matriz[i, i]))
                    {
                        for (int j = 0; j <= n; j++)
                        {
                            double temp = matriz[i, j];
                            matriz[i, j] = matriz[k, j];
                            matriz[k, j] = temp;
                        }
                    }
                }

                // Hacer ceros debajo del pivote
                for (int j = i + 1; j < n; j++)
                {
                    if (matriz[i, i] == 0) continue; // Evitar división por cero

                    double factor = matriz[j, i] / matriz[i, i];
                    for (int k = i; k <= n; k++)
                    {
                        matriz[j, k] -= factor * matriz[i, k];
                    }
                }
            }

            // Verificar si el sistema tiene infinitas soluciones o si es inconsistente
            int filasCero = 0; // Contar filas de solo ceros
            for (int i = 0; i < n; i++)
            {
                bool esFilaCero = true;
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(matriz[i, j]) > 1e-10) // Si hay un coeficiente distinto de 0
                    {
                        esFilaCero = false;
                        break;
                    }
                }

                if (esFilaCero)
                {
                    if (Math.Abs(matriz[i, n]) > 1e-10) // Si el término independiente no es 0
                    {
                        return null; // Sistema sin solución
                    }
                    else
                    {
                        filasCero++; // Contar fila de ceros (posible sistema con infinitas soluciones)
                    }
                }
            }

            if (filasCero > 0) // Si hay filas de solo ceros
            {
                return new double[0]; // Indicar que hay infinitas soluciones
            }

            // Sustitución hacia atrás
            for (int i = n - 1; i >= 0; i--)
            {
                soluciones[i] = matriz[i, n] / matriz[i, i];
                for (int j = i - 1; j >= 0; j--)
                {
                    matriz[j, n] -= matriz[j, i] * soluciones[i];
                }
            }

            return soluciones;
        }

        private void dgvcoefi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
