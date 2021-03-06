#include "pch.h"
#include <iostream>
#include<fstream>
#include <stdlib.h>
#include <string>
#include "Electrodomestico.h"
#include "Tele.h"
#include "Lavadora.h"
using namespace std;
int contador;
string linea_archivo;
int iPosicionEncuentra, iPosicionAnterior = 0;
ifstream ArchivoCarga("dato.txt");
void CARGADATOS();
//control
double cantidadLavadoras, PrecioGeneralLavadora;
void Resumen();
double cantidadTele, PrecioGeneralTele;
struct NodoLista
{           
	Lavadora *lavadora = new Lavadora();
	Tele *tele = new Tele();
	NodoLista *siguiente;   
}*primero, *ultimo;
void InsertarNodo(NodoLista *);
int main()
{
	cout << "======================================================	MARLON ROCGES 1250918	===============================================" << endl;
	cout << "======================================================	    EXAMEN FINAL		===============================================" << endl;
	CARGADATOS();
	Resumen();
}
//===========================================================  METODOS =====================================================================
void InsertarNodo(NodoLista *maquina)
{
	NodoLista* nuevo = maquina;

	if (primero == NULL)
	{
		primero = nuevo;
		primero->siguiente = NULL;
		ultimo = nuevo;
	}
	else
	{
		ultimo->siguiente = nuevo;
		nuevo->siguiente = NULL;
		ultimo = nuevo;
	}
}
void CARGADATOS()

