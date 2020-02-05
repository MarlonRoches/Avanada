using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinListaSimplePA18
{
    class Colas
    {
        private int frente;
        private int atras;

        public int[] lacola;
        private int maximo;
        public Colas() { }
        public Colas(int max )
        {
            frente = -1;
            atras = -1;
            maximo = max;
            lacola = new int[maximo];

        }

        public bool cola_llena()
        {
            if (atras == maximo -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool cola_vacia()
        {
            if (frente == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void  agregar_cola(int n)
        {
            if (cola_llena() == true )
            {
                MessageBox.Show("Cola Llena");

            }
            else
            {
                atras++;
                lacola[atras] = n;
                if (atras == 0 )
                {
                    frente = 0;
                }
            }

            
        }
        public int del_cola()
        {
            int n = -666;
            if (cola_vacia() == true)
            {
                MessageBox.Show("Cola Vacia");
                  
            }
            else
            {
                n = lacola[frente];
                if (frente == atras )
                {
                    frente = -1;
                    atras = -1;
                }
                 else
                {
                    frente++;

                }
            }
            return n;
        }

    }
}
