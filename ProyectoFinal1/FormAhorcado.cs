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
            txtPalabra.Text = "";

        }


        private void validadorAhorcado(char letra)
        {
            string textoActual = txtPalabra.Text;
            if (palabraSeleccionada.Contains(letra))
            {
                string palabra_mostrar = string.Empty;
                foreach (var l in palabraSeleccionada)
                {
                    if (letra == l)
                    {
                        palabra_mostrar += letra.ToString();
                    }
                    else
                    {
                        if (textoActual.Contains(l))
                        {
                            palabra_mostrar += $"{l}";
                        }
                        else
                        {
                            palabra_mostrar += " _ ";
                        }
                    }
                }
                txtPalabra.Text = palabra_mostrar;

                if (palabra_mostrar == palabraSeleccionada)
                {
                    MessageBox.Show("¡Ganaste!");
                }
                
            }
            else
            {
                errores++;
                if (errores>=intentos)
                {
                    MessageBox.Show("¡Perdiste!\n la palabra era: " +palabraSeleccionada);
                }
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
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnÑ.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;

            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnA.Text));
            btnA.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnB.Text));
            btnB.Enabled = false;
        }

        private void formAhorcado_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnÑ.Enabled = false;
            btnO.Enabled = false;
            btnP.Enabled = false;
            btnQ.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnV.Enabled = false;
            btnW.Enabled = false;
            btnX.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;


        }

        private void btnC_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnC.Text));
            btnC.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnD.Text));
            btnD.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnE.Text));
            btnE.Enabled = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnF.Text));
            btnF.Enabled = false;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnG.Text));
            btnG.Enabled = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnH.Text));
            btnH.Enabled = false;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnI.Text));
            btnI.Enabled = false;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnJ.Text));
            btnJ.Enabled = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnK.Text));
            btnK.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnL.Text));
            btnL.Enabled = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnM.Text));
            btnM.Enabled = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnN.Text));
            btnN.Enabled = false;
        }

        private void btnÑ_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnÑ.Text));
            btnÑ.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnO.Text));
            btnO.Enabled = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnP.Text));
            btnP.Enabled = false;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnQ.Text));
            btnQ.Enabled = false;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnR.Text));
            btnR.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnS.Text));
            btnS.Enabled = false;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnT.Text));
            btnT.Enabled = false;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnU.Text));
            btnU.Enabled = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnV.Text));
            btnV.Enabled = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnW.Text));
            btnW.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnX.Text));
            btnX.Enabled = false;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnY.Text));
            btnY.Enabled = false;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            validadorAhorcado(Convert.ToChar(btnZ.Text));
            btnZ.Enabled = false;
        }
    }
}
