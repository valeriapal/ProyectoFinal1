using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal1
{
    public partial class formInvertirPalabras : Form
    {
        public formInvertirPalabras()
        {
            InitializeComponent();
        }


        private void InvertirPalabras_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// funcion que se encarga de invertir palabras
        /// </summary>
        private void InvertirPalabras()
        {
            string palabraInvertida = string.Empty;
            string palabraOriginal = textBox1.Text;

            if (palabraOriginal == "")
            {
                MessageBox.Show("ingrese una palabra");
            }
            else
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    palabraInvertida += palabraOriginal[textBox1.Text.Length - (i + 1)];
                }
                textBox2.Text = palabraInvertida;
            }
        }

        private void btnIvertir_Click(object sender, EventArgs e)
        {
            InvertirPalabras();
        }
    }
}
