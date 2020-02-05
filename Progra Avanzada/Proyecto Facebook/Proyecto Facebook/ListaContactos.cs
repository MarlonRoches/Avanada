using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Facebook
{ 

    public struct sInformacion    //daros en estructura
{
        public string id;
        public string nombres;
        public string apellidos;
        public string edad;
        public string cumpleaños;
        public string estado;
        
    }

class lNodo //clase nodo
{
    public sInformacion Elemento;
    public lNodo nSiguiente;
}

class cListaEnlazada
{
    lNodo nRaiz; //declaramos una raiz 

    public cListaEnlazada()  //constructor de la clase
    {
        nRaiz = null; //cuando se inicia, la raiz es nula
    }

    public void pInserta(string [] lData)  //metodos de insertar
    {

        lNodo cAux = new lNodo(); //declaramos el auxiliar 
            cAux.Elemento.id = lData[0];
            cAux.Elemento.nombres  = lData[1];
            cAux.Elemento.apellidos = lData[2];
            cAux.Elemento.edad = lData[3];
            cAux.Elemento.cumpleaños  = lData[4];
            cAux.Elemento.estado = lData[5];

            cAux.nSiguiente = null; //apuntador = nulo

        if (this.nRaiz == null) //si la raiz apinta a nulo
        {
            nRaiz = cAux; //el auxiliar se vuelve la raiz
        }
        else
        {

            // buscar posición para insertar

            lNodo cAuxRecorre = new lNodo(); //delarar nuevo nodo para recorrer

            cAuxRecorre = nRaiz; //se iguala el auxiliar que recorre a la raiz ? 

            while (cAuxRecorre.nSiguiente != null) //recorrer hasta el ultimo
            {

                cAuxRecorre = cAuxRecorre.nSiguiente; //recorre al siguiente
            }

            cAuxRecorre.nSiguiente = cAux; //el recorre se iguala al auxiliar

        }
    }

}

}
