// ListaSimple++.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
using namespace std;

struct Nodo
{
	int dato;
	Nodo *siguiente;
};

int main()
{
}


void InsertarLista(Nodo *&lista, int n)
{
	Nodo *nuevo_nodo = new Nodo();//creando nuevo nodo
	nuevo_nodo->dato = n;


	Nodo *aux1 = lista;
	Nodo *aux2;

	while ((aux1 != NULL) && (aux1->dato < n)) //insertando ordenado
	{
		aux2 = aux1;
		aux1 = aux1->siguiente;
	}
	if (lista == aux1) //en el medio  final
	{
		lista = nuevo_nodo;
	}
	else
	{
		aux2->siguiente = nuevo_nodo;
	}
	nuevo_nodo->siguiente = aux1;


	cout<< "t\Elemento " << n<< " insertado  lista correctamente\n";
}

void MostrarLista(Nodo *lista)
{
	Nodo *actual = new Nodo();

	actual = lista;

	while (actual != NULL)

	{
		cout << actual->dato << " -> ";
		actual = actual->siguiente;
	}
}

void EliminarNodo(Nodo *&lista, int n)
{
	
	if (lista != NULL)
	{
		Nodo *aux_borrar;
		Nodo *anterior = NULL;
		aux_borrar = NULL;
		//recorrer la lista
		while ((aux_borrar != NULL) && (aux_borrar->dato != n))
		{
			anterior = aux_borrar;
			aux_borrar = aux_borrar->siguiente;
		}
		//elemento no encontrado
		if (aux_borrar == NULL)
		{
			cout << "El Elemento no existe";
		}
		else if (anterior == NULL) // el primer elemento sera eliminado
		{
			lista = lista->siguiente;
			delete aux_borrar;
		}
		else//elimina cualquiera que no sea el primero
		{
			anterior->siguiente = aux_borrar->siguiente;
			delete aux_borrar;
		}
	}
	
}