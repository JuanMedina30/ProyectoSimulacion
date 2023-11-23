using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSimulacionIndividual
{
    public partial class Principal : Form
    {
        double[] Numeros;
        double Cajas, Precio;
        int Cant; 

        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaracion
            double X;
            int A, C, M;

            //Captura
            try
            {
                X = double.Parse(txtSem.Text);
                A = Int32.Parse(txtC_M.Text);
                C = Int32.Parse(txtC_A.Text);
                M = Int32.Parse(txtMod.Text);
                Cant = Int32.Parse(txtCant.Text);
                Numeros = new double[Cant]; 
                
                for (int i = 0; i < Cant; i++)
                {
                    X = (A * X + C) % M;

                    dataGridView1.Rows.Add((i + 1), X / M);
                    Numeros[i] = (X / M);
                }

            }

            catch (FormatException)
            {
                MessageBox.Show("Error \nLos datos introducidos no son validos. \n Porfavor vuelva a intentarlo",
                    "Datos Erroneos", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtC_A.Clear();
                txtC_M.Clear();
                txtMod.Clear();
                txtSem.Clear();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            txtC.Text = "100";
            txtP.Text = "150";
            txtCant.Text = "50"; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtC_A.Clear();
            txtC_M.Clear();
            txtMod.Clear();
            txtSem.Clear();
            txtCant.Clear(); 

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            labelRes.Text = "";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int contMen=0, contMay=0;
            
            try
            {
                Cajas = Double.Parse(txtC.Text);
                Precio = Double.Parse(txtP.Text);

                double Resultado = (Cajas * Precio) * .7;

                double Res = (Cajas * Precio) * -.1;

                for (int i = 0; i < Cant; i++)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = i + 1;

                    dataGridView2.Rows[n].Cells[1].Value = Numeros[i];

                    if (Numeros[i] <= 0.15)
                    {
                        dataGridView2.Rows[n].Cells[2].Value = "3 días";
                        contMen++; 
                    }
                    else if (Numeros[i] > 0.16 && Numeros[i] <= 0.23)
                    {
                        dataGridView2.Rows[n].Cells[2].Value = "5 días";
                        contMen++; 
                    }
                    else if (Numeros[i] > 0.24 && Numeros[i] <= 0.35)
                    {
                        contMen++; 
                        dataGridView2.Rows[n].Cells[2].Value = "8 días";
                    }
                    else if (Numeros[i] > 0.36 && Numeros[i] <= 0.55)
                    {
                        contMen++; 
                        dataGridView2.Rows[n].Cells[2].Value = "10 días";
                    }
                    else if (Numeros[i] > 0.56 && Numeros[i] <= 0.80)
                    {
                        contMay++; 
                        dataGridView2.Rows[n].Cells[2].Value = "14 días";
                    }
                    else
                    {
                        contMay++; 
                        dataGridView2.Rows[n].Cells[2].Value = "16 días";
                    }
                }

                label6.Text = "Años con invierno menor a 14 dias: " +contMay; 


                int porcentaje = (int) Math.Round((Cant * .45));
               

                if (contMen >= porcentaje)
                {
                    labelRes.Text = "CONCLUSION: \n Vender toda la mercancía en este momento con una ganancia \n segura del 30%";
                }
                else
                {
                    labelRes.Text = "CONCLUSION: \n Politica 2: posibilidad de obtener una ganancia del 70% ";
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Debe de ingresar un valor válido");
            }
        }


    }
}

