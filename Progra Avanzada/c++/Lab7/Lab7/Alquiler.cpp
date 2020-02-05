#include "pch.h"
#include "Alquiler.h"
#include <iostream>
using namespace std;
Alquiler::Alquiler()
{
}

void Alquiler::valoralquiler()
{

}

void Alquiler:: diasporestar()
{
	
	cout << "Ingrese dia de entrada\n";
	cin >> diaentrada;
	cout << "Ingrese mes de entrada\n";
	cin >> mesentrada;
	cout << "Ingrese dia de salida\n";
	cin >> diasalida;
	cout << "Ingrese mes de salida\n";
	cin >> messalida;
	dias = (diaentrada - diasalida) + ((mesentrada * 30) - (messalida * 30));
		if (dias <0)
		{
			dias = dias * -1;
		}



}

Alquiler::~Alquiler()
{
}
