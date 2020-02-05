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
    public partial class Messeger : Form
    {
        public Messeger()
        {
            InitializeComponent();
        }

        private void Messeger_Load(object sender, EventArgs e)
        {
            StreamReader mensajes = new StreamReader("messenger.txt", true);
            listBox4.Text = "";
            listBox5.Text = "";
            string leerlineas = mensajes.ReadLine();//almecena linea           
            string[] campos; //almecenar campos
            string anterior = "";

            cCola pila = new cCola();
            while (leerlineas != null)
            {
                dNodo auxrecorre = new dNodo();
                campos = leerlineas.Split('$');//separando 

                //enviar a nodo para insertar

                pila.cPush2(campos);
                if (campos[0] != null)
                {


                    if (anterior != campos[0])
                    {
                        listBox1.Items.Add(campos[0]);
                        listBox2.Items.Add(campos[2]);
                        if (campos[3] == "1")
                        {
                            listBox3.Items.Add("♦");
                        }
                        else
                        {
                            listBox3.Items.Add("-");
                        }
                        anterior = campos[0];
                    }





                    //if (campos[3] == "0")
                    //{

                    //    Label estado = new Label();
                    //    estado.Top = y;
                    //    estado.Left = 340;
                    //    estado.Width = 46;
                    //    estado.Height = 17;
                    //    y = y + 17;
                    //    estado.ForeColor = Color.Black;
                    //    estado.BackColor = Color.Cyan;
                    //    estado.Text = "♦";
                    //}
                    //else
                    //{
                    //    Label estado = new Label();
                    //    estado.Top = y;
                    //    estado.Left = 340;
                    //    estado.Width = 46;
                    //    estado.Height = 17;
                    //    y = y + 17;
                    //    estado.ForeColor = Color.DarkBlue;

                    //    estado.Text = "♦";
                    //}




                }

                auxrecorre = auxrecorre.cEnlace;

                leerlineas = mensajes.ReadLine();


            }
            mensajes.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox4.Text = "";
            listBox4.Text = "";
            string actual = Convert.ToString(listBox1.SelectedItem);
            label2.Text = actual;
            StreamReader lol = new StreamReader("messenger.txt", true);

            string leerlineas = lol.ReadLine();//almecena linea           
            string[] lel; //almecenar campos



            while (leerlineas != null)
            {
                lel = leerlineas.Split('$');

                if ((lel[4] == "yo" || lel[4] == "YO" || lel[4] == "Yo" || lel[4] == "yO") && actual == lel[0])
                {
                    listBox5.Items.Add(lel[1]);

                }
                else if (actual == lel[0])
                {
                    listBox4.Items.Add(lel[1]);

                }
                leerlineas = lol.ReadLine();



            }




        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
