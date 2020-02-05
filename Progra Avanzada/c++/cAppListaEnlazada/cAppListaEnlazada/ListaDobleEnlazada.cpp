#include "stdafx.h"
#include "ListaDobleEnlazada.h"
#include <iostream>

using namespace std;



void ListaDobleEnlazada::InsertarElementoInicio(sDatos psElemento)
{
	// creación y asignación de espacio al nuevo nodo
	Nodo *nNuevo = new Nodo;
	nNuevo->sInformacion.iNumero = psElemento.iNumero;
	nNuevo->sInformacion.cLetra = psElemento.cLetra;
	nNuevo->siguiente = NULL;
	nNuevo->anterior = NULL;

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
		inicio->anterior = nNuevo;
		inicio = nNuevo;
	}
}

void ListaDobleEnlazada::InsertarElementoFinal(sDatos psElemento)
{
	// creación y asignación de espacio al nuevo nodo
	Nodo *nNuevo = new Nodo;
	nNuevo->sInformacion.iNumero = psElemento.iNumero;
	nNuevo->sInformacion.cLetra = psElemento.cLetra;
	nNuevo->siguiente = NULL;
	nNuevo->anterior = NULL;

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
		nNuevo->anterior = final;
		final = nNuevo;
	}
}


void ListaDobleEnlazada::BuscarPivote(char cBuscar, char cPivote)
{
	Nodo *nAux = inicio;
	bool bEncuentraPivote = false;
	int iDerecha = 0, iIzquierda = 0;

	while ((nAux != NULL) && (bEncuentraPivote  == false))
	{
		if (nAux->sInformacion.cLetra == cPivote)
		{
			nAux->sInformacion.bBuscar = true;
			bEncuentraPivote = true;
		}
		else
		{
			nAux = nAux->siguiente;
		}		
	}

	// si lo encuentra, el apuntador queda en nAux

	if (bEncuentraPivote == true)
	{
		Nodo *nAuxDerecha = nAux;

		while (nAuxDerecha != NULL)
		{
			if (nAuxDerecha->sInformacion.cLetra == cBuscar)
			{
				nAuxDerecha->sInformacion.bEncontrado = true;
				iDerecha++;
			}
			nAuxDerecha = nAuxDerecha->siguiente;
		}

		// derecha

		Nodo *nAuxIzquierda = nAux;

		while (nAuxIzquierda != NULL)
		{
			if (nAuxIzquierda->sInformacion.cLetra == cBuscar)
			{
				nAuxIzquierda->sInformacion.bEncontrado = true;
				iIzquierda++;
			}
			nAuxIzquierda = nAuxIzquierda->anterior;
		}

		cout << iDerecha << endl;
		cout << iIzquierda << endl;

	}


}

void ListaDobleEnlazada::MostrarElementos(int iOrden)
{
	Nodo *nAux = inicio;

	while (nAux != NULL)
	{
		cout << nAux->sInformacion.cLetra << "-" << nAux << "-" << nAux->siguiente << "-" << nAux->anterior << "\n";
		nAux = nAux->siguiente;
	}

}

ListaDobleEnlazada::ListaDobleEnlazada()
{
}


ListaDobleEnlazada::~ListaDobleEnlazada()
{
}
