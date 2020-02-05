
#include "pch.h"
#include <iostream>
using namespace std;

struct nodo
{
	int dato;
	nodo *siguiente;
	nodo* atras;
}*primero, *ultimo;


void insertar();

int main()
{
   cout << "Hello World!\n"; 
}	

void insertar()
{
	nodo* nuevo = new nodo();
	cout << "INgrese dato";
	cin >> nuevo->dato;

	if (primero==NULL)
	{
		primero = nuevo;
		primero->siguiente = NULL;
		primero->atras = NULL;
		ultimo = primero;

	}
	else
	{
		ultimo->siguiente = nuevo;
		nuevo->siguiente = NULL;
		nuevo->atras = ultimo;
		ultimo = nuevo;
	}

}

void mostrarPU()
{
	nodo* actual = new nodo();
	actual = primero;
	if (primero!= NULL)
	{
		while (actual!=NULL)
		{
			cout << "\n" << actual->dato;
			actual = actual->siguiente;
		}
		
	}
	else
	{
		cout << "Lista vacia";
	}
}
void mostrarUP()
{
	nodo* actual = new nodo();
	actual = ultimo;
	if (primero!= NULL)
	{
		while (actual!=NULL)
		{
			cout << "\n" << actual->dato;
			actual = actual->atras
;
		}
		
	}
	else
	{
		cout << "Lista vacia";
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
		while (actual != NULL && encontrado != true)
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
		while (actual != NULL && encontrado != true)
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
		while (actual != NULL && encontrado != true)
		{
			if (actual->dato == nodobuscado)
			{
				cout << "Nodo con el dato buscado, Encontrado";

				if (actual == primero)
				{
					primero = primero->siguiente;
				}
				else if (actual == ultimo)
				{
					anterior->siguiente = NULL;
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
