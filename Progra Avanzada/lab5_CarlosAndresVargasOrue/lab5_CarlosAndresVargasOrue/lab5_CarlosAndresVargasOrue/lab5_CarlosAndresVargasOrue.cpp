// lab5_CarlosAndresVargasOrue.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include "CadenaPlus.h"
#include <stdio.h>
#include <iostream>
using namespace std;

CadenaPlus cPrincipal;

char sDato[50];

int main()
{
	int num;
	cout << "Ingrese palabras" << '\0';
	cin.getline(sDato, 200);
	cout << "Ingrese numero" << '\0';
	cin >> num;
	cout << "Ingrese el caracter" << '\0';
	char caracter;
	cin >> caracter;
	cPrincipal.pCadena = sDato;
	cout << cPrincipal.ejercicio( caracter,  num);

	/*cout << '\0';
	cout << "ingrese la palabra que desea voltear";
	cin.getline(sDato, 50);
	cPrincipal.pCadenaPrincipal = sDato;
	cout << cPrincipal.cadenaReves();*/

    return 0;
}

