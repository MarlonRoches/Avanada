

#include "pch.h"
#include <iostream>
using namespace std;

struct Nodo
{
	int dato;
	Nodo *siguiente;
	Nodo *atras;
}*Primero,*Ultimo;
void InsertarNodo();
void DesplegarListaPrimeroPU();
void DesplegarListaPrimeroUP();
//FALTA ELIMINAR Y BUSCAR

int main()
{
	
	cout << "Hello World!\n"; 
}


void DesplegarListaPrimeroPU()
{
	Nodo *Actual = new Nodo();
	Actual = Primero;
	if (Primero != NULL)
	{
		while (Actual != NULL)
		{
			cout << "\n" << Actual->dato;
			Actual = Actual->siguiente;	
		}
	
	}
	else
	{
		cout << "La Lista esta vacia";
	}
	
}
void DesplegarListaPrimeroUP()
{
	Nodo *Actual = new Nodo();
	Actual = Ultimo;
	if (Primero != NULL)
	{
		while (Actual != NULL)
		{
			cout << "\n" << Actual->dato;
			Actual = Actual->atras;
		}

	}
	else
	{
		cout << "La Lista esta vacia";
	}
}

void InsertarNodo()
{
	Nodo *nuevo = new Nodo();
	cout << "Ingresar el dato que contendra el nuevo nodo";
	cin >> nuevo ->dato;

	if (Primero == NULL)
	{
		Primero = nuevo;
		Primero->siguiente = NULL;
		Primero->atras = NULL;
		Ultimo = Primero;
	}
	else
	{
		Ultimo->siguiente = nuevo;
		nuevo->siguiente = NULL;
		nuevo->atras = Ultimo;
		Ultimo = nuevo;
	}
	cout << "Nodo Ingresado";
}

void BuscarNodo()
{
	Nodo *actual = new Nodo();
	actual = Primero;
	bool encontrado = false;
	int nodobuscado = 0;
	cout << "ngrese el elemento a ser buscado";
	cin >> nodobuscado;
	if (Primero != NULL)
	{
		do
		{

			if (actual->dato == nodobuscado)
			{
				cout << "\n El nodo con el dato" << nodobuscado << " Encontrado\n\n";
				encontrado = true;
			}

			actual = actual->siguiente;
		} while (actual != Primero && encontrado != true);

		if (!encontrado)
		{
			cout << "Nodo no encontrado\n\n";
		}
	}
	else
	{
		cout << "Lista vacia \n\n";
	}
}

void EliminarNodo()
{
	Nodo *actual = new Nodo();
	actual = Primero;
	Nodo *anterior = new Nodo();
	actual = NULL;
	bool encontrado = false;
	int nodobuscado = 0;
	cout << "ngrese el elemento a ser eliminado";
	cin >> nodobuscado;
	if (Primero != NULL)
	{
		do
		{

			if (actual->dato == nodobuscado)
			{
				cout << "\n El nodo con el dato" << nodobuscado << " Encontrado\n\n";



				if (actual == Primero)
				{
					Primero = Primero->siguiente;
					Ultimo->siguiente = Primero;
				}
				else if (actual == Ultimo)
				{
					anterior->siguiente = Primero;
					Ultimo = anterior;
				}
				else
				{
					anterior->siguiente = actual->siguiente;
				}
				encontrado = true;
			}

			actual = actual->siguiente;
		} while (actual != Primero && encontrado != true);

		if (!encontrado)
		{
			cout << "Nodo no encontrado\n\n";
		}
	}
	else
	{
		cout << "Lista vacia \n\n";
	}
}