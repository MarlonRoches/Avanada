using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winExP1PA18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cCola cColaExamen = new cCola();

        private void onKeyPressUsuario(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                sInformacion sData = new sInformacion();
                sData.iValor = int.Parse(textBox1.Text);
                cColaExamen.cPush(sData);

                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sInformacion sData = new sInformacion();
            sData = cColaExamen.cPop();

            listBox2.Items.Add(sData.iValor + "-" + sData.bPrimo.ToString() + "-" + sData.bNuevo.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cColaExamen.InsertaPrimo();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
