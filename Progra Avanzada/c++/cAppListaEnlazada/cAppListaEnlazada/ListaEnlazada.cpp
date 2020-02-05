#include "stdafx.h"
#include "ListaEnlazada.h"
#include <iostream>

using namespace std;


void ListaEnlazada::InsertarElementoInicio(sDatos psElemento)
{
	// creación y asignación de espacio al nuevo nodo
	Nodo *nNuevo = new Nodo;
	nNuevo->sInformacion.iNumero = psElemento.iNumero;
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

void ListaEnlazada::InsertarElementoFinal(sDatos psElemento)
{
	// creación y asignación de espacio al nuevo nodo
	Nodo *nNuevo = new Nodo;
	nNuevo->sInformacion.iNumero = psElemento.iNumero;
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

void ListaEnlazada::MostrarElementos(int iOrden)
{
	Nodo *nAux = inicio;

	while (nAux != NULL)
	{
		cout << nAux->sInformacion.iNumero << "-" << nAux << "-" << nAux->siguiente << "\n";
		nAux = nAux->siguiente;
	}

}

sDatos ListaEnlazada::BuscarElemento(int piCodigoElemento){
	Nodo *auxiliar = inicio;
	bool bandera = false;
	while (auxiliar != NULL && bandera == false)
	{
		if (auxiliar->sInformacion.iNumero == piCodigoElemento)
		{			
			bandera = true;
		}
		else
		{
			auxiliar = auxiliar->siguiente;
		}
	}
	return auxiliar->sInformacion;
}




void ListaEnlazada::EliminarElemento(int piCodigoElemento){
	Nodo *actual = inicio;
	Nodo *anterior = NULL;
	bool encontrado = false;

	
	while (actual != NULL && encontrado != true){
		if (actual->sInformacion.iNumero == piCodigoElemento){
			if (actual == inicio){
				inicio = inicio->siguiente;
			}
			else if (actual == final){
				anterior->siguiente = NULL;
				final = anterior;
			}
			else {
				anterior->siguiente = actual->siguiente;


			}
			encontrado = true;
		}
		anterior = actual;
		actual = actual->siguiente;
		
	}
	if (!encontrado){
		cout << "nodo no encontrado, no eliminado" << endl;
		encontrado = false;
	}
}
ListaEnlazada::ListaEnlazada()
{
}

ListaEnlazada::~ListaEnlazada()
{
}
