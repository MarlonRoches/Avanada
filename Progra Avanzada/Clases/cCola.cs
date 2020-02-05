using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winColaPA18
{

    struct sInformacion
    {
        public int iCarnet;
        public String sNombre;
    }

    class cNodo
    {
        public sInformacion sData;
        public cNodo cEnlace;
    }

    class cCola
    {
        cNodo cInicio;
        cNodo cFinal;

        public cCola()
        { 
            cInicio = null;
            cFinal = null;
        }

        public void cPush(sInformacion sDataIngresa)
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

        public sInformacion cPop()
        {
            sInformacion cDataRegresa = new sInformacion();

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
                        if (cAux.sData.iCarnet == cAuxRecorre.cEnlace.sData.iCarnet)
                        {
                            cAuxRecorre.cEnlace = cAuxRecorre.cEnlace.cEnlace;
                        }

                    }
                    cAuxRecorre = cAuxRecorre.cEnlace;
                } // while compara
                
                cAux = cAux.cEnlace;
            } // while principal
        }


    }


}
