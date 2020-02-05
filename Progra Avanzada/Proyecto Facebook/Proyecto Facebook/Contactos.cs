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
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private void Contactos_Load(object sender, EventArgs e)
        {
            StreamReader contactos = new StreamReader("contacts.txt", true);

            string leerlineas = contactos.ReadLine();//almecena linea           
            string[] campos; //almecenar campos

            string identificador = "";
            cListaEnlazada lista = new cListaEnlazada();
            while (leerlineas != null)
            {
                cNodo auxrecorre = new cNodo();
                campos = leerlineas.Split('$');//separando 

                //enviar a nodo para insertar
                lista.pInserta(campos);

                if (campos[0] != null)
                {


                    identificador = campos[0];
                    comboBox1.Items.Add(identificador);


                }

                auxrecorre = auxrecorre.cEnlace;

                leerlineas = contactos.ReadLine();


            }
            contactos.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            imprimir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            imprimir();
        }
        void imprimir()
        {
            bool flag = true;
            StreamReader scontactos = new StreamReader("contacts.txt", true);
            string identificador = comboBox1.Text;
            string leer = scontactos.ReadLine();//almecena linea
            string[] datos;
            //buscar
            while (leer != null && flag == true)
            {
                datos = leer.Split('$');


                if (identificador == datos[0])
                {
                    label7.Text = datos[0];
                    label8.Text = datos[1];
                    label9.Text = datos[2];
                    label10.Text = datos[3];
                    label11.Text = datos[4];
                    if (datos[5] == "0")
                    {
                        label12.BackColor = Color.DarkGreen;
                        label12.ForeColor = Color.White;
                        label12.Text = ":D";
                        flag = false;
                    }
                    if (datos[5] == "1")
                    {
                        label12.BackColor = Color.DarkRed;
                        label12.ForeColor = Color.White;
                        label12.Text = ">:v";
                        flag = false;
                    }

                    if (datos[5] == "2")
                    {
                        label12.BackColor = Color.Yellow;
                        label12.ForeColor = Color.Black;
                        label12.Text = "♦";
                        flag = false;
                    }

                }
                leer = scontactos.ReadLine();

            }
        }

        void destacar()
        {
            bool flag = true;
            StreamReader scontactos = new StreamReader("contacts.txt", true);

            string identificador = comboBox1.Text;
            string leer = scontactos.ReadLine();//almecena linea
            string[] datos;
            //buscar
            while (leer != null && flag == true)
            {
                datos = leer.Split('$');


                if (identificador == datos[0])
                {

                    if (datos[5] == "0")
                    {
                        datos[5] = "2";
                        label12.BackColor = Color.Yellow;
                        label12.ForeColor = Color.Black;
                        label12.Text = "♦";
                        MessageBox.Show("Destacado Con Exito");
                        scontactos.Close();
                        StreamWriter escribir = new StreamWriter("contacts.txt", true);
                        escribir.WriteLine(datos[0] + "$" + datos[1] + "$" + datos[2] + "$" + datos[3] + "$" + datos[4] + "$" + datos[5]);
                        flag = false;
                    }
                    if (datos[5] == "1")
                    {
                        label12.BackColor = Color.DarkRed;
                        label12.ForeColor = Color.White;
                        label12.Text = ">:v";
                        MessageBox.Show("Desbloquar primero");
                        flag = false;
                    }

                    if (datos[5] == "2")
                    {
                        datos[5] = "2";
                        label12.BackColor = Color.Yellow;
                        label12.ForeColor = Color.Black;
                        label12.Text = "♦";
                        MessageBox.Show("Ya esta destacado");
                        flag = false;

                        flag = false;
                    }

                }

                leer = scontactos.ReadLine();

            }
        }


        void desbloquear()
        {
            bool flag = true;
            StreamReader scontactos = new StreamReader("contacts.txt", true);
            string identificador = comboBox1.Text;
            string leer = scontactos.ReadLine();//almecena linea
            string[] datos;
            //buscar
            while (leer != null && flag == true)
            {
                datos = leer.Split('$');


                if (identificador == datos[0])
                {

                    if (datos[5] == "0")
                    {
                        datos[5] = "1";
                        label12.BackColor = Color.DarkGreen;
                        label12.ForeColor = Color.White;
                        label12.Text = ":D";
                        MessageBox.Show("El usuario no esta bloqueado");
                        flag = false;
                    }
                    if (datos[5] == "1")
                    {
                        label12.BackColor = Color.DarkGreen;
                        label12.ForeColor = Color.White;
                        label12.Text = ":D";
                        MessageBox.Show("Usuario Desbloqueado");
                        flag = false;
                    }

                    if (datos[5] == "2")
                    {

                        MessageBox.Show("El usuario no esta bloqueado");

                        flag = false;
                    }

                }
                leer = scontactos.ReadLine();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        void bloquear()
        {
            bool flag = true;
            StreamReader scontactos = new StreamReader("contacts.txt", true);
            string identificador = comboBox1.Text;
            string leer = scontactos.ReadLine();//almecena linea
            string[] datos;
            //buscar
            while (leer != null && flag == true)
            {
                datos = leer.Split('$');


                if (identificador == datos[0])
                {

                    if (datos[5] == "0")
                    {
                        datos[5] = "1";
                        label12.BackColor = Color.DarkRed;
                        label12.ForeColor = Color.White;
                        label12.Text = ">:v";
                        MessageBox.Show("Bloqueado Con Exito");
                        flag = false;
                    }
                    if (datos[5] == "1")
                    {
                        label12.BackColor = Color.DarkRed;
                        label12.ForeColor = Color.White;
                        label12.Text = ">:v";
                        MessageBox.Show("Ya esta bloqueado");
                        flag = false;
                    }

                    if (datos[5] == "2")
                    {
                        datos[5] = "1";
                        label12.BackColor = Color.DarkRed;
                        label12.ForeColor = Color.White;
                        label12.Text = ">:v";
                        MessageBox.Show("Bloqueado Con Exito");
                        flag = false;

                        flag = false;
                    }

                }
                leer = scontactos.ReadLine();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bloquear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            destacar();
        }
    }

}