// cAppListaEnlazada.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "ArbolBinario.h"
#include <stdio.h>
#include <string.h>
#include <iostream>
#include <string>


using namespace std;


ArbolBinario arbolito;


int main()
{

	sDatos sMiInfo;

	sMiInfo.iNumero = 10;

	arbolito.InsertarElemento(sMiInfo);
	
	sMiInfo.iNumero = 5;

	arbolito.InsertarElemento(sMiInfo);

	sMiInfo.iNumero = 15;

	arbolito.InsertarElemento(sMiInfo);

	arbolito.MostrarElementos(1);


	return 0;
}

