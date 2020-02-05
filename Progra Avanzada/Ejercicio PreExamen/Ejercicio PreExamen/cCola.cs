using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_PreExamen
{

    
     
  
    class cNodo
    {
        public int sData;
        public cNodo cEnlace;
    }

     class cCola
    {
       public  cNodo cInicio;
        public cNodo cFinal;

        public cCola()
        {
            cInicio = null;
            cFinal = null;
        }

        public void cPush(int sDataIngresa)
        {
            cNodo cAux = new cNodo();
            cAux.sData = sDataIngresa;
            cAux.cEnlace = null;

            if (cFinal == null)
            {
                cFinal = cAux;
                cInicio = cAux;
            }
            else
            {
                cFinal.cEnlace = cAux;
                cFinal = cAux;
            }
        }

        public int cPop()
        {
            int cDataRegresa = new int();

            if (cInicio != null)
            {
                cDataRegresa = cInicio.sData;
                cInicio = cInicio.cEnlace;
            }
            return cDataRegresa;
        }

        public void Purge()
        {
            cNodo cAux = new cNodo();
            cAux = cInicio;

            while (cAux.cEnlace != null)
            {

                cNodo cAuxRecorre = new cNodo();

                cAuxRecorre = cAux;

                while (cAuxRecorre != null)
                {
                    if (cAuxRecorre.cEnlace != null)
                    {
                        if (cAux.sData == cAuxRecorre.cEnlace.sData)
                        {
                            cAuxRecorre.cEnlace = cAuxRecorre.cEnlace.cEnlace;
                        }


                        cAuxRecorre = cAuxRecorre.cEnlace;
                    } // while compara

                    cAux = cAux.cEnlace;
                } // while principal
            }


        }

    }
}
