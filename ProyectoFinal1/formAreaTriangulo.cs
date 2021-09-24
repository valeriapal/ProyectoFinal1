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
    public partial class formAreaTriangulo : Form
    {
        public formAreaTriangulo()
        {
            InitializeComponent();
        }


        private void formAreaTriangulo_Load(object sender, EventArgs e)
        {
            
        }
        

        /// <summary>
        /// funcion que se encarga de calcular el area de un triangulo.
        /// </summary>
        private void areaTriangulo()
        {
            int _base = int.Parse(textBox1.Text);
            int _altura = int.Parse(textBox2.Text);
            int _area = (_base * _altura) / 2;
            MessageBox.Show("el Area del triangulo es: " +_area.ToString());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""&& textBox2.Text=="")
            {
                MessageBox.Show("ingrese la base y la altura");
            }
            else
            {
                areaTriangulo();
            }
            
        }
    }
}
