#include "stdafx.h"
#include "ListaDobleEnlazada.h"

#include <iostream>

using namespace std;


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

void ListaDobleEnlazada::MostrarElementos(int iOrden)
{
	Nodo *nAux = inicio;

	while (nAux != NULL)
	{
		cout << nAux->sInformacion.cLetra << "-" << nAux->sInformacion.bPivote << "-" << nAux->sInformacion.bEncuentra << "-" << nAux << "-" << nAux->siguiente << "-" << nAux->anterior << "\n";
		nAux = nAux->siguiente;
	}

}

void ListaDobleEnlazada::MarcarPivoteBuscar(char cPivote, char cBuscar)
{
	Nodo *nAux = inicio;
	bool bEncontrado = false;

	// recorrer la LDE para encontrar y marcar el pivote
	while ((nAux != NULL) && (bEncontrado == false))
	{
		if (nAux->sInformacion.cLetra == cPivote)
		{
			nAux->sInformacion.bPivote = true;
			bEncontrado = true;
		}
		else
		{
			nAux = nAux->siguiente;
		}
		
	}



	if (bEncontrado == true)
	{
		// recorrer a la derecha y marcar de encontrado
		Nodo *nAuxDer = nAux;

		while (nAuxDer != NULL)
		{
			if (nAuxDer->sInformacion.cLetra == cBuscar)
			{
				nAuxDer->sInformacion.bEncuentra = true;
			}
			nAuxDer = nAuxDer->siguiente;
		}

		// recorrer a la izquierda  y marcar de encontrado

		Nodo *nAuxIzq = nAux;

		while (nAuxIzq != NULL)
		{
			if (nAuxIzq->sInformacion.cLetra == cBuscar)
			{
				nAuxIzq->sInformacion.bEncuentra = true;
			}
			nAuxIzq = nAuxIzq->anterior;
		}


	}




}

ListaDobleEnlazada::ListaDobleEnlazada()
{
}


ListaDobleEnlazada::~ListaDobleEnlazada()
{
}
