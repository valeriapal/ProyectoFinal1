using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double minimo = 0;
        double maximo = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIngresar.Text.Trim() != "")
                {
                    lbLista.Items.Add(float.Parse(txtIngresar.Text));
                    txtIngresar.Text = "";
                    txtIngresar.Focus();
                }
                else
                {
                    MessageBox.Show("Campo Vacío, Asegúrese de ingresar un número", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIngresar.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lo ingresado no es un número, por favor asegúrese de ingresar valores Númericos", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIngresar.Focus();
            }
        }

        private double Minimo()
        {
            minimo = Convert.ToDouble(lbLista.Items[0]);
            for(int i = 0; i < lbLista.Items.Count; i++)
            {
                if(minimo > Convert.ToDouble(lbLista.Items[i]))
                {
                    minimo = Convert.ToDouble(lbLista.Items[i]);
                }
            }
            return minimo;
        }

        private double Maximo()
        {
            maximo = Convert.ToDouble(lbLista.Items[0]);
            for (int i = 0; i < lbLista.Items.Count; i++)
            {
                if (maximo < Convert.ToDouble(lbLista.Items[i]))
                {
                    maximo = Convert.ToDouble(lbLista.Items[i]);
                }
            }
            return maximo;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            if (rbMayor.Checked)
            {
                resultado = Maximo();

                txtResultado2.Text = resultado.ToString();
            }
            

            if (rbMenor.Checked)
            {
                resultado = Minimo();
                txtResultado.Text = resultado.ToString();
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            txtResultado2.Text = String.Empty;
            lbLista.Items.Clear();
        }
    }
}
