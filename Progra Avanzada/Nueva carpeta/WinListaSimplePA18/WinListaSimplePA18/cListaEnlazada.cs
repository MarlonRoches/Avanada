using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinListaSimplePA18
{

    public struct  sInformacion
    {
        public int iCodigo;
        public String sMarca;
        String sModelo;
        Double dPrecio;
        int iExistencia;
    }

    class cNodo
    {
        public sInformacion Elemento;
        public cNodo nSiguiente;
    }

    class cListaEnlazada
    {
        cNodo nRaiz;

        public  cListaEnlazada()
        {
            this.nRaiz = null;
        }


        public void pInsertaOrdenado(sInformacion sData)
        {
            cNodo cAux = new cNodo();
            cAux.Elemento = sData;
            cAux.nSiguiente = null;
            //if (this.nRaiz =)
            //{

            //}
        }

        public void pInserta(sInformacion sData)
        {

            cNodo cAux = new cNodo();
            cAux.Elemento = sData;
            cAux.nSiguiente = null;

            if (this.nRaiz == null)
            {
                nRaiz = cAux;
            }
            else
            {

                // buscar posición para insertar

                cNodo cAuxRecorre = new cNodo();
                
                cAuxRecorre = nRaiz;
                
                while (cAuxRecorre.nSiguiente != null)
                {

                    cAuxRecorre = cAuxRecorre.nSiguiente;
                }

                cAuxRecorre.nSiguiente = cAux;

            }
        }

    }

}
