using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int limite = 4, nnegro = 0, nblanco = 0, x = 8, y = 8;
        Random rNum = new Random(DateTime.Now.Millisecond);
        int iCaballo = 0;
        int[,] matriz = new int[8, 8];



        public void Form1_Load(object sender, EventArgs e)
        {
            
            

            for (int i = 0; i < 8; i++)
            {
                data.Columns.Add(i.ToString(), i.ToString());
                data.Rows.Add(1);
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matriz[i, j] = rnumero.Next(1, limite); //limitante
                    data.Rows[i].Cells[j].Value = matriz[i, j];

                    //if (matriz[i, j] == 1 && iCaballo < 2)
                    //{
                    //    int caballo = rNum.Next(1, 100) % 2;
                    //    if (caballo == 1)
                    //    {
                    //        matriz[4, 4] = 4;
                    //        data.Rows[4].Cells[4].Value = "C";

                    //matriz[5, 5] = 4;
                    //data.Rows[5].Cells[5].Value = "C";
                    ////        iCaballo++;
                    //    }
                    //}

                    switch (matriz[i, j])
                    {

                        case 1:
                            data.Rows[i].Cells[j].Value = "";
                            break;

                        case 2:
                            nnegro++;
                            //NEGROS
                            data.Rows[i].Cells[j].Value = "N" + Convert.ToString(nnegro);
                            data.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            if (i == 0)
                            {
                                data.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            }


                            //if ((i >-1 && i < 8) && (j >-1 && j > 8))
                            //{

                            //    if (matriz[i, j--] == 1)
                            //    {
                            //        //dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Green;

                            //    }

                            //    if (matriz[i, j--] == 3)
                            //    {
                            //        //dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            //    }

                            //    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                            //}






                            break;

                        case 3:
                            //BLANCOS
                            nblanco++;
                            x = i;
                            y = j;
                            data.Rows[i].Cells[j].Value = "B" + Convert.ToString(nblanco);
                            data.Rows[i].Cells[j].Style.ForeColor = Color.White ;
                            if (x == 7)
                            {
                                data.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            }
                           
                            data.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            break;
                        case 4:




                            if (i>1)
                            {
                                if (j > 1)
                                {
                                    data.Rows[i - 2].Cells[j - 1].Style.BackColor = Color.Brown;
                                    data.Rows[i - 2].Cells[j + 1].Style.ForeColor = Color.White;
                                }

                                if (j < 8)
                                {
                                    data.Rows[i - 2].Cells[j - 1].Style.BackColor = Color.Brown;
                                    data.Rows[i - 2].Cells[j + 1].Style.ForeColor = Color.White;
                                }
                            }





                            if (i <8)
                            {
                                if (j > 1)
                                {
                                    data.Rows[i - 2].Cells[j - 1].Style.BackColor = Color.Brown;
                                    data.Rows[i + 2].Cells[j + 1].Style.ForeColor = Color.White;
                                }

                                if (j < 8)
                                {
                                    data.Rows[i - 2].Cells[j - 1].Style.BackColor = Color.Brown;
                                    data.Rows[i + 2].Cells[j + 1].Style.ForeColor = Color.White;
                                }
                            }

                            if (j > 1)
                            {
                                if (i > 1)
                                {
                                    data.Rows[i - 2].Cells[j - 1].Style.BackColor = Color.Brown;
                                    data.Rows[i + 2].Cells[j - 1].Style.ForeColor = Color.White;
                                }

                                if (i <8)
                                {
                                    data.Rows[i - 2].Cells[j - 1].Style.BackColor = Color.Brown;
                                    data.Rows[i + 2].Cells[j - 1].Style.ForeColor = Color.White;
                                }
                            }

                            if (j < 8)
                            {
                                if (i > 1)
                                {
                                    data.Rows[i - 2].Cells[j + 1].Style.BackColor = Color.Brown;
                                    data.Rows[i + 2].Cells[j + 1].Style.ForeColor = Color.White;
                                }

                                if (i < 8)
                                {
                                    data.Rows[i - 2].Cells[j + 1].Style.BackColor = Color.Brown;
                                    data.Rows[i + 2].Cells[j + 1].Style.ForeColor = Color.White;
                                }
                            }






                            break;
                    }

                }
            }

            //for (int i = 0; i < tamaño; i++)
            //{
            //    for (int j = 0; j < tamaño; j++)
            //    {
            //        if (tamañ)
            //        {

            //        }


            //    }
            //}


        }

        Random rnumero = new Random(DateTime.Now.Millisecond);
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


       


        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    

                }
            }
           
        }
            


    }
}
    

