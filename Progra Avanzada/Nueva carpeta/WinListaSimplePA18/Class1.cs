
using System;

public class Class1
{
    struct sInformacion
    {
        public int iCarnet;
        public string sNombre;
            }
class cNodo
    {
       public  sInformacion sData;
        public cNodo cEnlace;
    }

	public Class1()
	{
       public cNodo cInicio;
    public cNodo cFinal;

        void cCola()
        {
            cInicio = null;
            cFinal = null;
        }
        void cPush(sInformacion sDataIngresa)
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


        sInformacion cPop()
        {

            sInformacion cDataRegresa;
            if (cInicio !=null)
                {
                cDaraRegresa = cInicio.sData;
                cInicio = cInicio.cEnlace;
            }
          
            
            return cDaraRegresa = cInicio.sData;
        }

        void Purge()
        {
            cNodo cAux = new cNodo();
            cAux = cInicio;
            cNodo cAuxRecorre = new cNodo();

            cAuxRecorre = cInicio.cEnlace;
        while (cAux.cEnlace !=null)
        {


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
        }
            cAux = cAux.cEnlace;
            
        }
    }


}



       }
	}
}
