#include "pch.h"
#include <iostream>
#include<stdlib.h>
#include<ctime>
#include <cmath>
#include<time.h>
#include<stdlib.h>
using namespace std;


struct Nodo {
	int dato;
	Nodo *der;
	Nodo *izq;
	Nodo *padre;
};

struct lnodo
{
	int dato;
	lnodo *siguiente;

}*primero, *ultimo;

Nodo *Arbol = NULL;
//Prototipos
Nodo *crearNodo(int, Nodo *);
void insertarNodo(Nodo *&, int, Nodo *);
void mostrarArbol(Nodo *, int);
void mostrarPadres(Nodo *);
bool busqueda(Nodo *, int);
void preOrden(Nodo *);
void inOrden(Nodo *);
void postOrden(Nodo *);
int num = 0;
double valor = 0;
void mostrarPadres(Nodo *arbolRecorre)
{
	if (arbolRecorre == NULL)
	{
		return;
	}
	else
	{
		if (arbolRecorre->izq  != NULL || arbolRecorre->der != NULL)
		{
			try
			{
				cout << arbolRecorre->dato << " Padre de " << arbolRecorre->der << " y " << arbolRecorre->izq << "\n";
			}
			catch (const std::exception&)
			{

			}

			
			
		}
		mostrarPadres(arbolRecorre->izq);
		mostrarPadres(arbolRecorre->der);
	}

}

int main()
{
	
    cout << "Parcial #2 Marlon Roches 12509-18 \n"; 

	int dato, opcion, contador = 0, contadorNodo = 0;
	
		

		insertarNodo(Arbol, 10, NULL);
		insertarNodo(Arbol, 7, NULL);
		insertarNodo(Arbol, 9, NULL);
		insertarNodo(Arbol, 8, NULL);
		insertarNodo(Arbol, 4, NULL);
		insertarNodo(Arbol, 3, NULL);
		insertarNodo(Arbol, 2, NULL);
		insertarNodo(Arbol, 14, NULL);
		insertarNodo(Arbol, 27, NULL);
		insertarNodo(Arbol, 5, NULL);
		insertarNodo(Arbol, 6, NULL);
		insertarNodo(Arbol, 16, NULL);
	//for (int i = 0; i < 100; i++)
	//{
	//	srand(time(NULL));
	//	
	//	insertarNodo(Arbol, (num = 5000 + rand() % (10000 + 1 - 5000)), NULL);
	//}
		

		//Insertamos un nuevo nodo
		contadorNodo++;
		/*cout << "\nPeso actual del arbol es de: " << contadorNodo << " nodos";*/
		
		cout << "---------Arbol----------- \n";
		mostrarArbol(Arbol, contador);
		cout << "\n";
		cout << "\n";
	cout << "PreOrden \n";
	preOrden(Arbol); cout << "\n";
	cout << "\n";
	cout << "\n";

	
	cout << "----------Padres----------------\n"; 
	mostrarPadres(Arbol);
	cout << "\n";
	
	
	
	
	
	
	
	system("pause");
	
	
	
	
	
	
	return 0;
}



Nodo *crearNodo(int n, Nodo *padre)
{
	Nodo *nNuevo = new Nodo();

	nNuevo->dato = n;
	nNuevo->der = NULL;
	nNuevo->izq = NULL;
	nNuevo->padre = padre;

	return nNuevo;
}

void insertarNodo(Nodo *&arbolrecorre, int n, Nodo *padre)
{
	if (arbolrecorre == NULL) //Si el arbol esta vacio
	{
		Nodo *nNuevo = crearNodo(n, padre);
		arbolrecorre = nNuevo;
	}
	else //Significa que si tiene un nodo o mas
	{
		int valorRaiz = arbolrecorre->dato; //Obtenemos el valor de la raiz
		if (n < valorRaiz) //Si el elemento insertado es menor que la raiz, se va para la izquierda
		{
			insertarNodo(arbolrecorre->izq, n, arbolrecorre);
		}
		else //Si el elemento insertado es mayor a la raiz, insertar a la derecha
		{
			insertarNodo(arbolrecorre->der, n, arbolrecorre);
		}
	}
}


void mostrarArbol(Nodo *arbolRecorre, int cont)
{
	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		return;
	}
	else
	{
		mostrarArbol(arbolRecorre->der, cont + 1);
		for (int i = 0; i < cont; i++)
		{
			cout << "   ";
		}
		cout << arbolRecorre->dato << endl;

		mostrarArbol(arbolRecorre->izq, cont + 1);


	}
}

bool busqueda(Nodo *arbolRecorre, int n)
{
	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		return false;
	}
	else
	{
		if (arbolRecorre->dato == n) //Si el nodo es igual al elemento
		{
			return true;
		}
		else
		{
			if (n < arbolRecorre->dato)
			{
				return busqueda(arbolRecorre->izq, n);
			}
			else
			{
				return busqueda(arbolRecorre->der, n);
			}
		}
	}
}

void preOrden(Nodo *arbolRecorre)
{
	if (arbolRecorre == NULL)
	{
		return;
	}
	else
	{
		cout << arbolRecorre->dato << " - ";
		preOrden(arbolRecorre->izq);
		preOrden(arbolRecorre->der);
	}

}





void InsertarNodo()
{
	lnodo* nuevo = new lnodo();
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
	lnodo* actual = new lnodo();
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