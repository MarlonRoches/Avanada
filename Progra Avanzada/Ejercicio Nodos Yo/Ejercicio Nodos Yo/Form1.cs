using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nodos_Yo
{
    public partial class Form1 : Form
    {
        Agregar_A_Lista x = new Agregar_A_Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x.InsertarNodo(int.Parse(textBox1.Text));
         
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
