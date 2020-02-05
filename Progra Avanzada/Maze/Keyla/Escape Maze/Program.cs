using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionmenu = 0, px = 0, py = 0, tx = 0, ty = 0;
           Random randomnumerotablero = new Random();
            string nickname = "";
            do
            {

                {
                    Console.Clear();

                    Console.WriteLine("Proyecto2");
                    Console.WriteLine("Jose Diego Vielmann Mendez");

                    Console.WriteLine("");
                    Console.WriteLine("Ingresa Tu Nickname");

                    nickname = Console.ReadLine();
                    if (nickname != "")
                    {
                        Console.WriteLine("Dimensiones Tablero");
                        Console.WriteLine("1: Tablero 5x5");
                        Console.WriteLine("2: Tablero 8x8");
                        Console.WriteLine("3: Tablero 10x10");
                        opcionmenu = Convert.ToInt32(Console.ReadLine());
                        switch (opcionmenu)
                        {
                            case 1: //definiento tamaño,enemigos, etc.
                                tx = 5;
                                ty = 5;



                                break;
                            case 2:
                                tx = 8;
                                ty = 6;

                                break;
                            case 3:
                                tx = 10;
                                ty = 10;

                                break;
                            default:
                                Console.WriteLine("ingrese un numero valido");
                                nickname = "";
                                break;

                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Tienes que llamarte de alguna manera.");
                        Console.WriteLine("");
                    }

                }
            } while (nickname == "");

            bool duracion = true;

            bool durante = true; ;
            ConsoleKey imputtecla;
            int puntaje = 0;
            int salud = 3;
            int derrotados = 0;
            string[,] area = new string[tx, ty];
            for (int i = 0; i < tx; i++)
            {
                for (int j = 0; j < ty; j++)
                {

                    area[i, j] = Convert.ToString(randomnumerotablero.Next(0, 5)); //limitante
                    if (area[i, j] == "1" || area[i, j] == "5")
                    {
                        area[i, j] = "0";
                    }
                }
            }
            area[0, ty - 1] = "1";
            area[ty - 1, 0] = "5";
            area[0, ty - 2] = " ";
            area[1, ty - 2] = " ";
            area[2, ty - 2] = " ";
            area[2, 2] = "9";
            px = 0; py = ty - 1;
            area[0, ty - 1] = "P";



            {
                for (int i = 0; i < tx; i++)
                {
                    for (int j = 0; j < ty; j++)
                    {

                        //cambiando a chars
                        if (area[i, j] == "0")
                        {

                            area[i, j] = " ";//Espacio Vacio
                        }
                        else if (area[i, j] == "1")
                        {
                            area[i, j] = "P";//Personaje
                        }
                        else if (area[i, j] == "2")
                        {
                            area[i, j] = "#";//Obstaculo
                        }
                        else if (area[i, j] == "3")
                        {
                            area[i, j] = "+";//Enemigo
                        }
                        else if (area[i, j] == "4")
                        {
                            area[i, j] = " ";//vacio
                        }
                        else if (area[i, j] == "5")
                        {
                            area[i, j] = "*";//Estrella
                        }
                        else if (area[i, j] == "9")
                        {
                            area[i, j] = " ";
                        }
                    }
                }
            }
            px = 0;
            py = ty - 1;

            do
            {
                durante = true;

                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Green;
                    if (salud <= 0)
                    {
                        duracion = false;
                        durante = false;
                        validarterminado();
                    }
                    Console.Clear();

                    {
                        Console.Clear();
                        Console.WriteLine("MENU");
                        Console.WriteLine("1.Comandos");
                        Console.WriteLine("2.Imprimir Tablero ");
                        Console.WriteLine("3.Estatus");
                        Console.WriteLine("4.Terminar Partida");
                    }
                    int menu = 0;
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.Clear();

                            {
                                Console.Clear();
                                Console.WriteLine("MENU");
                                Console.WriteLine("1.Comandos");
                                Console.WriteLine("2.Imprimir Tablero ");
                                Console.WriteLine("3.Estatus");
                                Console.WriteLine("4.Terminar Partida");
                            }

                            Console.WriteLine("FLecha arriba---------------->para atacar hacia arriba");
                            Console.WriteLine("FLecha abajo----------------->para atacar hacia abajo");
                            Console.WriteLine("FLecha FLecha---------------->izquierda para atacar hacia la izquierda");
                            Console.WriteLine("FLecha derecha--------------->para atacar hacia la derecha");
                            Console.WriteLine("Tecla W para moverse--------->hacia arriba");
                            Console.WriteLine("Tecla S para moverse--------->hacia abajo");
                            Console.WriteLine("Tecla A para moverse--------->hacia la izquierda");
                            Console.WriteLine("Tecla D para moverse--------->hacia la derecha");
                            Console.WriteLine("");
                            Console.Write("••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••");
                            Console.Write("••••••••••••••••••••••••••••Tablero•••••••••••••••••••••••••••••");
                            Console.Write("••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••");
                            Console.WriteLine("");


                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + "|");
                                    Console.WriteLine("                 |" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + "|");
                                    Console.WriteLine("                 |" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + "|");
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + "|");
                                    Console.WriteLine("                 |" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + "|");
                                    Console.WriteLine("                 |" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + "|");


                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }

                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");


                            comando();

                            if (salud <= 0)
                            {
                                if (duracion == false || durante == false)
                                {

                                }
                                else
                                {


                                    duracion = false;
                                    durante = false;
                                    validarterminado();
                                }
                            }
                            break;


                        case 2:
                            if (salud <= 0)
                            {
                                duracion = false;
                                durante = false;
                                validarterminado();
                            }
                            Console.Clear();

                            {
                                Console.Clear();
                                Console.WriteLine("MENU");
                                Console.WriteLine("1.Comandos");
                                Console.WriteLine("2.Imprimir Tablero ");
                                Console.WriteLine("3.Estatus");
                                Console.WriteLine("4.Terminar Partida");
                            }

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + "|");
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + "|");
                                    Console.WriteLine("                 |" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + "|");
                                    Console.WriteLine("                 |" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + "|");


                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("Enter para proseguir...");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();

                            {
                                Console.Clear();
                                Console.WriteLine("MENU");
                                Console.WriteLine("1.Comandos");
                                Console.WriteLine("2.Imprimir Tablero ");
                                Console.WriteLine("3.Estatus");
                                Console.WriteLine("4.Terminar Partida");
                            }
                            Console.WriteLine("Estado De: " + nickname);
                            Console.WriteLine("Vidas Disponibles: " + salud);
                            Console.WriteLine("Enemigos eliminados: " + derrotados);
                            Console.WriteLine("Enter para proseguir...");
                            Console.ReadLine();

                            break;

                        case 4:
                            Console.Clear();
                            duracion = false;
                            durante = false;
                            break;

                        default:
                            Console.Clear();

                            {
                                Console.Clear();
                                Console.WriteLine("MENU");
                                Console.WriteLine("1.Comandos");
                                Console.WriteLine("2.Imprimir Tablero ");
                                Console.WriteLine("3.Estatus");
                                Console.WriteLine("4.Terminar Partida");
                            }
                            break;
                    }
                    if (salud <= 0)
                    {
                        duracion = false;
                        durante = false;
                        validarterminado();
                    }
                }





                if (salud <= 0)
                {
                    duracion = false;
                    durante = false;
                    validarterminado();
                }
            } while (duracion == true);
            Console.Clear();
            validarterminado();




            void validarterminado()
            {
                Console.WriteLine("¿Desea Continuar?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                string continuar = Console.ReadLine();
                if (continuar == "1")
                {
                    durante = true;
                    duracion = true;
                    salud = 3;
                }
                else
                {
                    Console.WriteLine("Gracias por jugar  :)");

                    Console.WriteLine("Total de puntos " + puntaje);
                    Console.WriteLine("Total de vidas " + salud);
                    Console.WriteLine("Total de enemigos abatidos " + derrotados);

                    Console.ReadLine();
                }
            }

            void comando()
            {
                do
                {
                    imputtecla = 0;
                    imputtecla = Console.ReadKey().Key;
                    Console.Clear();
                    switch (imputtecla)
                    {

                        case ConsoleKey.A://mover izquierda

                            if (px == 0)
                            {
                                Console.WriteLine("No puedes salirte del mapa");
                                px = 0;
                            }
                            else
                            {
                                if (area[px - 1, py] == "#")
                                {
                                    Console.WriteLine("No puedes pasar, tienes un obstaculo enfrente");
                                }
                                else if (area[px - 1, py] == "+" || area[px - 1, py] == "D")
                                {
                                    if (area[px - 1, py] == "D")
                                    {
                                        durante = false;
                                        duracion = false;
                                        validarterminado();
                                    }
                                    else
                                    {


                                        Console.WriteLine("El enemigo te ha atacado, -1 de salud");
                                        salud--;
                                    }
                                }
                                else if (area[px - 1, py] == "*")
                                {
                                    Console.WriteLine("Juego terminado");

                                    duracion = false;
                                    break;
                                }
                                else if (area[px - 1, py] == "O")
                                {
                                    Console.WriteLine("No puedes pasar, tienes un cofre enfrente");
                                }
                                else
                                {
                                    area[px, py] = " ";
                                    px--;
                                }

                            }
                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");
                            Console.ForegroundColor = ConsoleColor.Red;
                            area[px, py] = "P";
                            Console.ForegroundColor = ConsoleColor.White;

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + "|");
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + "|");
                                    Console.WriteLine("                 |" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + "|");
                                    Console.WriteLine("                 |" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + "|");


                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");
                            break;

                        case ConsoleKey.D://mover derecha
                            if (px == tx - 1 || px == tx)
                            {
                                Console.WriteLine("No puedes salirte del mapa");
                                px = tx - 1;
                            }
                            else
                            {

                                if (area[px + 1, py] == "#")  //interacciones
                                {
                                    Console.WriteLine("No puedes pasar, tienes un obstaculo enfrente");
                                }
                                else if (area[px + 1, py] == "+" || area[px + 1, py] == "D")
                                {
                                    if (area[px + 1, py] == "D")
                                    {

                                        salud = 0;
                                        durante = false;
                                        duracion = false;
                                        validarterminado();
                                    }
                                    else
                                    {


                                        Console.WriteLine("El enemigo te ha atacado, -1 de salud");
                                        salud--;
                                    }
                                }
                                else if (area[px + 1, py] == "*")
                                {
                                    Console.WriteLine("Juego terminado");

                                    duracion = false;
                                    break;
                                }
                                else if (area[px + 1, py] == "O")
                                {
                                    Console.WriteLine("No puedes pasar, tienes un cofre enfrente");
                                }
                                else
                                {
                                    area[px, py] = " ";
                                    px++;
                                }

                            }
                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");
                            Console.ForegroundColor = ConsoleColor.Red;
                            area[px, py] = "P";
                            Console.ForegroundColor = ConsoleColor.White;

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + "|");
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + "|");
                                    Console.WriteLine("                 |" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + "|");
                                    Console.WriteLine("                 |" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + "|");


                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");
                            break;


                        case ConsoleKey.W:
                            if (py == 0)
                            {
                                Console.WriteLine("No puedes salirte del mapa");
                                py = 0;
                            }
                            else
                            {

                                if (area[px, py - 1] == "#")
                                {
                                    Console.WriteLine("No puedes pasar, tienes un obstaculo enfrente");
                                }
                                else if (area[px, py - 1] == "+" || area[px, py - 1] == "D")
                                {
                                    if (area[px, py - 1] == "D")
                                    {
                                        durante = false;
                                        duracion = false;
                                        validarterminado();
                                    }
                                    else
                                    {


                                        Console.WriteLine("El enemigo te ha atacado, -1 de salud");
                                        salud--;
                                    }
                                }
                                else if (area[px, py - 1] == "*")
                                {
                                    Console.WriteLine("Juego terminado");
                                    durante = false;

                                    duracion = false;
                                    validarterminado();



                                    break;

                                }
                                else if (area[px, py - 1] == "O")
                                {
                                    Console.WriteLine("No puedes pasar, tienes un cofre enfrente");
                                }
                                else
                                {
                                    area[px, py] = " ";
                                    py--;
                                }

                            }
                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");
                            Console.ForegroundColor = ConsoleColor.Red;
                            area[px, py] = "P";
                            Console.ForegroundColor = ConsoleColor.White;

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + "|");
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + "|");
                                    Console.WriteLine("                 |" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + "|");
                                    Console.WriteLine("                 |" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + "|");
                                    Console.WriteLine("                 |" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + "|");


                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");

                            break;



                        case ConsoleKey.S:
                            if (py == ty - 1 || py == ty)
                            {
                                Console.WriteLine("No puedes salirte del mapa");
                                py = ty - 1;
                            }
                            else
                            {

                                if (area[px, py + 1] == "#")
                                {
                                    Console.WriteLine("No puedes pasar, tienes un obstaculo enfrente");
                                }
                                else if (area[px, py + 1] == "+" || area[px + 1, py] == "D")
                                {
                                    if (area[px + 1, py] == "D")
                                    {
                                        durante = false;
                                        duracion = false;
                                        validarterminado();
                                    }
                                    else
                                    {


                                        Console.WriteLine("El enemigo te ha atacado, -1 de salud");
                                        salud--;
                                    }
                                }
                                else if (area[px, py + 1] == "*")
                                {
                                    Console.WriteLine("Juego terminado");

                                    duracion = false;
                                    break;
                                }
                                else if (area[px, py + 1] == "O")
                                {
                                    Console.WriteLine("No puedes pasar, tienes un cofre enfrente");

                                }
                                else
                                {
                                    area[px, py] = " ";
                                    py++;
                                }

                            }
                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");
                            Console.ForegroundColor = ConsoleColor.Red;
                            area[px, py] = "P";
                            Console.ForegroundColor = ConsoleColor.White;

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0]);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1]);
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2]);
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3]);
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4]);
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5]);
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6]);
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7]);
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + area[8, 0] + area[9, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + area[8, 1] + area[9, 1] + "|");
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + area[8, 2] + area[9, 2] + "|");
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + area[8, 3] + area[9, 3] + "|");
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + area[8, 4] + area[9, 4] + "|");
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + area[8, 5] + area[9, 5] + "|");
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + area[8, 6] + area[9, 6] + "|");
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + area[8, 7] + area[9, 7] + "|");
                                    Console.WriteLine("|" + area[0, 8] + area[1, 8] + area[2, 8] + area[3, 8] + area[4, 8] + area[5, 8] + area[6, 8] + area[7, 8] + area[8, 8] + area[9, 8] + "|");
                                    Console.WriteLine("|" + area[0, 9] + area[1, 9] + area[2, 9] + area[3, 9] + area[4, 9] + area[5, 9] + area[6, 9] + area[7, 9] + area[8, 9] + area[9, 9] + "|");



                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");
                            break;


                        case ConsoleKey.X:
                            durante = false;
                            break;



                        case ConsoleKey.UpArrow:
                            if (area[px, py - 1] == "+")
                            {
                                if (area[px, py - 1] == "+")
                                {
                                    derrotados++;
                                }

                                area[px, py - 1] = " ";
                                Console.WriteLine("Enemigo Eliminado");
                            }


                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0]);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1]);
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2]);
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3]);
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4]);
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5]);
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6]);
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7]);
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + area[8, 0] + area[9, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + area[8, 1] + area[9, 1] + "|");
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + area[8, 2] + area[9, 2] + "|");
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + area[8, 3] + area[9, 3] + "|");
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + area[8, 4] + area[9, 4] + "|");
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + area[8, 5] + area[9, 5] + "|");
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + area[8, 6] + area[9, 6] + "|");
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + area[8, 7] + area[9, 7] + "|");
                                    Console.WriteLine("|" + area[0, 8] + area[1, 8] + area[2, 8] + area[3, 8] + area[4, 8] + area[5, 8] + area[6, 8] + area[7, 8] + area[8, 8] + area[9, 8] + "|");
                                    Console.WriteLine("|" + area[0, 9] + area[1, 9] + area[2, 9] + area[3, 9] + area[4, 9] + area[5, 9] + area[6, 9] + area[7, 9] + area[8, 9] + area[9, 9] + "|");



                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");
                            break;





                        case ConsoleKey.DownArrow:
                            if (area[px, py + 1] == "+")
                            {
                                if (area[px, py + 1] == "+")
                                {
                                    derrotados++;
                                }

                                area[px, py + 1] = " ";
                                Console.WriteLine("Enemigo Eliminado");
                            }

                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0]);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1]);
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2]);
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3]);
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4]);
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5]);
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6]);
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7]);
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {


                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + area[8, 0] + area[9, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + area[8, 1] + area[9, 1] + "|");
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + area[8, 2] + area[9, 2] + "|");
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + area[8, 3] + area[9, 3] + "|");
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + area[8, 4] + area[9, 4] + "|");
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + area[8, 5] + area[9, 5] + "|");
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + area[8, 6] + area[9, 6] + "|");
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + area[8, 7] + area[9, 7] + "|");
                                    Console.WriteLine("|" + area[0, 8] + area[1, 8] + area[2, 8] + area[3, 8] + area[4, 8] + area[5, 8] + area[6, 8] + area[7, 8] + area[8, 8] + area[9, 8] + "|");
                                    Console.WriteLine("|" + area[0, 9] + area[1, 9] + area[2, 9] + area[3, 9] + area[4, 9] + area[5, 9] + area[6, 9] + area[7, 9] + area[8, 9] + area[9, 9] + "|");



                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");
                            break;





                        case ConsoleKey.RightArrow:
                            if (area[px + 1, py] == "+" || area[px + 1, py] == "D")
                            {
                                if (area[px + 1, py] == "+")
                                {
                                    derrotados++;
                                }

                                area[px + 1, py] = " ";
                                Console.WriteLine("Enemigo Eliminado");
                            }



                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0]);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1]);
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2]);
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3]);
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4]);
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5]);
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6]);
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7]);
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + area[8, 0] + area[9, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + area[8, 1] + area[9, 1] + "|");
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + area[8, 2] + area[9, 2] + "|");
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + area[8, 3] + area[9, 3] + "|");
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + area[8, 4] + area[9, 4] + "|");
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + area[8, 5] + area[9, 5] + "|");
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + area[8, 6] + area[9, 6] + "|");
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + area[8, 7] + area[9, 7] + "|");
                                    Console.WriteLine("|" + area[0, 8] + area[1, 8] + area[2, 8] + area[3, 8] + area[4, 8] + area[5, 8] + area[6, 8] + area[7, 8] + area[8, 8] + area[9, 8] + "|");
                                    Console.WriteLine("|" + area[0, 9] + area[1, 9] + area[2, 9] + area[3, 9] + area[4, 9] + area[5, 9] + area[6, 9] + area[7, 9] + area[8, 9] + area[9, 9] + "|");



                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");
                            break;


                        case ConsoleKey.LeftArrow:
                            if (area[px - 1, py] == "+" || area[px - 1, py] == "D")
                            {
                                if (area[px - 1, py] == "+")
                                {
                                    derrotados++;
                                }

                                area[px - 1, py] = " ";
                                Console.WriteLine("Enemigo Eliminado");
                            }


                            Console.WriteLine("Posicion Actual [" + px + " , " + py + "]");

                            {
                                if (opcionmenu == 1)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----#");
                                    Console.WriteLine("                 |" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("                 |" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + "|");
                                    Console.WriteLine("                 |" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + "|");
                                    Console.WriteLine("                 |" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + "|");
                                    Console.WriteLine("                 |" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + "|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    Console.WriteLine("#----#");
                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 2)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0]);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1]);
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2]);
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3]);
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4]);
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5]);
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6]);
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7]);
                                    Console.WriteLine("#-----#"); Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella =*");

                                    if (salud <= 0)
                                    {
                                        duracion = false;
                                        durante = false;
                                        validarterminado();
                                    }
                                }
                                else if (opcionmenu == 3)
                                {

                                    {
                                        for (int i = 0; i < tx; i++)
                                        {
                                            for (int j = 0; j < ty; j++)
                                            {

                                                //cambiando a chars
                                                if (area[i, j] == "0")
                                                {

                                                    area[i, j] = " ";//Espacio Vacio
                                                }
                                                else if (area[i, j] == "1")
                                                {
                                                    area[i, j] = "P";//Personaje
                                                }
                                                else if (area[i, j] == "2")
                                                {
                                                    area[i, j] = "#";//Obstaculo
                                                }
                                                else if (area[i, j] == "3")
                                                {
                                                    area[i, j] = "+";//Enemigo
                                                }
                                                else if (area[i, j] == "4")
                                                {
                                                    area[i, j] = " ";//vacio
                                                }
                                                else if (area[i, j] == "5")
                                                {
                                                    area[i, j] = "*";//Estrella
                                                }
                                                else if (area[i, j] == "9")
                                                {
                                                    area[i, j] = " ";
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("#----------#");
                                    Console.WriteLine("|" + area[0, 0] + area[1, 0] + area[2, 0] + area[3, 0] + area[4, 0] + area[5, 0] + area[6, 0] + area[7, 0] + area[8, 0] + area[9, 0] + "|" + "                   Salud de " + nickname + ":" + salud);
                                    Console.WriteLine("|" + area[0, 1] + area[1, 1] + area[2, 1] + area[3, 1] + area[4, 1] + area[5, 1] + area[6, 1] + area[7, 1] + area[8, 1] + area[9, 1] + "|");
                                    Console.WriteLine("|" + area[0, 2] + area[1, 2] + area[2, 2] + area[3, 2] + area[4, 2] + area[5, 2] + area[6, 2] + area[7, 2] + area[8, 2] + area[9, 2] + "|");
                                    Console.WriteLine("|" + area[0, 3] + area[1, 3] + area[2, 3] + area[3, 3] + area[4, 3] + area[5, 3] + area[6, 3] + area[7, 3] + area[8, 3] + area[9, 3] + "|");
                                    Console.WriteLine("|" + area[0, 4] + area[1, 4] + area[2, 4] + area[3, 4] + area[4, 4] + area[5, 4] + area[6, 4] + area[7, 4] + area[8, 4] + area[9, 4] + "|");
                                    Console.WriteLine("|" + area[0, 5] + area[1, 5] + area[2, 5] + area[3, 5] + area[4, 5] + area[5, 5] + area[6, 5] + area[7, 5] + area[8, 5] + area[9, 5] + "|");
                                    Console.WriteLine("|" + area[0, 6] + area[1, 6] + area[2, 6] + area[3, 6] + area[4, 6] + area[5, 6] + area[6, 6] + area[7, 6] + area[8, 6] + area[9, 6] + "|");
                                    Console.WriteLine("|" + area[0, 7] + area[1, 7] + area[2, 7] + area[3, 7] + area[4, 7] + area[5, 7] + area[6, 7] + area[7, 7] + area[8, 7] + area[9, 7] + "|");
                                    Console.WriteLine("|" + area[0, 8] + area[1, 8] + area[2, 8] + area[3, 8] + area[4, 8] + area[5, 8] + area[6, 8] + area[7, 8] + area[8, 8] + area[9, 8] + "|");
                                    Console.WriteLine("|" + area[0, 9] + area[1, 9] + area[2, 9] + area[3, 9] + area[4, 9] + area[5, 9] + area[6, 9] + area[7, 9] + area[8, 9] + area[9, 9] + "|");



                                    Console.WriteLine("#----------#");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                    Console.WriteLine("     ----- Significado ------");
                                    Console.WriteLine("   vacio = _ ");
                                    Console.WriteLine("   personaje = P");
                                    Console.WriteLine("   obstaculo = #");
                                    Console.WriteLine("   enemigo = +");

                                    Console.WriteLine("   estrrella = *");




                                }
                            }
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("X para salir al menú");

                            break;
                    }
                } while (durante == true);
            }

        }
    }
}
