// Lista Circular Simple.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>

using namespace std;
struct nodo
{
	int dato;
	nodo *siguiente;
	
}*primero, *ultimo;

int main()
{
    std::cout << "Hello World!\n"; 
}


void InsertarNodo()
{
	nodo* nuevo = new nodo();
	cout << "Ingrese El dato del nuevo nodo \n";
	cin >> nuevo->dato;

	if (primero == NULL)
	{
		primero = nuevo;
		primero->siguiente = primero;
		ultimo = primero;
	}
	else
	{
		ultimo->siguiente = nuevo;
		nuevo->siguiente = primero;
		ultimo = nuevo;
	}
}

void buscar()
{
	nodo* actual = new nodo();
	actual = primero;
	bool encontrado = false;
	int nodobuscado = 0;
	cout << "INgrese el nodo a buscar \n";
	cin >> nodobuscado;
	if (primero != NULL)
	{
		while (actual != primero && encontrado != true)
		{
			if (actual->dato == nodobuscado)
			{

				cout << "Nodo con el dato buscado, encontrado";
				encontrado = true;
			}
			actual = actual->siguiente;
		}
		if (!encontrado)
		{
			cout << "\n Nodo no encontrado";
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}

void modificar()
{
	nodo* actual = new nodo();
	actual = primero;
	bool encontrado = false;
	int nodobuscado = 0;
	cout << "Ingrese el nodo a modificar \n";
	cin >> nodobuscado;
	if (primero != NULL)
	{
		while (actual != primero && encontrado != true)
		{
			if (actual->dato == nodobuscado)
			{

				cout << "Nodo con el dato buscado, encontrado";
				cout << "\n Ingrese el nuevo dato para este nodo";
				cin >> actual->dato;
				encontrado = true;
			}
			actual = actual->siguiente;
		}
		if (!encontrado)
		{
			cout << "\n Nodo no encontrado";
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}

void eliminar()
{
	nodo* actual = new nodo();
	actual = primero;
	nodo* anterior = new nodo();
	anterior = NULL;
	bool encontrado = false;
	int nodobuscado = 0;
	cout << "INgrese el nodo a eliminar \n";
	cin >> nodobuscado;
	if (primero != NULL)
	{
		while (actual != primero && encontrado != true)
		{
			if (actual->dato == nodobuscado)
			{
				cout << "Nodo con el dato buscado, Encontrado";

				if (actual == primero)
				{
					primero = primero->siguiente;
					ultimo->siguiente = primero;
				}
				else if (actual == ultimo)
				{
					anterior->siguiente = primero;;
					ultimo = anterior;
				}
				else
				{
					anterior->siguiente = actual->siguiente;
				}
				cout << "\n Nodo con el dato buscado, eliminado";

				encontrado = true;
			}
			anterior = actual;
			actual = actual->siguiente;
		}
		if (!encontrado)
		{
			cout << "\n Nodo no encontrado";
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}
