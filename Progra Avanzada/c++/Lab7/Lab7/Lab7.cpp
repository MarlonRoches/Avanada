#include "pch.h"
#include <iostream>
#include "Alquiler.h"
#include "Barco.h"
#include "Deportivo.h"

#include  "Velero.h"
#include  "Yate.h"
#include <string>
using namespace std;

Alquiler alquilo = Alquiler();
Yate byate = Yate();
Deportivo bdeportivo = Deportivo();
Velero bvelero = Velero();
int main()
{
	int 
		menu;
	string aux;
    cout << "---------Menu----------"<< endl;
	cout << "Ingrese tipo de barco\n";
	cout << "1.Velero\n";
	cout << "2.Deportivo\n";
	cout << "3.Yate\n";
	cout << "4.Especial\n";
	cin >> menu;
	switch (menu)
	{
	case 1:
		alquilo.diasporestar();

		break;
	case 2:
		break;
	case 3:
		break;
	case 4:
		break;
	default:
		break;
	}




}
