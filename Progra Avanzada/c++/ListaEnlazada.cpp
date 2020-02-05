#include "stdafx.h"
#include "ListaEnlazada.h"
#include <iostream>

using namespace std;


void ListaEnlazada::InsertarElementoInicio(int iDato)
{
	// creación y asignación de espacio al nuevo nodo
	Nodo *nNuevo = new Nodo;
	nNuevo->iNumero = iDato;
	nNuevo->siguiente = NULL;
	
	// inserto el nodo a la lista
	// validar si no está vacía

	if (inicio == NULL)
	{
		inicio = nNuevo;
		final = nNuevo;
	}
	else
	{
		nNuevo->siguiente = inicio;
		inicio = nNuevo;
	}
}

void ListaEnlazada::InsertarElementoFinal(int iDato)
{
	// creación y asignación de espacio al nuevo nodo
	Nodo *nNuevo = new Nodo;
	nNuevo->iNumero = iDato;
	nNuevo->siguiente = NULL;

	// inserto el nodo a la lista
	// validar si no está vacía

	if (inicio == NULL)
	{
		inicio = nNuevo;
		final = nNuevo;
	}
	else
	{
		final->siguiente = nNuevo;
		final = nNuevo;
	}
}

void ListaEnlazada::MostrarElementos()
{
	Nodo *nAux = inicio;

	while (nAux != NULL)
	{
		cout << nAux->iNumero << "-" << nAux << "-" << nAux->siguiente << "\n";
		nAux = nAux->siguiente;
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





ListaEnlazada::ListaEnlazada()
{
}


ListaEnlazada::~ListaEnlazada()
{
}
