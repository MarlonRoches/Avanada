#include "stdafx.h"
#include <stdio.h>
#include <string.h>
#include <iostream>
#include "ArbolBinario.h"


using namespace std;

ArbolBinario::ArbolBinario()
{
}


void insertarArbol(Nodo **pnArbol, sDatos psElemento)
{
	if (*pnArbol == NULL)
	{
		Nodo *nNuevo = new Nodo;
		nNuevo->sInformacion.iNumero = psElemento.iNumero;
		nNuevo->derecha = NULL;
		nNuevo->izquierda = NULL;
		*pnArbol = nNuevo;
	}
	else
	{
		//mayor es a la derecha
		//menor es a la izquierda
		     
		if (psElemento.iNumero < (*pnArbol)->sInformacion.iNumero) // me voy a la izquierda
		{
			insertarArbol(&((*pnArbol)->izquierda), psElemento);
		}
		else
		{
			insertarArbol(&((*pnArbol)->derecha), psElemento);
		}
	}
}

void ArbolBinario::InsertarElemento(sDatos psElemento)
{
	insertarArbol(&raiz, psElemento);
}

void postOrden(Nodo *nNodo)
{
	if (nNodo != NULL)
	{
		postOrden(nNodo->izquierda);
		postOrden(nNodo->derecha);
		cout << nNodo->sInformacion.iNumero << "-";

	}
}

void preOrden(Nodo *nNodo)
{
	if (nNodo != NULL)
	{
		cout << nNodo->sInformacion.iNumero << "-";
		preOrden(nNodo->izquierda);
		preOrden(nNodo->derecha);
	}
}


void enOrden(Nodo *nNodo)
{
	if (nNodo != NULL)
	{
		
		enOrden(nNodo->izquierda);
		cout << nNodo->sInformacion.iNumero << "-";
		enOrden(nNodo->derecha);
	}
}


void ArbolBinario::MostrarElementos(int iOrden)
{
	switch (iOrden)
	{
	case 1: postOrden(ArbolBinario::raiz);  break;
	case 2: preOrden(ArbolBinario::raiz);  break;
	case 3: enOrden(ArbolBinario::raiz);  break;
	}

	
}



ArbolBinario::~ArbolBinario()
{
}
