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
   class pilas
    {
        public int maximo;
        public int cima;
        public int[] lapila;
        public pilas ()
        {

        }
        public pilas(int max)
        {
           
            lapila = new int[max];
            maximo = max;
            cima = -1;
        }

        public Boolean pila_llena()
        {
            if (cima == maximo - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 


        public Boolean pila_vacia ()
        {
            if (cima == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //push

        public void push(int n)
        {
            if (pila_llena ()==true )
            {
                MessageBox.Show("Pila Llena");
            }
            else
            {
                cima++;
                lapila[cima] = n;

            }
            
        }
        public int pop()
        {
            int n = 0;
            if (pila_vacia()==true )
            {
                MessageBox.Show("pila vacia");
                return n;
            }
                else
            {
                n = lapila[cima];
                cima--;
                return n;
            }
        }    
    }
}
