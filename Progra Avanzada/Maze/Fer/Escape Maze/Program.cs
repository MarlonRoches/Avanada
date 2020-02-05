using System;
namespace Escape_Maze
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Random numerosrandom = new Random(DateTime.Now.Millisecond);// variable random 
            Console.ForegroundColor = ConsoleColor.Black;//cambiamos colres
            Console.BackgroundColor = ConsoleColor.White;
            int vida = 20;
            int px = 0, py = 2;
            bool repetirciclo = true;
            int opc;
            string[,] matriz = new string[10, 10];

            do
            {

                Console.Clear();
               //ciclo para llenar con numeros aleatorios
                llenarmatriz();//mandamos a llamar al metodo que llenara el metodo y lo traducira
                Console.Clear();
                Console.WriteLine("Presione el número de la opción que desea ejecutar");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Generar otro tablero");
                Console.WriteLine("3. Salir");
                matriz[0, 2] = "<";

                matriz[9, 2] = ">";
                mostrarmapa();//mostramos el mapa con el metodo
                Console.WriteLine("");
                opc = Convert.ToInt32(Console.ReadLine());
                if (opc == 1)//si es 1, entrara al juego
                {
                    repetirciclo = false;
                }
                else if (opc ==3) //si es 3, saldra del entorno, es decir, terminara
                {
                    Environment.Exit(0);
                }
                else
                {
                    //si es u otro numero, no hara nada, entonces el ciclo se repetira hasta que elija salir o jugar
                }
            } while (repetirciclo == true);
            repetirciclo = true;
            matriz[0, 2] = "J";
            matriz[9, 2] = ">";
            ConsoleKey guardartecla;//declaramos una variable para guardar una tecla
            do
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Black;//cambiamos los colores
                Console.WriteLine("");
                guardartecla = 0;//hacemos ciclo a para que siempre se renueve
                Console.Clear();

                mostrarmapa();//mostramos mapa
                Console.WriteLine("");
                Console.WriteLine("Tecla Arriba moverse---------->hacia arriba");
                Console.WriteLine("Tecla Abajo moverse----------->hacia abajo");
                Console.WriteLine("Tecla Izquiera moverse-------->hacia la izquierda");
                Console.WriteLine("Tecla Derecha moverse--------->hacia la derecha");
                guardartecla = Console.ReadKey().Key;//leemos la ecta que presionmos y la guardamos en la variable de su mismo tipo
                
                switch (guardartecla)//hacemos switch entre las teclas que guardamos
                {
                    case ConsoleKey.LeftArrow:

                        if (px == 0)//si esta en el limite, es decir 0 o tamaño tablero -1, no podra salir
                        {
                            Console.WriteLine("No puedes salirte del mapa");
                            px = 0;
                        }
                        else
                        {

                            if (matriz[px - 1, py] == "#")//si hay una pared, esta l quitara una vida y no lo dejara pasar
                            {
                                Console.WriteLine("Salud -1");
                                vida--;
                            }
                            else
                            {// si no se cumple lo de la pared y todo esta bien, 
                             //seguira a la posicion en la cual la flecha fue seleccionada
                                matriz[px, py] = " ";
                                px--;
                            }
                        }
                        Console.WriteLine("Posicion [" + px + " , " + py + "]");//imprimimos posicion actual
                        Console.ForegroundColor = ConsoleColor.Red;
                        matriz[px, py] = "J";//imprimimos al jugador en la posicion actual
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        mostrarmapa();//imprimimos mapa

                        Console.WriteLine("Tecla Arriba");
                        Console.WriteLine("Tecla Abajo");
                        Console.WriteLine("Tecla Izquierda");
                        Console.WriteLine("Tecla Derecha"); Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("X para salir al menú");
                        break;
                    case ConsoleKey.RightArrow:
                        if (px == 9)
                        {
                            Console.WriteLine("No puedes salirte del mapa");
                        }
                        else
                        {
                            if (matriz[px + 1, py] == "#")
                            {
                                Console.WriteLine("Salud -1");


                                vida--;
                            }
                            else
                            {
                                matriz[px, py] = " ";
                                px++;
                            }
                        }
                        Console.WriteLine("Posicion [" + px + " , " + py + "]");
                        Console.ForegroundColor = ConsoleColor.Red;
                        matriz[px, py] = "J";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        mostrarmapa();

                        Console.WriteLine("Tecla Arriba");
                        Console.WriteLine("Tecla Abajo");
                        Console.WriteLine("Tecla Izquierda");
                        Console.WriteLine("Tecla Derecha"); Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("X para salir al menú");

                        break;
                    case ConsoleKey.UpArrow:
                        if (py == 0)
                        {
                            Console.WriteLine("No puedes salirte del mapa");
                            py = 0;
                        }
                        else
                        {
                            if (matriz[px, py - 1] == "#")
                            {
                                Console.WriteLine("Salud -1");


                                vida--;
                            }
                            else
                            {
                                matriz[px, py] = " ";
                                py--;
                            }
                        }
                        Console.WriteLine("Posicion  [" + px + " , " + py + "]");
                        Console.ForegroundColor = ConsoleColor.Red;
                        matriz[px, py] = "J";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        mostrarmapa();

                        Console.WriteLine("Tecla Arriba");
                        Console.WriteLine("Tecla Abajo");
                        Console.WriteLine("Tecla Izquierda");
                        Console.WriteLine("Tecla Derecha"); Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("S para salir al menú");
                        break;
                    case ConsoleKey.DownArrow://mover abajo
                        if (py == 9)
                        {
                            Console.WriteLine("No puedes salirte del mapa");
                            py = 9;
                        }
                        else
                        {

                            if (matriz[px, py + 1] == "#")
                            {
                                Console.WriteLine("Salud -1");
                                vida--;
                            }
                            else
                            {
                                matriz[px, py] = " ";
                                py++;
                            }
                        }
                        Console.WriteLine("Posicion [" + px + " , " + py + "]");
                        Console.ForegroundColor = ConsoleColor.Red;
                        matriz[px, py] = "J";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        mostrarmapa();

                        Console.WriteLine("");
                        Console.WriteLine("Tecla Arriba");
                        Console.WriteLine("Tecla Abajo");
                        Console.WriteLine("Tecla Izquierda");
                        Console.WriteLine("Tecla Derecha");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("S para salir al menú");
                        break;
                    case ConsoleKey.S: //si presiona S, saldra del ciclo y terminara el juego
                        repetirciclo = false;
                        break;
                }
                if (px == 9 && py == 2) // si esta en la posicion (9,2), es decir en la salida, el juego dira que gano y terminara
                {
                    Console.Clear();
                    Console.WriteLine("                             | HAZ GANADO |");
                    repetirciclo = false;//salir del juego por ganar
                }
                if (vida == 0) //si la vida es igual a 0, morirá
                {
                    repetirciclo = false;//salir del ciclo por muerte
                    Console.Clear();
                    Console.WriteLine("                             | HAZ MUERTO |");

                }
            } while (repetirciclo == true);
            Console.ForegroundColor = ConsoleColor.Black;// la letra se vuelve negra
            Console.WriteLine("                             | JUEGO TERMINADO |");
            Console.WriteLine(" ->Total salud restante: " + vida);
            Console.ReadLine();

            void llenarmatriz() // metodo llenar
            {
                for (int i = 0; i < 10; i++)//lenamos la amatriz con numeros aleatorios entre 0 y 100
                {
                    for (int j = 0; j < 10; j++)
                    {

                        matriz[i, j] = Convert.ToString(numerosrandom.Next(0, 101));// convertimos a string el numero aleatorio entre 0 y 100
                        
                    }
                }

                //traducir
                for (int i = 0; i < 10; i++)//traducimos la matris, es decir, lo pasamos de numeros a caracteres
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (Convert.ToInt32(matriz[i, j]) >= 70)
                        {
                            //si la matriz en la posicion (i,j) es mayor 70, sera una pared
                            matriz[i, j] = "#";
                        }
                        else if (Convert.ToInt32(matriz[i, j]) <= 69)
                        {//si la matriz en la posicion (i,j) es menor 70, sera un espacio
                            matriz[i, j] = "_";
                        }
                    }
                }
            }
            void mostrarmapa()

            {
                //mostramos todas las posiciones, como ya sabemos las dimensiones, podemos imprimir una por una y concatenarlas para mostrar algo parecido a un tablero
                Console.WriteLine("                 |" + " " + matriz[0, 0] + " " + matriz[1, 0] + " " + matriz[2, 0] + " " + matriz[3, 0] + " " + matriz[4, 0] + " " + matriz[5, 0] + " " + matriz[6, 0] + " " + matriz[7, 0] + " " + matriz[8, 0] + " " + matriz[9, 0] + " " + "|" + " " + "                   Salud: " + " " + vida);
                Console.WriteLine("                 |" + " " + matriz[0, 1] + " " + matriz[1, 1] + " " + matriz[2, 1] + " " + matriz[3, 1] + " " + matriz[4, 1] + " " + matriz[5, 1] + " " + matriz[6, 1] + " " + matriz[7, 1] + " " + matriz[8, 1] + " " + matriz[9, 1] + " " + "|");
                Console.WriteLine("                  " + " " + matriz[0, 2] + " " + matriz[1, 2] + " " + matriz[2, 2] + " " + matriz[3, 2] + " " + matriz[4, 2] + " " + matriz[5, 2] + " " + matriz[6, 2] + " " + matriz[7, 2] + " " + matriz[8, 2] + " " + matriz[9, 2] + " " + " ");
                Console.WriteLine("                 |" + " " + matriz[0, 3] + " " + matriz[1, 3] + " " + matriz[2, 3] + " " + matriz[3, 3] + " " + matriz[4, 3] + " " + matriz[5, 3] + " " + matriz[6, 3] + " " + matriz[7, 3] + " " + matriz[8, 3] + " " + matriz[9, 3] + " " + "|");
                Console.WriteLine("                 |" + " " + matriz[0, 4] + " " + matriz[1, 4] + " " + matriz[2, 4] + " " + matriz[3, 4] + " " + matriz[4, 4] + " " + matriz[5, 4] + " " + matriz[6, 4] + " " + matriz[7, 4] + " " + matriz[8, 4] + " " + matriz[9, 4] + " " + "|");
                Console.WriteLine("                 |" + " " + matriz[0, 5] + " " + matriz[1, 5] + " " + matriz[2, 5] + " " + matriz[3, 5] + " " + matriz[4, 5] + " " + matriz[5, 5] + " " + matriz[6, 5] + " " + matriz[7, 5] + " " + matriz[8, 5] + " " + matriz[9, 5] + " " + "|");
                Console.WriteLine("                 |" + " " + matriz[0, 6] + " " + matriz[1, 6] + " " + matriz[2, 6] + " " + matriz[3, 6] + " " + matriz[4, 6] + " " + matriz[5, 6] + " " + matriz[6, 6] + " " + matriz[7, 6] + " " + matriz[8, 6] + " " + matriz[9, 6] + " " + "|");
                Console.WriteLine("                 |" + " " + matriz[0, 7] + " " + matriz[1, 7] + " " + matriz[2, 7] + " " + matriz[3, 7] + " " + matriz[4, 7] + " " + matriz[5, 7] + " " + matriz[6, 7] + " " + matriz[7, 7] + " " + matriz[8, 7] + " " + matriz[9, 7] + " " + "|");
                Console.WriteLine("                 |" + " " + matriz[0, 8] + " " + matriz[1, 8] + " " + matriz[2, 8] + " " + matriz[3, 8] + " " + matriz[4, 8] + " " + matriz[5, 8] + " " + matriz[6, 8] + " " + matriz[7, 8] + " " + matriz[8, 8] + " " + matriz[9, 8] + " " + "|");
                Console.WriteLine("                 |" + " " + matriz[0, 9] + " " + matriz[1, 9] + " " + matriz[2, 9] + " " + matriz[3, 9] + " " + matriz[4, 9] + " " + matriz[5, 9] + " " + matriz[6, 9] + " " + matriz[7, 9] + " " + matriz[8, 9] + " " + matriz[9, 9] + " " + "|");


            }
        }

    }
}