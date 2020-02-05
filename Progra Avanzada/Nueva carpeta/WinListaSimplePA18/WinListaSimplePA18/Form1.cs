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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fact = Convert.ToInt32(textBox3.Text);
            for (int i =fact; i <0; i++)
            {
                fact = fact*(fact - 1);

            }
            textBox3.Text =Convert.ToString(fact);


            //if ( fact==0)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return n * factorial(n - 1;)
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sInformacion sData = new sInformacion();
            sData.iCodigo =int.Parse( textBox4.Text);

           

        }
    }
}
