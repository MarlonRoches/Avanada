#include <cstdlib>
#include "pch.h"
#include <iostream>
using namespace std;

struct nodo {
	int numero;
	struct nodo *dd, *der;
};

typedef struct nodo *ArbolBinario;

ArbolBinario crearNodo(int x)
{
	ArbolBinario nuevoNodo = new(struct nodo);
	nuevoNodo->numero = x;
	nuevoNodo->dd = NULL;
	nuevoNodo->der = NULL;

	return nuevoNodo;
}
void insertar(ArbolBinario &arbol, int x)
{
	if (arbol == NULL)
	{
		arbol = crearNodo(x);
	}
	else if (x < arbol->numero)
		insertar(arbol->dd, x);
	else if (x > arbol->numero)
		insertar(arbol->der, x);
}

void preOrden(ArbolBinario arbol)
{
	if (arbol != NULL)
	{
		cout << arbol->numero << " ";
		preOrden(arbol->dd);
		preOrden(arbol->der);
	}
}

void enOrden(ArbolBinario arbol)
{
	if (arbol != NULL)
	{
		enOrden(arbol->dd);
		cout << arbol->numero << " ";
		enOrden(arbol->der);
	}
}

void postOrden(ArbolBinario arbol)
{
	if (arbol != NULL)
	{
		postOrden(arbol->dd);
		postOrden(arbol->der);
		cout << arbol->numero << " ";
	}
}

void verArbol(ArbolBinario arbol, int n)
{
	if (arbol == NULL)
		return;
	verArbol(arbol->der, n + 1);

	for (int i = 0; i < n; i++)
		cout << "   ";

	cout << arbol->numero << endl;

	verArbol(arbol->dd, n + 1);
}

int main()
{
	ArbolBinario arbol = NULL;   // creado Arbol

	int n;  // numero de nodos del arbol
	int x; // elemento a insertar en cada nodo

	cout << "\n\t\t  ..[ ARBOL BINARIO DE BUSQUEDA ]..  \n\n";

	cout << " Numero de nodos del arbol:  ";
	cin >> n;
	cout << endl;

	for (int i = 0; i < n; i++)
	{
		cout << " Numero del nodo " << i + 1 << ": ";
		cin >> x;
		insertar(arbol, x);
	}

	cout << "\n Mostrando ArbolBinario \n\n";
	verArbol(arbol, 0);

	cout << "\n Recorridos del ArbolBinario";

	cout << "\n\n En orden   :  ";   enOrden(arbol);
	cout << "\n\n Pre Orden  :  ";   preOrden(arbol);
	cout << "\n\n Post Orden :  ";   postOrden(arbol);

	cout << endl << endl;

	system("pause");
	return 0;
}