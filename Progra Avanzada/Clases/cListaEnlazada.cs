using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinListaSimplePA18
{

    public struct  sInformacion    //daros en estructura
    {
        public int iCodigo;
        public String sMarca;
        String sModelo;
        Double dPrecio;
        int iExistencia;
    }

    class cNodo //clase nodo
    {
        public sInformacion Elemento;
        public cNodo nSiguiente;
    }

    class cListaEnlazada
    {
        cNodo nRaiz; //declaramos una raiz 

        public  cListaEnlazada()  //constructor de la clase
        {
            nRaiz = null; //cuando se inicia, la raiz es nula
        }

        public void pInserta(sInformacion sData)  //metodos de insertar
        {

            cNodo cAux = new cNodo(); //declaramos el auxiliar 
            cAux.Elemento = sData; // los datos se asignan al nodo
            cAux.nSiguiente = null; //apuntador = nulo

            if (this.nRaiz == null) //si la raiz apinta a nulo
            {
                nRaiz = cAux; //el auxiliar se vuelve la raiz
            }
            else
            {

                // buscar posición para insertar

                cNodo cAuxRecorre = new cNodo(); //delarar nuevo nodo para recorrer

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
