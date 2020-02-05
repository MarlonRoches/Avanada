using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Proyecto_Facebook
{
    public partial class FormLogin : Form
    {
        Home parent = new Home();


        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader("config.txt", true);
            string leerlineas = leer.ReadLine();//almecena linea
            string[] campos; //almecenar campos



            while (leerlineas != null)
            {
                campos = leerlineas.Split('$');

                if (campos[0] == textBox1.Text && campos[1] == textBox2.Text)
                {
                    Hide();
                    parent.Show();
                    break;
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Datos Erroneos");
                    textBox1.Focus();

                }
                leerlineas = leer.ReadLine();
            }


        }


    }
}
