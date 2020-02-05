using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinListaSimplePA18
{
    public partial class Form1 : Form
    {
        cListaEnlazada cInventario = new cListaEnlazada();
        pilas objeto = new pilas();
        Colas x = new Colas();
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sInformacion sData = new sInformacion();
            sData.iCodigo = int.Parse(textBox1.Text);
            sData.sMarca = textBox2.Text;

            cInventario.pInserta(sData);

            textBox1.Text = ""; 
            textBox1.Focus();


            textBox2.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtmaximo.Text);
            objeto = new pilas(m);
            MessageBox.Show("Pila Creada");

        }

        private void btnpush_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtnumero.Text);
            objeto.push(n);
            txtnumero.Text = "";
            txtnumero.Focus();
        }

        private void btnpop_Click(object sender, EventArgs e)
        {
            int n;
            n = objeto.pop();
            MessageBox.Show("salio " + n);
        }

        private void btncrear2_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtmaximo2.Text);
            x = new Colas(n);
            MessageBox.Show("Se Creo La Cola");
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtnumero2.Text);
            x.agregar_cola(n);
           
            txtnumero2.Clear();
            txtnumero2.Focus();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int n;
            n = x.del_cola();
            if (n == -666)
            {
                MessageBox.Show("Sin Valor ");
                    
            }
            else
            {
                MessageBox.Show("Salio " + n);
            }
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
