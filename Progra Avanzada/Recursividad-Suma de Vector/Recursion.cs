using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad_Suma_de_Vector
{
    public class Recursion
    {
        int resultado = 0;
        int posicionNueva = 0;
        string Cadenanueva = "";
        int NumeroNuevo = 0; 
 
        public int Recursividad(int[] array, int posicion )
        {
            posicionNueva = posicion - 1; //Se determina la posicion que va a realizar dentro del arreglo

            if (posicionNueva == 0)//
            {
                return array[posicionNueva];
            }
            else
            {
                resultado = array[posicionNueva] + Recursividad(array, posicionNueva);
            }
            return resultado; 
        }

        public string Recursividad2( string cadena , int posicion )
        {
            posicionNueva = posicion -1;

            if (posicionNueva == 0)
            {
                return  Convert.ToString(cadena[posicionNueva]);
            }
            else
            {
                Cadenanueva = cadena[posicionNueva] + Recursividad2(cadena, posicionNueva);
            }
            return Cadenanueva; 

        }

        public int Recursividad3( int numero )
            {
            NumeroNuevo = numero - 1; 

            if (numero == 1)
            {
                return numero;
            }
            else
            {
                resultado = numero * Recursividad3(NumeroNuevo);
            }
            return resultado; 
            }

        }

    }

