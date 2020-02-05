using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tarea4_MarlonRoches_1250918
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int cabezax = 0;// punto x de la cabeza de la serpiente
            int cabezay = 0;// punto y de la cabeza de la serpiente
            int colax = 0;// punto x cola
            int colay = 0;//punto y cola
                          //posibles movimientos
            bool izquierda = true;
            bool derecha = false;
            bool arriba = true;
            bool abajo = true;
            try
            {
                double ejex = 0;// longitud
                double ejey = 0;//largo
                Console.WriteLine("Escriba en el punto x");
                cabezax = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba en el punto y");
                cabezay = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el limite en eje x");
                ejex = double.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el limite en Y");
                ejey = double.Parse(Console.ReadLine());
                colax = cabezax + 4;//cola hacia la derecha
                colay = cabezay;// cola horizontal a la cabeza
                Console.WriteLine("Coordenada cabeza ( " + cabezax + " , " + cabezay + (")"));
                Console.WriteLine("Coordenada cola ( " + colax + " , " + colay + (")"));
                while (cabezax != ejex && cabezax != -ejex && cabezay != ejey && cabezay != -ejey)//marco en los 4 cuadrantes
                {
                    ConsoleKey comando = Console.ReadKey().Key;
                    switch (comando)
                    {
                        case ConsoleKey.LeftArrow://movimiento izquierda
                            if (izquierda == true)
                            {
                                cabezax = cabezax - 1;
                                izquierda = true;
                                derecha = false;
                                arriba = true;
                                abajo = true;
                                if (cabezay == colay)//cola se mueve para la izquierda en x
                                {
                                    colax = colax - 1;
                                }
                                else
                                {
                                    if (cabezay > colay)
                                    {
                                        colax = colax - 1;
                                    }
                                    else
                                    {
                                        colax = colax + 1;
                                    }
                                }//else
                            }//if
                            else//retroceso
                            {
                                Console.WriteLine("No fue poosible el movimiento, intentelo de nuevo");
                            }
                            Console.WriteLine("Coordenada Cabeza  " + "(" + cabezax + "," + cabezay + ")");
                            Console.WriteLine("Coordenada Cola " + "(" + colax + "," + colay + ")");
                            comando = 0;
                            break;
                        case ConsoleKey.DownArrow: //movimiento abajo
                            if (abajo == true)
                            {
                                cabezay = cabezay - 1;
                                izquierda = true;
                                derecha = true;
                                arriba = false;
                                abajo = true;
                                if (cabezax == colax)
                                {
                                    colay = colay - 1;
                                }
                                else
                                {
                                    if (cabezax > colax)
                                    {
                                        colax = colax + 1;
                                    }
                                    else
                                    {
                                        colax = colax - 1;
                                    }
                                }//else
                            }//if
                            else//retroceso
                            {
                                Console.WriteLine("No fue poosible el movimiento, intentelo de nuevo");
                                Console.Write("");
                            }
                            Console.WriteLine("Coordenada cabeza ( " + cabezax + " , " + cabezay + (")"));
                            Console.WriteLine("Coordenada Cola" + "(" + colax + "," + colay + ")");
                            comando = 0;
                            break;
                        case ConsoleKey.RightArrow://movimiento derecha
                            if (derecha == true)
                            {
                                izquierda = false;
                                derecha = true;
                                arriba = true;
                                abajo = true;
                                cabezax = cabezax + 1;//suma uno en el x de la cabeza
                                if (cabezay == colay)
                                {
                                    colax = colax + 1;
                                }
                                else
                                {
                                    if (cabezay > colay)
                                    {
                                        colax = colax - 1;
                                    }
                                    else
                                    {
                                        colax = colax - 1;
                                    }
                                }//else
                            }//if
                            else//retroceso
                            {
                                Console.WriteLine("No fue poosible el movimiento, intentelo de nuevo");
                                Console.Write("");
                            }
                            Console.WriteLine("Coordenada Cabeza  " + "(" + cabezax + "," + cabezay + ")");
                            Console.WriteLine("Coordenada Cola " + "(" + colax + "," + colay + ")");
                            Console.ReadKey();
                            comando = 0;
                            break;
                        case ConsoleKey.UpArrow: //movimiento arriba
                            if (arriba == true)
                            {
                                cabezay = cabezay + 1;
                                izquierda = true;
                                derecha = true;
                                arriba = true;
                                abajo = false;
                                cabezax = cabezax + 0;
                                if (cabezax == colax)
                                {
                                    colay = colay + 1;
                                }
                                else
                                {
                                    if (cabezax > colax)
                                    {
                                        colax = colax + 1;
                                    }
                                    else
                                    {
                                        colax = colax - 1;
                                    }
                                }//else
                            }//if
                            else//retroceso
                            {
                                Console.WriteLine("No fue poosible el movimiento, intentelo de nuevo");
                                Console.Write("");
                            }
                            Console.WriteLine("Cooordenada cabeza ( " + cabezax + " , " + cabezay + (")"));
                            Console.WriteLine("Coordenada Cola" + "(" + colax + "," + colay + ")");
                            comando = 0;
                            break;

                        case ConsoleKey.X:

                            Console.WriteLine("el juego terminó");
                            Console.WriteLine("La serpiente murió");

                            Console.ReadKey();
                            Console.WriteLine("    ");
                            System.Environment.Exit(-1);
                            break;

                        default:
                            Console.WriteLine("Presione una tecla valida, Cualquier felcha para avanzar y " + "X" + " para salir");
                            break;

                    }//switch
                }//while


            }//try
            catch
            {
                Console.WriteLine("No ingreso un número valido");
                Console.ReadKey();
            }

        }
    }
}
