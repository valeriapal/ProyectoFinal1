﻿using System;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            cbbopciones.Items.Add("Menor de 2 números");
            cbbopciones.Items.Add("Calcula el Area de un Triángulo");
            cbbopciones.Items.Add("Cuenta letras");
            cbbopciones.Items.Add("Invertir palabra");
            cbbopciones.Items.Add("Panagramas");
            cbbopciones.Items.Add("Ahorcado");
        }

       

        private void cbbopciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbbopciones.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(indice))
            {
                switch (indice)
                {
                    case "Menor de 2 números":
                        NumeroMenor();
                        break;
                    case "Calcula el Area de un Triángulo":
                        areaTriangulo();
                        break;
                    case "Cuenta letras":
                        //CuentaLetras();
                        break;
                    case "Invertir palabra":
                        InvertirPalabra();
                        break;
                    case "Panagramas":
                       // Panagramas();
                        break;
                    case "Ahorcado":
                        ahorcado();
                        break;
                }
            }
        }

        private void ahorcado()
        {
            throw new NotImplementedException();
        }

        private void InvertirPalabra()
        {
            formInvertirPalabras formInvertir = new formInvertirPalabras();
            formInvertir.Show();
        }

        /// <summary>
        /// funcion que se encarga de calcular el area de un triangulo.
        /// </summary>
        private void areaTriangulo()
        {
            formAreaTriangulo formArea = new formAreaTriangulo();
            formArea.Show();
        }

        

        private void NumeroMenor()
        {
            Form formulario2 = new Form2();
            formulario2.Show();
        }

    }
}
