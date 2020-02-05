using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winExP1PA18
{
    struct sInformacion
    {
        public int iValor;
        public String sDesc;
        public bool bPrimo;
        public bool bNuevo;
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
        int iElementos;

        public cCola()
        {
            cInicio = null;
            cFinal = null;
            iElementos = 0;
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
            iElementos++;
        }

        public sInformacion cPop()
        {
            sInformacion cDataRegresa = new sInformacion();

            if (cInicio != null)
            {
                cDataRegresa = cInicio.sData;
                cInicio = cInicio.cEnlace;
            }
            iElementos--;
            return cDataRegresa;
        }

        

        public int ColaStatus()
        {
            if (iElementos == 0)
                return 1; // vacia
            else
                return 2; // si tiene elementos
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
                        if (cAux.sData.iValor == cAuxRecorre.cEnlace.sData.iValor)
                        {
                            cAuxRecorre.cEnlace = cAuxRecorre.cEnlace.cEnlace;
                        }

                    }
                    cAuxRecorre = cAuxRecorre.cEnlace;
                } // while compara

                cAux = cAux.cEnlace;
            } // while principal
        }


        bool esPrimo(int iNum)
        {
            int i, a = 0;

            for (i = 1; i < (iNum + 1); i++)
            {
                if (iNum % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void InsertaPrimo()
        { 
            // recorrer de inicio a fin la cola

            cNodo cAux = new cNodo();

            cAux = cInicio;

            while (cAux.cEnlace != null)
            {
                // validar si es primo o no ( guardar )
                if (  esPrimo(cAux.sData.iValor) == true)
                {
                    // si es primo insertar un elemento con valor = valor actual * valor siguiente
                    cAux.sData.bPrimo = true;

                    cNodo cAuxNuevo = new cNodo();
                    cAuxNuevo.sData.bNuevo = true;

                    if (cAux.cEnlace != null)
                        cAuxNuevo.sData.iValor = cAux.sData.iValor * cAux.cEnlace.sData.iValor;
                    else
                        cAuxNuevo.sData.iValor = -1;

                    cAuxNuevo.cEnlace = cAux.cEnlace;
                    cAux.cEnlace = cAuxNuevo;

                }



                cAux = cAux.cEnlace;
            }


            
            

        }

    }

}
