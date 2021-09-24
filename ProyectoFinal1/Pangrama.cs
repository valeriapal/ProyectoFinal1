using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal1
{
    public partial class Pangrama : Form
    {
        public Pangrama()
        {
            InitializeComponent();
        }

        private string Letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        private string SignosPuntuacion = " ¨.,-:;!?'\"()[]{}/ ";
        private StringBuilder pangrama = new StringBuilder(); //permite muchas modificaciones a una cadena

        private void txtIngresar_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sbFaltar = new StringBuilder();
            pangrama = new StringBuilder(txtIngresar.Text.ToUpper()); //toma un carácter y devuelve su versión en mayúscula

            foreach (char sp in SignosPuntuacion)

                pangrama.Replace(sp.ToString(), "".ToString()); //La función Replace de las cadenas remplaza una cadena o subcadena por otra y devuelve una cadena nueva en donde ya se ha realizado el remplazo
            lblLetrasTotal.Text = "" +
               pangrama.Length.ToString();

            foreach (char ch in Letras.ToCharArray())
            {
                if (!pangrama.ToString().Contains(ch))
                {
                    sbFaltar.Append(ch);
                   // Anexa una copia de la cadena especificada seguida del terminador de línea predeterminado al final del objeto StringBuilder actual
                    sbFaltar.Append(" ");
                    
                }
            }

            txtFaltar.Text = sbFaltar.ToString();
            
        }
    }
    }



