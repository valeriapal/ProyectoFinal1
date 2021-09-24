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
        private StringBuilder pangrama = new StringBuilder();

        private void txtIngresar_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sbMissing = new StringBuilder();
            pangrama = new StringBuilder(txtIngresar.Text.ToUpper());

            foreach (char sp in SignosPuntuacion)

                pangrama.Replace(sp.ToString(), "".ToString());
            lblLetrasTotal.Text = "" +
               pangrama.Length.ToString();

            foreach (char ch in Letras.ToCharArray())
            {
                if (!pangrama.ToString().Contains(ch))
                {
                    sbMissing.Append(ch);
                    sbMissing.Append(" ");
                    
                }
            }

            txtFaltar.Text = sbMissing.ToString();
            
        }
    }
    }



