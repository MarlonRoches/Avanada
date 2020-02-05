#include "pch.h"
#include <iostream>
#include<fstream>
#include <stdlib.h>
#include <string>

using namespace std;
struct NodoLista
{
	
	int dato;
	NodoLista *siguiente;
	NodoLista *atras;
}*primero, *ultimo;

struct NodoListaImpar
{

	int dato;
	NodoListaImpar *siguiente;
	NodoListaImpar *atras;
}*primeroI, *ultimoI;
string linea_archivo;
int iPosicionEncuentra, iPosicionAnterior = 0;
ifstream ArchivoCarga("datos.txt");
void CARGADATOS();
void InsertarNodo(NodoLista *);
void mostrarlista();
void InsertarNodoI(NodoLista *);
void mostrarlistaI();

int final = 0;
int main()
{
	CARGADATOS();
}
void CARGADATOS()
{
	while (!ArchivoCarga.eof())
	{
		
		NodoLista *auxiliar = new NodoLista();
		/*cout << "==================================NODO NUM.	" << contador <<"=======================" <<endl;*/
		//lectura archivo
		getline(ArchivoCarga, linea_archivo);
		//SPLIT
		//dato
		final = linea_archivo.length();
		auxiliar->dato = stoi(linea_archivo.substr(0,final));
		cout << "numero:" << auxiliar->dato<<endl;
		InsertarNodo(auxiliar);
	}
	system("CLS");
	mostrarlista();
	system("pause");
}
void InsertarNodo(NodoLista *dato)
{
	NodoLista* nuevo = new NodoLista();

	nuevo->dato = dato->dato;
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
	int indice = 1;
	NodoLista* actual = new NodoLista();
	actual = primero;
	if (primero != NULL)
	{
		while (actual != NULL)
		{
			cout << "Dato En bruto: " << actual->dato << ", indice no." << indice << "         ---------->";
			if (indice % 2 ==0)
			{

			}
			else
			{
				cout << "	Dato: " << actual->dato << ", indice impar no."<<indice;
			}
			cout << endl;
			actual = actual->siguiente;
			indice++;
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}


void InsertarNodoI(NodoListaImpar *dato)
{
	NodoLista* nuevo = new NodoLista();

	nuevo->dato = dato->dato;
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
	int indice = 1;
	NodoListaImpar* actual = new NodoListaImpar();
	actualI = primeroI;
	if (primero != NULL)
	{
		while (actual != NULL)
		{
				cout << "	Dato: " << actual->dato << ", indice impar no." << indice;
			cout << endl;
			actual = actual->siguiente;
			indice= indice+2;
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}