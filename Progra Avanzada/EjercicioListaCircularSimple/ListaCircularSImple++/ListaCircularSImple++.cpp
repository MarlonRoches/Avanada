

#include "pch.h"
#include <iostream>

using namespace std;
struct nodo
{
	int dato;
	nodo *siguiente;
}*primero, *ultimo;

void InsertarNodo();
void ImprimirLista();
int main()
{
    cout << "Hello World!\n"; 
}

void InsertarNodo()
{
	nodo *nuevo = new nodo();
	cout << "Ingrese un dato \n";
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
	cout << "Nodo ingresado";
}

void ImprimirLista()

{
	nodo *actual = new nodo();

	actual = primero;
	if (primero != NULL)
	{
		do
		{
			cout << "\n" << actual->dato;
			actual
 = actual->siguiente;
		} while (actual!= primero );
	}
	else

	{
		cout << "Laa lista esta vacia";
	}
}

void BuscarNodo()
{
	nodo *actual = new nodo();
	actual = primero;
	bool encontrado = false;
	int nodobuscado=0;
	cout << "ngrese el elemento a ser buscado";
	cin >> nodobuscado;
	if (primero != NULL)
	{
		do
		{

			if (actual->dato == nodobuscado)
			{
				cout << "\n El nodo con el dato" << nodobuscado << " Encontrado\n\n";
				encontrado = true;
			}

			actual = actual->siguiente;
		} while (actual != primero && encontrado != true );

		if (!encontrado)
		{
			cout << "Nodo no encontrado\n\n";
		}
	}
	else
	{
		cout << "Lista vacia 
\n\n";
	}
}

void EliminarNodo()
{
	nodo *actual = new nodo();
	actual = primero;
	nodo *anterior = new nodo();
	actual = NULL;
	bool encontrado = false;
	int nodobuscado = 0;
	cout << "ngrese el elemento a ser eliminado";
	cin >> nodobuscado;
	if (primero != NULL)
	{
		do
		{

			if (actual->dato == nodobuscado)
			{
				cout << "\n El nodo con el dato" << nodobuscado << " Encontrado\n\n";



				if (actual== primero)
				{
					primero = primero->siguiente;
					ultimo->siguiente = primero;
				}
				else if (actual == ultimo )
				{
					anterior->siguiente = primero;
					ultimo = anterior;
				}
				else
				{
					anterior->siguiente = actual->siguiente;
				}
				encontrado = true;
			}

			actual = actual->siguiente;
		} while (actual != primero && encontrado != true);

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