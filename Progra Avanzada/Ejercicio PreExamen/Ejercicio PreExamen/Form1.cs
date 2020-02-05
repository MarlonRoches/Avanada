using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_PreExamen
{
    public partial class Form1 : Form
    {
        cCola x = new cCola();
        Cajero cajero = new Cajero();
        public int contador_clientes = 0;
        public int segundoscajero1 = 0, atendidos1 = 0, compararseg1 = 0;
        public int segundoscajero2 = 0, atendidos2 = 0, compararseg2 = 0;
        public int segundoscajero3 = 0, atendidos3 = 0, compararseg3 = 0;
        public int segundoscajero4 = 0, atendidos4 = 0, compararseg4 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (contador_clientes <= 4)
            {
                MessageBox.Show("Por favor, ingresa almenos 5 clientes :)");
                textBox1.Clear();
                textBox1.Focus();
            }
            else {
                cajero1.Start();
                cajero2.Start();
                cajero3.Start();
                cajero4.Start();
                validar.Start();
            }
        }

        private void cajero1_Tick(object sender, EventArgs e)
        {
            
            compa1();
            if (contador_clientes <= 0)
            {
                compa1();
                promedio1();

                cajero1.Stop();
            }
            if (compararseg1 >= 10)
            {
                compa1();
                atendidos2++;
                total2.Text = Convert.ToString(atendidos2);
                compararseg2 = -1;
                x.cPop(); compa1();
                contador_clientes--;
                string add = Convert.ToString(contador_clientes);
                labelcontador.Text = add;
            }

            compa1();

            compararseg1++;
            tiempocajero1.Text = Convert.ToString(compararseg1);
            cajero.atender1(); compa1();
            if (cajero.t1 == compararseg1)
            {
                atendidos1++; compa1();
                total1.Text = Convert.ToString(atendidos1);
                compararseg1 = -1;
                compa1();


                if (x.cInicio.cEnlace == null)
                {
                    cajero1.Stop();
                }
                try
                {

              
                if (x.cInicio.cEnlace != null)
                {
                    if (contador_clientes == 0)
                    {
                        promedio1(); compa1();

                        cajero1.Stop();

                    }
                    compa1();
                    x.cPop();
                    contador_clientes--;
                    string add = Convert.ToString(contador_clientes);
                    labelcontador.Text = add;
                    compa1();
                }
                else
                {
                    promedio1();

                    compa1();
                    cajero1.Stop();

                }
            }
                catch
                {

                }
            }

            if (compararseg1 >= 10)
            {

                atendidos2++;
                total2.Text = Convert.ToString(atendidos2);
                compararseg2 = -1;
                x.cPop();
                contador_clientes--;
                string add = Convert.ToString(contador_clientes);
                labelcontador.Text = add;
            }

            segundoscajero1++;


        }

        private void cajero2_Tick(object sender, EventArgs e)
        {
           
            compa2();
            if (contador_clientes <= 0)
            {
                compa2();
                promedio2();
                cajero2.Stop();
            }
            compararseg2++;
            tiempocajero2.Text = Convert.ToString(compararseg2);
            cajero.atender2(); compa2();
            if (cajero.t2 == compararseg2)
            {
                compa2();
                atendidos2++;
                total2.Text = Convert.ToString(atendidos2);
                compararseg2 = -1;
                if (contador_clientes <= 0)
                {
                    compa2();
                    promedio2();
                    cajero2.Stop();
                }
                if (contador_clientes <= 0)
                {
                    compa2();
                    promedio2();
                    cajero2.Stop();
                }

                if (x.cInicio.cEnlace == null)
                {
                    cajero2.Stop();
                }
                try
                {
                    if (x.cInicio.cEnlace != null)
                    {
                        if (contador_clientes == 0)
                        {
                            compa2();

                            promedio2();


                            cajero2.Stop();
                            compa2();
                        }
                        x.cPop(); compa2();
                        contador_clientes--;
                        string add = Convert.ToString(contador_clientes);
                        labelcontador.Text = add;
                    }
                    else
                    {
                        compa2();
                        promedio2();


                        cajero2.Stop();

                    }
                }
                catch
                {

                }
                compa2();

            }

            if (compararseg2 == 10)
            {

                atendidos2++;
                total2.Text = Convert.ToString(atendidos2);
                compararseg2 = -1;
                x.cPop();
                contador_clientes--;
                string add = Convert.ToString(contador_clientes);
                labelcontador.Text = add;
            }
            segundoscajero2++;
            compa2();
        }

        private void cajero4_Tick(object sender, EventArgs e)
        {
         
            compa4();
            total4.Text = Convert.ToString(atendidos4);
            if (contador_clientes <= 0)
            {
                promedio4();
                cajero4.Stop();
            }


            if (compararseg4 >= 10)
            {

                atendidos4++;
                total4.Text = Convert.ToString(atendidos4);
                compararseg4 = -1;
                x.cPop();
                contador_clientes--;
                string add = Convert.ToString(contador_clientes);
                labelcontador.Text = add;
            }

            compararseg4++;
            tiempocajero4.Text = Convert.ToString(compararseg4);
            cajero.atender4();
            if (x.cInicio.cEnlace == null)
            {
                cajero4.Stop();
            }
            if (contador_clientes <= 0)
            {
                promedio4();
                cajero4.Stop();
            }
            if (cajero.t4 == compararseg4)
            {
                atendidos4++;
                total3.Text = Convert.ToString(atendidos4);
                compararseg4 = -1;
                try
                {

                
                if (x.cInicio.cEnlace != null)
                {
                    if (contador_clientes == 0)
                    {

                        promedio4();

                        cajero4.Stop();

                    }
                    x.cPop();
                    contador_clientes--;
                    string add = Convert.ToString(contador_clientes);
                    labelcontador.Text = add;
                }
                else
                {

                    promedio4();

                    cajero4.Stop();

                }

                }
                catch
                {

                }
            }



            segundoscajero4++;
            compa4();
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            if (textBox1.Text == "")
            {
                MessageBox.Show("No Puede ingresar Nodos Sin valor");
                textBox1.Clear();
                textBox1.Focus();
            }
            else if ((int.Parse(textBox1.Text) > 0))
            {



                x.cPush(int.Parse(textBox1.Text));
                contador_clientes++;
                string add = Convert.ToString(contador_clientes);
                labelcontador.Text = add;
                textBox1.Clear();
                textBox1.Focus();
                button2.Enabled = true;

            }
            else
            {

                MessageBox.Show("No Puede ingresar Nodos Sin valor");
                textBox1.Clear();
                textBox1.Focus();
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            compa3();
            if (contador_clientes <= 0)
            {
                promedio3();
                cajero3.Stop(); compa3();
            }
            compararseg3++;
            tiempocajero3.Text = Convert.ToString(compararseg3);
            cajero.atender3();
            if (cajero.t3 == compararseg3)
            {
                compa3();
                atendidos3++;
                total3.Text = Convert.ToString(atendidos3);
                compararseg3 = -1;
                if (contador_clientes <= 0)
                {
                    compa3();
                    promedio3();
                    cajero3.Stop();
                }
                if (contador_clientes <= 0)
                {
                    compa3();
                    promedio3();
                    cajero3.Stop();
                }
                if (x.cInicio.cEnlace == null)
                {
                    cajero3.Stop();
                }

                try
                {

                
                    if (x.cInicio.cEnlace != null)
                {
                    if (contador_clientes == 0)
                    {
                        compa3();
                        promedio3();
                        
                        cajero3.Stop();

                    }
                    compa3();
                    x.cPop();
                    contador_clientes--;
                    string add = Convert.ToString(contador_clientes);
                    labelcontador.Text = add;
                    total3.Text = Convert.ToString(atendidos3);
                }
                else
                {
                    compa3();
                    promedio3();
                    
                    cajero3.Stop();
                   
                }
                }
                catch
                {

                }

            }

            if (compararseg3 >= 10)
            {
                compa3();
                atendidos3++;
                total3.Text = Convert.ToString(atendidos3);
                compararseg3 = -1;
                x.cPop();
                contador_clientes--;
                string add = Convert.ToString(contador_clientes);
                labelcontador.Text = add;
            }

            segundoscajero3++;
            compa3();
        }

        private void validar_Tick(object sender, EventArgs e)
        {
            if (contador_clientes<= 0)
            {
                button3.Enabled = true;
            }
           

        }

        public void promedio1()
        {
            cajero1.Stop();
            segtotal1.Text = Convert.ToString(segundoscajero1);
            double promedio = Convert.ToDouble(segundoscajero1 / atendidos1);
            prome1.Text = Convert.ToString(promedio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            promedio1();
            promedio2();
            promedio3();
            promedio4();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            promedio1();
            promedio2();
            promedio3();
            promedio4();
        }

        public void promedio2()
        {
            cajero2.Stop();
            segtotal2.Text = Convert.ToString(segundoscajero2);
            double promedio = Convert.ToDouble(segundoscajero2 / atendidos2);
            prome2.Text = Convert.ToString(promedio);
        }

        public void promedio3()
        {
            cajero3.Stop();
            segtotal3.Text = Convert.ToString(segundoscajero3);
            double promedio = Convert.ToDouble(segundoscajero3 / atendidos3);
            prome3.Text = Convert.ToString(promedio);
        }

        public void promedio4()
        {
            cajero4.Stop();
            segtotal4.Text = Convert.ToString (segundoscajero4 );
            double promedio = Convert.ToDouble(segundoscajero4 / atendidos4);
            prome4.Text = Convert.ToString(promedio);
        }



        public void compa1()
        {
            if (contador_clientes <= 0)
            {
                cajero1.Stop();
            }
        }

        public void compa2()
        {
            if (contador_clientes <= 0)
            {
                cajero2.Stop();
            }
        }

        public void compa3()
        {
            if (contador_clientes <= 0)
            {
                cajero3.Stop();
            }
        }
        public void nodonel()
        {
            
        }
        public void compa4()
        {
            if (contador_clientes <= 0)
            {
                cajero4.Stop();
            }
        }

    }
}
