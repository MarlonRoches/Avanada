#include "pch.h"
#include "Barco.h"
#include<iostream>
using namespace std;
Barco::Barco()
{
}
void Barco::modulofuncion()
{
	
	cout << "Ingrese la matricula del barco\n";
	cin >> matricula;
	cout << "Año del barco\n";
	cin >> año;
	cout << "Ingrese Total de Esloras\n";
	cin >> eslora;
}

Barco::~Barco()
{
}
