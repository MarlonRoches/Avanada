using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_PreExamen
{
    public class Cajero
    {
        //Form1 l = new Form1();
        cCola x = new cCola();
        public int t1 = 0, t2 = 0, t3 = 0, t4 = 0;
      public  Cajero ()
        {

        }
        
        Random tAtender = new Random(DateTime.Now.Millisecond);

        
        public void atender1()
        {
            t1 = tAtender.Next(5, 9);



            //while (x.cInicio .cEnlace != null)
            //{
            //    tAtender.Next(5, 11);
            //    int t = Convert.ToInt32(tAtender);


            //    if (t == l.compararseg1)
            //    {
            //        l.segundoscajero1 = Convert.ToInt32(tAtender);
            //        l.atendidos1++;
            //        x.cPop();
            //        l.tiempocajero1.Text = Convert.ToString(l.segundoscajero1);
            //        l.total1.Text = Convert.ToString(l.atendidos1);
            //    }
            //    else
            //    {

            //    }

            //    l.promedio1();

            //}


        }

        public void atender2()
        {

            t2= tAtender.Next(5, 9);


            


        }



        public void atender3()
        {

            t3 = tAtender.Next(5, 9);


        }

        public void atender4()
        {
            t4 = tAtender.Next(5, 9);


        }

    }
}