{// string -> int stod(elemeto a convert)
	while (!ArchivoCarga.eof())
	{
		contador++;
		Electrodomestico *auxiliar = new Electrodomestico();
		cout << "==================================================NODO NUM.	" << contador <<"============================================" <<endl;
		//lectura archivo
		getline(ArchivoCarga, linea_archivo);
		//====================================================================SPLIT=======================================
			//tipo
		iPosicionEncuentra = linea_archivo.find("|");
		auxiliar->tipo = linea_archivo.substr(0, iPosicionEncuentra);
		cout << "  					----------	Tipo	----------					" << endl;
		cout << auxiliar->tipo << endl;

			//precio
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->precio = stod(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
		cout << " 					----------	Precio	----------					" << endl;

		cout << "$."<<auxiliar->precio << endl;
		
		//color
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->color= linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		if (auxiliar->color == "–"|| auxiliar->color == "-"|| auxiliar->color == "-"|| auxiliar->color == "—")//validar default
		{
			auxiliar->color = "azul";
		}
		cout << "  					----------	Color	----------					" << endl;

		cout << auxiliar->color<< endl;

		//consumo
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->consumo= linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		cout << "  					----------	Nivel De Consumo	----------					" << endl;

		cout << "Nivel: "<<auxiliar->consumo << endl;

		//peso
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->peso = stod(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
		cout << " 					----------	Peso				----------					" << endl;

		cout << auxiliar->peso<< " KG" << endl;

		//insertando en las listas para ser ordenados
		if (auxiliar->tipo == "Lavadora")
		{
			NodoLista *contenedor = new NodoLista();
			contenedor->lavadora->tipo = auxiliar->tipo;
			contenedor->lavadora->precio = auxiliar->precio;
			contenedor->lavadora->color = auxiliar->color;
			contenedor->lavadora->consumo = auxiliar->consumo;
			contenedor->lavadora->peso = auxiliar->peso;

			//carga
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
			contenedor->lavadora->carga = stod(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			
			cout << " 					----------	Carga	----------					" << endl;
			cout << contenedor->lavadora->carga << endl;

			contenedor->lavadora->preciofinal = contenedor->lavadora->precio;
			//regla1 
			if (contenedor->lavadora->consumo == "A")
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 100;
			}
			else if (contenedor->lavadora->consumo == "B")
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 80;
			}
			else if (contenedor->lavadora->consumo == "C")
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 60;
			}
			else if (contenedor->lavadora->consumo == "D")
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 40;
			}
			else if (contenedor->lavadora->consumo == "E")
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 20;
			}
			else if (contenedor->lavadora->consumo == "F")
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 10;
			}


			//Regla2
			if (contenedor->lavadora->peso >=0 && contenedor->lavadora->peso <= 19)
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 10;
			}
			else if (contenedor->lavadora->peso >= 20 && contenedor->lavadora->peso <= 39)
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 50;
			}
			else if (contenedor->lavadora->peso >= 40 && contenedor->lavadora->peso <= 59)
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 80;
			}
			else if (contenedor->lavadora->peso >= 60 )
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 10;
			}
			//Regla Peso
			if (contenedor->lavadora->carga>30)
			{
				contenedor->lavadora->preciofinal = contenedor->lavadora->preciofinal + 50;
			}
			cout << " ***********************************************  Precio Final	***********************************" << endl;

			cout << "							$." << contenedor->lavadora->preciofinal << endl;
			
			InsertarNodo(contenedor);
			cantidadLavadoras++;
			PrecioGeneralLavadora = PrecioGeneralLavadora + contenedor->lavadora->preciofinal;
		}
		else if (auxiliar->tipo == "Television" || auxiliar->tipo == "Televisión")
		{
			NodoLista * contenedor = new NodoLista();
			contenedor->tele->tipo = auxiliar->tipo;
			contenedor->tele->precio = auxiliar->precio;
			contenedor->tele->color = auxiliar->color;
			contenedor->tele->consumo = auxiliar->consumo;
			contenedor->tele->peso = auxiliar->peso;
			//resolucion
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
			contenedor->tele->resolucion = stod(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			cout << "					----------	Resolucion	----------					" << endl;

			cout << contenedor->tele->resolucion << endl;

			//sync
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
			contenedor->tele->sinc= linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
			cout << "					----------	Sync	----------					" << endl;

			cout << contenedor->tele->sinc << endl;
			contenedor->tele->preciofinal = contenedor->tele->precio;
			//regla1 
			if (contenedor->tele->consumo == "A")
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 100;
			}
			else if (contenedor->tele->consumo == "B")
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 80;
			}
			else if (contenedor->tele->consumo == "C")
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 60;
			}
			else if (contenedor->tele->consumo == "D")
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 40;
			}
			else if (contenedor->tele->consumo == "E")
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 20;
			}
			else if (contenedor->tele->consumo == "F")
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 10;
			}


			//Regla2
			if (contenedor->tele->peso >= 0 && contenedor->tele->peso <= 19)
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 10;
			}
			else if (contenedor->tele->peso >= 20 && contenedor->tele->peso <= 39)
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 50;
			}
			else if (contenedor->tele->peso >= 40 && contenedor->tele->peso <= 59)
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 80;
			}
			else if (contenedor->tele->peso >= 60)
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 100;

			}
			
			//Regla Televisor 1
				if (contenedor->tele->resolucion>=40)
				{
					contenedor->tele->preciofinal = contenedor->tele->preciofinal + (contenedor->tele->preciofinal *0.30) ;
				}
			
			//Regla Televisor 2
			if (contenedor->tele->sinc == "si" || contenedor->tele->sinc == "Si" || contenedor->tele->sinc == "SI" || contenedor->tele->sinc == "sI")
			{
				contenedor->tele->preciofinal = contenedor->tele->preciofinal + 30;
			}
			
			cout << "  ********************************  Precio Final	**************************" << endl;

			cout << "							$."<<contenedor->tele->preciofinal << endl;


			InsertarNodo(contenedor);
			PrecioGeneralTele = PrecioGeneralTele + contenedor->tele->preciofinal;
			cantidadTele++;
		}
		else
		{
			cout << "Es otro tipo de electrodomestico :3" << endl;
		}
	}

	cout << "---------------------------------------------|     DATOS CARGADOS     |---------------------------------------------" << endl;
}

void Resumen()
{
	cout << "\n\n<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<|RESUMEN|>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" << endl;
	cout << "						|Lavadoras|" << endl;
	cout << "------------------> INGRESO DE: $. "<<PrecioGeneralLavadora<<  " POR "<<cantidadLavadoras <<" LAVADORAS"<< endl;
	cout << "						|Televisores|" << endl;
	cout <<	"------------------> INGRESO DE: $. " << PrecioGeneralTele << " POR " << cantidadTele << " teles" << endl;
	system("pause");

}
