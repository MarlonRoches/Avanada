using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nodos_Yo
{
     class Agregar_A_Lista
    {
        public Nodo primero = new Nodo();
        public Nodo ultimo = new Nodo();

        public Agregar_A_Lista() //inicializa con los nodos en null  //  CONSTRUCTOR
        {
            primero = null;
            ultimo = null;
        }
        
        public void InsertarNodo(int dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato  = dato;
            if (primero == null)
            {
                primero = nuevo;
                primero.siguiente = null;
                ultimo = primero;
               
            }

            else
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = null;
                ultimo = nuevo;

            }
        }
    }
}
