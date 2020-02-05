using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Facebook
{
    

    class cNodo
    {
        public string sCorreo;
        public string sTipo;
        public string sImagen;
        public string sTexto;
        public cNodo cEnlace;
    }

    class dNodo
    {
        public string sCorreo;
        public string sMensaje;
        public string sFecha;
        public string sEstado;
        public string sRemitente;
        public dNodo cEnlace;
    }

    class cCola
    {
        cNodo cInicio;
        cNodo cFinal;

        dNodo dInicio;
        dNodo dFinal;
        int iElementos;

        public cCola()
        { 
            cInicio = null;
            cFinal = null;
            iElementos = 0;
        }


        public string[] cPush2(string[] campos)
        {//reibe como parametro string [] campos
            dNodo dAux = new dNodo();
            dAux.sCorreo = campos[0];
            dAux.sMensaje = campos[1];
            dAux.sFecha = campos[2];
            dAux.sEstado = campos[3];
            dAux.sRemitente = campos[4];
            dAux.cEnlace = null;

            if (cFinal == null)
            {
                dFinal = dAux;
                dInicio = dAux;
            }
            else
            {
                dFinal.cEnlace = dAux;
                dFinal = dAux;
            }
            iElementos++;
            return campos;
        }



        public string[] cPush(string[] campos)
        {//reibe como parametro string [] campos
            cNodo cAux = new cNodo();
            cAux.sCorreo  = campos[0];
            cAux.sTipo = campos[1];
            cAux.sImagen = campos[2];
            cAux.sTexto = campos[3];
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
            return campos;
        }

        //public string cPop()
        //{
        //    sInformacion cDataRegresa = new sInformacion();

        //    if (cInicio != null)
        //    {
        //        cDataRegresa = cInicio.sData;
        //        cInicio = cInicio.cEnlace;
        //    }
        //    iElementos--;
        //    return cDataRegresa;
        //}









    }

}
