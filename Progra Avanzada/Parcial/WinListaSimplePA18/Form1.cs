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
       
        pilas objeto = new pilas();
        Colas x = new Colas();
    
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Random rNum = new Random(DateTime.Now.Millisecond);



        private void btncrear2_Click(object sender, EventArgs e)
        {

            x = new Colas(101);
            MessageBox.Show("Se Creo La Cola");

           




            for (int i = 0; i < 101; i++)
            {
                data.Columns.Add(i.ToString(), i.ToString());
                data.Rows.Add(1);
            }

            for (int i = 0; i <101; i++) //llenando la cola
            {
                for (int j = 0; j < 1; j++)
                {
                    x.lacola[i] = rNum.Next(1, 100); //limitante
                    data.Rows[i].Cells[j].Value = x.lacola[i];






            switch (x.lacola[i])
            {

                case 1:
                    data.Rows[i].Cells[j].Value = "";
                    break;

                case 2:
                
                    
                    
                   
                        data.Rows[i].Cells[j].Style.BackColor = Color.Red;
                   
                    break;

              
                   
            }
                }
            }

        }
             private void agregar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtnumero2.Text);
            x.agregar_cola(n);
           
            txtnumero2.Clear();
            txtnumero2.Focus();

            data.Rows[0].Cells[0].Value = Convert.ToInt32(txtnumero2.Text);


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
