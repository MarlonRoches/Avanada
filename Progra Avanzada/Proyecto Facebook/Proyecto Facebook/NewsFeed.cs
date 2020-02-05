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
    public partial class NewsFeed : Form
    {
        Home home = new Home();
        cCola lista = new cCola();
        int x = 10;
        int y = 30;
        int contador = 1;
        int panelalto = 426;

        public NewsFeed()
        {
            InitializeComponent();

        }

        private void NewsFeed_Load(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader("newsfeed.txt", true);
            string leerlineas = leer.ReadLine();//almecena linea
            string[] campos; //almecenar campos


            while (leerlineas != null)
            {
                cNodo auxrecorre = new cNodo();
                campos = leerlineas.Split('$');//separando 

                //enviar a nodo para insertar
                lista.cPush(campos);

                if (campos[3] != null)
                {

                    Label correo = new Label();
                    Label tipo = new Label();
                    PictureBox foto = new PictureBox();
                    RichTextBox txt = new RichTextBox();

                    //correo

                    correo.Height = 15;
                    correo.Width = 100;
                    correo.Left = x;
                    correo.Top = y;
                    correo.Text = campos[0];
                    panel1.Controls.Add(correo);
                    //tipo
                    tipo.Height = 15;
                    tipo.Width = 50;
                    tipo.Text = campos[1] + ":";
                    tipo.Left = x;
                    tipo.Top = y + 20;
                    panel1.Controls.Add(tipo);
                    //imagen
                    if (campos[1] == "Historia" || campos[1] == "historia" || campos[1] == "HISTORIA")
                    {
                        PictureBox imagen = new PictureBox();
                        //string ruta;

                        imagen.Width = 200;
                        imagen.Height = 100;
                        imagen.Top = y;
                        imagen.Left = x + 310;
                        imagen.Enabled = false;
                        imagen.BackColor = Color.Red;

                        imagen.Name = "imagen" + contador;
                        imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagen.ImageLocation = "foto" + contador + ".jpg";
                        panel1.Controls.Add(imagen);
                        //imagen.Image = ";
                    }
                    //texto
                    txt.Text = campos[3];
                    txt.Width = 200;
                    txt.Height = 100;
                    txt.Top = y;
                    txt.Left = x + 110;
                    txt.Enabled = false;
                    panel1.Controls.Add(txt);
                    txt.Name = "Txt" + contador;
                    contador++;
                    y = y + 105;


                }

                auxrecorre = auxrecorre.cEnlace;

                leerlineas = leer.ReadLine();
                panel1.Height = panelalto + 100;



            }
        }

        private void NewsFeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.fInicio = false;
        }

        private void NewsFeed_FormClosed(object sender, FormClosedEventArgs e)
        {
            home.fInicio = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {



            //panely = vScrollBar1.Value;
            //panely = panel1.Location.Y;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
