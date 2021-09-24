using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal1
{
    public partial class CuentaLetras : Form
    {
        public CuentaLetras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            String linea = txtIngresar.Text;
            char caracter = ' ';
            int veces = 0;

            string contar = "";

            for (int i = 0; i < linea.Length; i++)
            {
                if (!contar.Contains(linea[i].ToString())) //Revisa si la letra ya ha sido contada
                {
                    for (int j = 0; j < linea.Length; j++)
                    {
                        caracter = linea[i];
                        if(caracter == linea[j])
                        {
                            veces++;
                        }
                    }

                    lbLista.Items.Add(caracter + " : " + veces);
                    veces = 0;

                    contar += linea[i].ToString(); // Almacena la letra contada

                }
            }
        }
    }
}
