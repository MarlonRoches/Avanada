// appPA18Ejercicio1P2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <string.h>
#include <iostream>
#include <string>
#include "ListaDobleEnlazada.h"


using namespace std;

string sLinea;
ListaDobleEnlazada miListita;

int main()
{
	cout << "Ingrese cadena a validar: \n";
	getline(cin, sLinea, '\n');

	sDatos sMiInfo;
	
	
	for (int i = 0; i < sLinea.length() -2; i++)
	{
		sMiInfo.cLetra = sLinea[i];
		miListita.InsertarElementoFinal(sMiInfo);
	}

	miListita.MarcarPivoteBuscar(sLinea[sLinea.length() - 2], sLinea[sLinea.length() - 1]);

	miListita.MostrarElementos(1);


	
	return 0;
}

