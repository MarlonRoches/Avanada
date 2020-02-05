#include "pch.h"
#include <iostream>
#include "Alquiler.h"
#include "Barco.h"
#include "Deportivo.h"
#include  "Velero.h"
#include  "Yate.h"
#include <string>
using namespace std;

Barco obarco = Barco();
Alquiler alquilo = Alquiler();
Yate byate = Yate();
Deportivo bdeportivo = Deportivo();
Velero bvelero = Velero();
int main()
{
	int menu, total;
	string aux;
	cout << "---------Menu----------" << endl;
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
		//velero
		bvelero.modulofuncion();
		bvelero.Datos();
		bvelero.matricula = obarco.matricula;
		
		
		total = alquilo.dias * bvelero.eslora*1.5;
		
		cout << "El velero con el numero de matricula " << bvelero.matricula << " modelo: " << bvelero.año << " con mastiles: " << bvelero.mastiles << ", se quedara durante " << alquilo.dias << " con un costo de $." << total << ".00" << endl;


		break;
	case 2:
		alquilo.diasporestar();
		//deportivos
		bdeportivo.Datos();
		bdeportivo.modulofuncion();
		bdeportivo.matricula = obarco.matricula;
	
		total = alquilo.dias * bdeportivo.eslora*1.5;
		
		
		cout << "El deportivo con el numero de matricula " << bdeportivo.matricula << " modelo: " << bdeportivo.año << " con la potencia en CV de: " << bdeportivo.potencia << ", se quedara durante " << alquilo.dias << " con un costo de $." << total << ".00" << endl;
		break;
	case 3:
		alquilo.diasporestar();
		//yates
		byate.modulofuncion();
		byate.Datos();
		byate.matricula = obarco.matricula;
		
		total = alquilo.dias * byate.eslora*1.5;
		cout << "El yate con el numero de matricula " << byate.matricula << " con la cantidad de camarotes  " << byate.camarotes << " con la potencia en CV de: " << byate.potencia << ", se quedara durante " << alquilo.dias << " con un costo de $." << total << ".00" << endl;

		break;
	case 4:
		cout << "==========================  MODULO ESPECIAL  ================================ \n";
		cout << "Ingrese tipo de barco\n";
		cout << "1.Velero\n";
		cout << "2.Deportivo\n";
		cout << "3.Yate\n";
		cin >> menu;		
		
		switch (menu)
		{

		case 1:

			alquilo.diasporestar();
			//velero
			bvelero.modulofuncion();
			bvelero.matricula = obarco.matricula;
			bvelero.Datos();
			total = alquilo.dias * bvelero.eslora*1.5;
			
			cout << "El velero especial con el numero de matricula " << bvelero.matricula << " modelo no." << bvelero.año << " con mastiles: " << bvelero.mastiles << ", se quedara durante " << alquilo.dias << " con un costo de $." << total << ".00" << endl;

			break;
		case 2:
			alquilo.diasporestar();
			//deportivos
			bdeportivo.Datos();
			bdeportivo.modulofuncion();
			bdeportivo.matricula = obarco.matricula;
		
			total = (alquilo.dias * bdeportivo.eslora*1.5) + 2.5;


			cout << "El deportivo especial con el numero de matricula " << bdeportivo.matricula << " con la potencia en CV de: " << bdeportivo.potencia << ", se quedara durante " << alquilo.dias << " con un costo de $." << total << ".00" << endl;
			break;
		case 3:
			alquilo.diasporestar();
			//yates
			byate.modulofuncion();
			byate.Datos();
			byate.matricula = obarco.matricula;

			total = (alquilo.dias * byate.eslora*1.5) +3.5;
			
			cout << "El yate especial con el numero de matricula " << byate.matricula << " con la cantidad de camarotes  " << byate.camarotes << " con la potencia en CV de: " << byate.potencia << ", se quedara durante " << alquilo.dias << " con un costo de $." << total << ".00" << endl;

			break;

		default:
			break;
		}
		break;
	default:
		break;
	}

	



}
