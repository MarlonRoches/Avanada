#include "pch.h"
#include <iostream>
#include<fstream>
#include <stdlib.h>
#include <string>

#include "Empleado.h"
#include "Fijo.h"
#include "PorHoras.h"
#include "Temporal.h"
using namespace std;
struct NodoLista
{
	string nombre;
	string tipo;
	int sueldo;	
	int edad;
	NodoLista *siguiente;
	NodoLista *atras;
}*primero, *ultimo;
string linea_archivo;
int iPosicionEncuentra, iPosicionAnterior = 0;
ifstream ArchivoCarga("datos.txt");
int contador=0;
void CARGADATOS();
void InsertarNodo(NodoLista *);
void mostrarlista();
void OrdenarEdad();
void mostrarlistatipo();
bool ciclo = true;
int menu; bool cargados = true;
void OrdenarSueldoyTipo();
void main()
{
	if (cargados==true)
	{

		CARGADATOS();
		cargados = false;
	}
	
	do
	{
		system("CLS");
		cout << "============ MARLON ROCHES EJERCICIO #3============"<< endl;
		cout << "1. Por nombre y por tipo "<< endl;
		cout << "2. Por Tipo y Por Sueldo "<< endl;
		cout << "3. Ordenados Por Edad"<< endl;
		cout << "4.Mostrar Todos"<< endl;
		cin >> menu;
		switch (menu)
		{


		case 1:mostrarlistatipo();
			break;
			
		case 2:
			OrdenarSueldoyTipo();
			break;

		case 3:
			OrdenarEdad();
			mostrarlista();
			break;

		case 4:
			mostrarlista();
			
			break;
		default:
			break;
		}
		system("pause");
	} while (ciclo==true);
}
void CARGADATOS()
{
	while (!ArchivoCarga.eof())
	{
		contador++;
		Empleado *auxiliar = new Empleado();
		/*cout << "==================================NODO NUM.	" << contador <<"=======================" <<endl;*/
		//lectura archivo
		getline(ArchivoCarga, linea_archivo);
		//SPLIT
		//nombre
		iPosicionEncuentra = linea_archivo.find("+");
		auxiliar->nombre = linea_archivo.substr(0, iPosicionEncuentra);

		//edad
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
		auxiliar->edad = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));

		//DIU
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
		auxiliar->DIU = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);

		//tipo
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
		auxiliar->tipo = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);

		if (auxiliar->tipo == "1")
		{

			Temporal * empleado = new Temporal;
			cout << "----------Empleado Termporal----------" << endl;

			empleado->nombre = auxiliar->nombre;
			cout << empleado->nombre << endl;
			empleado->edad = auxiliar->edad;
			cout << empleado->edad << endl;
			empleado->DIU = auxiliar->DIU;
			cout << empleado->DIU << endl;
			empleado->tipo = auxiliar->tipo;
			//añoinicial
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->añoingreso = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
			cout << "Año de entrada " << empleado->añoingreso << endl;
			//añoinicial
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->añosalida = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
			cout << "Año de salida" << empleado->añosalida << endl;
			//sueldo mensual
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->sueldofijo = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			cout << "El sueldo fijo es de: $." << empleado->sueldofijo << endl;
			//calculando sueldo
			empleado->calcularsueldo(empleado);
			cout << "El sueldo es de: $." << empleado->sueldo << ".00" << endl;

			//insertadno a listas
			NodoLista *nodoenviar = new NodoLista();
			nodoenviar->nombre = empleado->nombre;
			nodoenviar->edad = empleado->edad;
			nodoenviar->tipo = empleado->tipo;
			nodoenviar->sueldo = empleado->sueldo;
			//insertando en las listas para ser ordenados
			InsertarNodo(nodoenviar);
			cout << "";
		}
		else if (auxiliar->tipo == "2")
		{
			FIjo *empleado = new FIjo();
			cout << "----------Empleado Fijo----------" << endl;

			empleado->nombre = auxiliar->nombre;
			cout << empleado->nombre << endl;
			empleado->edad = auxiliar->edad;
			cout << empleado->edad << endl;
			empleado->DIU = auxiliar->DIU;
			cout << empleado->DIU << endl;
			empleado->tipo = auxiliar->tipo;

			//añoinicial
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->añodeentrada = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			cout << "Año de entrada " << empleado->añodeentrada << endl;

			//sueldo mensual
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->sueldobase = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			cout << "El sueldo base es de: $." << empleado->sueldobase << endl;
			//complemento
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->complemento = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			cout << "El cmplemento es de: $." << empleado->complemento << endl;
			empleado->calcularsueldo(empleado);

			cout << "El sueldo es de: $." << empleado->sueldo << ".00" << endl;
			//insertadno a listas
			NodoLista *nodoenviar = new NodoLista();

			nodoenviar->nombre = empleado->nombre;
			nodoenviar->edad = empleado->edad;
			nodoenviar->tipo = empleado->tipo;
			nodoenviar->sueldo = empleado->sueldo;
			//insertando en las listas para ser ordenados
			InsertarNodo(nodoenviar);
		}
		else if (auxiliar->tipo == "3")
		{
			PorHoras * empleado = new PorHoras();
			cout << "----------Empleado Por Horas----------" << endl;

			empleado->nombre = auxiliar->nombre;
			cout << empleado->nombre << endl;
			empleado->edad = auxiliar->edad;
			cout << empleado->edad << endl;
			empleado->DIU = auxiliar->DIU;
			cout << empleado->DIU << endl;
			empleado->tipo = auxiliar->tipo;

			//sueldo por horas
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->preciodehora = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			cout << "El precio de la hora es de: $." << empleado->preciodehora << endl;


			//horas trabajadas
			iPosicionAnterior = iPosicionEncuentra;
			iPosicionEncuentra = linea_archivo.find("+", iPosicionEncuentra + 1);
			empleado->horastrabajadas = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
			cout << "Las horas trabajadas fueron: " << empleado->horastrabajadas << endl;
			empleado->calcularsueldo(empleado);

			cout << "El sueldo es de: $." << empleado->sueldo << ".00" << endl;

			//insertadno a listas
			NodoLista *nodoenviar = new NodoLista();


			nodoenviar->nombre = empleado->nombre;
			nodoenviar->edad = empleado->edad;
			nodoenviar->tipo = empleado->tipo;
			nodoenviar->sueldo = empleado->sueldo;

			//insertando en las listas para ser ordenados
			InsertarNodo(nodoenviar);
		}
	}
	system("CLS");
}
void InsertarNodo(NodoLista *empleado)
{
	NodoLista* nuevo = new NodoLista();

	nuevo->nombre = empleado->nombre;
	nuevo->tipo = empleado->tipo;
	nuevo->sueldo= empleado->sueldo;
	nuevo->edad = empleado->edad;
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
void mostrarlista()
{
	int conta = 1;
	NodoLista* actual = new NodoLista();
	actual = primero;
	if (primero != NULL)
	{
		while (actual != NULL)
		{
			cout << "Nombre: " << actual->nombre << ", Edad " << actual->edad<<"\n";
			actual = actual->siguiente;
			conta++;
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}
void OrdenarEdad()
{
	NodoLista *p = primero;
	NodoLista *aux = new NodoLista();
	while (p != NULL)
	{
		NodoLista *j = p->siguiente;

		while (j != NULL)
		{
			if (p->edad < j->edad)
			{
				aux->nombre = j->nombre;
				aux->tipo = j->tipo;
				aux->sueldo= j->sueldo;
				aux->edad = j->edad;
				
				j->nombre = p->nombre;
				j->tipo = p->tipo;
				j->sueldo= p->sueldo;
				j->edad = p->edad;


				p->nombre = aux->nombre;
				p->tipo = aux->tipo;
				p->sueldo = aux->sueldo;
				p->edad = aux->edad;
			}
			j = j->siguiente;
		}
		p = p->siguiente;
	}
}
void mostrarlistatipo()
{
	int tipo = 0;
	
	cout << "Ingrese el tipo de empleado que desea buscar.\n1. Temporal\n2. Fijo\n3. Por Hora\n";
	cin >> tipo;
	int conta = 1;
	NodoLista* actual = new NodoLista();
	actual = primero;
	if (primero != NULL&& stoi(actual->tipo)== tipo)
	{
		while (actual != NULL && stoi(actual->tipo)== tipo)
		{
			cout << "Nombre: " << actual->nombre << ", Edad " << actual->edad << "\n";
			actual = actual->siguiente;
			conta++;
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}
void OrdenarSueldoyTipo()
{
	NodoLista *p = primero;
	NodoLista *aux = new NodoLista();
	while (p != NULL)
	{
		NodoLista *j = p->siguiente;

		while (j != NULL)
		{
			if (p->sueldo < j->sueldo)
			{
				aux->nombre = j->nombre;
				aux->tipo = j->tipo;
				aux->sueldo= j->sueldo;
				aux->edad = j->edad;
				
				j->nombre = p->nombre;
				j->tipo = p->tipo;
				j->sueldo= p->sueldo;
				j->edad = p->edad;


				p->nombre = aux->nombre;
				p->tipo = aux->tipo;
				p->sueldo = aux->sueldo;
				p->edad = aux->edad;
			}
			j = j->siguiente;
		}
		p = p->siguiente;
	}

	int tipo = 0;
	cout << "Ingrese el tipo de empleado\n";
	cin >> tipo;
	int conta = 1;
	NodoLista* actual = new NodoLista();
	actual = primero;
	if (primero != NULL)
	{
		while (actual != NULL && stoi(actual->tipo) == tipo)
		{
			cout << "Nombre: " << actual->nombre << ", Sueldo " << actual->sueldo<< "\n";
			actual = actual->siguiente;
			conta++;
		}
		system("pause");
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}