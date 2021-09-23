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
    public partial class formAhorcado : Form
    {

        private string[] palabras1;
        string palabraSeleccionada;
        int errores;
        int intentos = 3;

        //constructor del formulario
        public formAhorcado()
        {
            InitializeComponent();//inicializa los controles del formulario
        }




        /// <summary>
        /// funcion que se encarga de inicializar el juego ahorcado 
        /// </summary>
        private void IniciarAhorcado()
        {
            palabras1 = new string[] { "Colombia", "Ecuador", "Urugay", "Mexico", "Panama", "Chile", "Peru", "Salvador", "Brasil", "Venezuela", "Bolivia", "Guyana", "Paraguay", "Suriname" };

            errores = 0;
            Random random = new Random();
            int indicePalabraSeleccionada = random.Next(0, palabras1.Length);
            palabraSeleccionada = palabras1[indicePalabraSeleccionada].ToUpper().ToString();
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            validadorAhorcado(btnA.Text);
            btnA.Enabled = false;
        }

        private void validadorAhorcado(string letra)
        {
            if (palabraSeleccionada.Contains(letra))
            {

            }
            else
            {
                errores++;
                pintarImagen(errores);
            }
            
            
        }

        private void pintarImagen(int errores)
        {
            switch (errores)
            {
                case 0:
                    pictureBox1.Image = global::ProyectoFinal1.Properties.Resources.ahorcado0;
                    break;
                case 1:
                    pictureBox1.Image = global::ProyectoFinal1.Properties.Resources.ahorcado1;
                    break;
                case 2:
                    pictureBox1.Image = global::ProyectoFinal1.Properties.Resources.ahorcado2;
                    break;
                case 3:
                    pictureBox1.Image = global::ProyectoFinal1.Properties.Resources.ahorcado3;
                    break;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            IniciarAhorcado();
        }
    }
}
