using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursividad_Suma_de_Vector
{
    public partial class Form1 : Form
    {
        Recursion Espacio = new Recursion();
        int[] Arreglo;
        public int contador = 0;
        public int iTam = 0;


        Recursion Invertir = new Recursion();
        String numerito = "";

        Recursion Factorial = new Recursion();
        int multiplicar = 0; 

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Arreglo[contador] = int.Parse(txtnumeros.Text);
            contador = contador + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iTam = int.Parse(txtasignar.Text);
            Arreglo = new int[iTam];
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int iRes = Espacio.Recursividad(Arreglo,iTam);
            label2.Text = iRes.ToString();

        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            numerito = txtNum.Text;
            lblInvertir.Text = Invertir.Recursividad2(numerito, numerito.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            multiplicar = int.Parse(txtFact.Text);
            int iFact = Factorial.Recursividad3(multiplicar);
            lblFact.Text = iFact.ToString();
        }
    }
}
