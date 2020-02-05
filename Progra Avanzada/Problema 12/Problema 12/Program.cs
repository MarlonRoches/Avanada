using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12
{
    class MaxiSuper
    {
        public ColaItems Items;
        public MaxiSuper(ColaItems it)
        {
            Items = it;
        }
    }
    class NodoEnumerator : IEnumerator
    {
        Nodo Current;
        Nodo ap1;
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public NodoEnumerator(Nodo n)
        {
            Current = null;
            ap1 = n;
        }
        public bool MoveNext()
        {

            if (Current == null)
            {
                Current = ap1;
                return true;
            }

            if (Current.Next != null)
            {
                Current = Current.Next;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            Current = null;

        }
    }
    class Nodo
    {
        public Nodo Next;
        public object Value;

        public Nodo(object value, Nodo next)
        {
            Next = next;
            Value = value;
        }
    }
    class Stack : IEnumerable
    {
        private Nodo first = null;
        private int count = 0;
        private ArrayList presentacion = new ArrayList();

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Push(object o)
        {
            first = new Nodo(o, first);
            count++;
        }

        public object[] Arreglo()
        {
            object[] arr = new object[count];
            Nodo ap = first;
            int i;
            for (i = 0; i < count; i++)
            {
                arr[i] = ap.Value;
                ap = ap.Next;
            }
            return arr;
        }
        public IEnumerator GetEnumerator()
        {
            return (new NodoEnumerator(first));
        }
        public object Pop()
        {
            Nodo ap = first;
            Nodo ap1 = first.Next;

            object retorno = null;
            if (Count != 0)
            {
                if (first.Next == null)
                {
                    retorno = first.Value;
                    first.Value = null;
                }
                else
                {
                    while (ap1.Next != null)
                    {
                        ap1 = ap1.Next;
                        ap = ap.Next;

                    }
                    retorno = ap1.Value;
                    ap.Next = null;
                }
            }
            return retorno;
        }
    }
    class ColaItems : Queue, IComparer
    {
        public ColaItems()
            : base()
        { }

        int IComparer.Compare(Object x, Object y)
        {
            Item sx = (Item)x;
            Item sy = (Item)y;
            int retorno = 0;
            if (Convert.ToInt32(sx.Fecha_Elab.Substring(6)) > Convert.ToInt32(sy.Fecha_Elab.Substring(6))) retorno = -1;

            if (Convert.ToInt32(sx.Fecha_Elab.Substring(6)) < Convert.ToInt32(sy.Fecha_Elab.Substring(6))) retorno = 1;

            if (Convert.ToInt32(sx.Fecha_Elab.Substring(6)) == Convert.ToInt32(sy.Fecha_Elab.Substring(6)))
            {
                if (Convert.ToInt32(sx.Fecha_Elab.Substring(3, 2)) > Convert.ToInt32(sy.Fecha_Elab.Substring(3, 2))) retorno = -1;

                if (Convert.ToInt32(sx.Fecha_Elab.Substring(3, 2)) < Convert.ToInt32(sy.Fecha_Elab.Substring(3, 2))) retorno = 1;

                if (Convert.ToInt32(sx.Fecha_Elab.Substring(3, 2)) == Convert.ToInt32(sy.Fecha_Elab.Substring(3, 2)))
                {
                    if (Convert.ToInt32(sx.Fecha_Elab.Substring(0, 2)) > Convert.ToInt32(sy.Fecha_Elab.Substring(0, 2))) retorno = -1;
                    if (Convert.ToInt32(sx.Fecha_Elab.Substring(0, 2)) < Convert.ToInt32(sy.Fecha_Elab.Substring(0, 2))) retorno = 1;
                }
            }
            return retorno;
        }

        public override object Dequeue()
        {
            ArrayList ar = new ArrayList(ToArray());
            ar.Sort(this);
            Clear();
            object retorno = null;
            retorno = ar[0];
            ar.RemoveAt(0);
            foreach (Item it in ar)
                Enqueue(it);
            return retorno;
        }
    }
    struct Item
    {
        public string Nombre_Prod;
        public string Fecha_Elab;
        public Item(string nom, string fech)
        {
            Nombre_Prod = nom;
            Fecha_Elab = fech;
        }
        public override string ToString()
        {
            return "Nombre del Producto: " + Nombre_Prod + "\tFecha de Elaboración: " + Fecha_Elab.ToString();
        }
    }
    class Program
    {
        static Stack RecibirMercaderia(ColaItems prod)
        {

            Stack s = new Stack();
            for (int x = 0; x < prod.Count; )
            {
                object p = prod.Dequeue();
                s.Push((Item)p);
            }
            return s;
        }
        static void DesplegarItems(Stack s)
        {
            Console.WriteLine("Los Productos estan ordenados donde el primero en la lista, \nes el ultimo en la estantería\n ");
            for (int x = 0; x < s.Count; x++)
            {
                Console.WriteLine("{0} " + s.Pop().ToString(), x + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ColaItems Prod = new ColaItems();
            Prod.Enqueue(new Item("Chips", "08/10/2011"));
            Prod.Enqueue(new Item("Pelota", "21/05/2010"));
            Prod.Enqueue(new Item("Libro", "12/01/2011"));
            Prod.Enqueue(new Item("Chocolate", "15/03/2011"));
            Prod.Enqueue(new Item("Carne", "02/05/2011"));
            Prod.Enqueue(new Item("Queso", "26/12/2011"));
            Prod.Enqueue(new Item("Pastel", "27/12/2011"));
            MaxiSuper maxi = new MaxiSuper(Prod);
            Stack s = RecibirMercaderia(maxi.Items);
            DesplegarItems(s);
            Console.ReadKey();
        }
    }
}
