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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //BOTON PARA LLAMAR AL FORMULARIO 2 (MODULO 1 MENOR DE DOS NUMEROS)
        {
            Form formulario2 = new Form2();
            formulario2.Show();
        }
    }
}
