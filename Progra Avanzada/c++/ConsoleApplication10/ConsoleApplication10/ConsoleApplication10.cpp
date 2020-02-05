// ConsoleApplication10.cpp : Defines the entry point for the console application.
//


#include "stdafx.h"
#include "cEmpleadoHora.h"
#include <fstream>
#include <iostream>

using namespace std;
int main()
{
	string linea_archivo;
		int iPosicionEncuentra, iPosicionAnterior = 0;
	ifstream ArchivoCarga("test.txt");

	string sPrimera, sSegunda, sTercera;

	while (!ArchivoCarga.eof())
	{
		//lectura archivo
		getline(ArchivoCarga, linea_archivo);


		//separacion de campos
		iPosicionEncuentra = linea_archivo.find("|");
		sPrimera = linea_archivo.substr(0, iPosicionEncuentra);
		cout << sPrimera << endl;


		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|",iPosicionEncuentra + 1);
		sSegunda = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior)-1);
		cout << sSegunda << endl;


		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		sSegunda = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		cout << sTercera<< endl;

		/*miEmpleado.setDatos(sPrimera, sSegunda, sTercera);*/


		

		//cout << linea_archivo << endl;
		//cout << sPrimera << endl;
		//cout << sSegunda << endl;
		//cout << sTercera << endl;


		//cout << linea_archivo << endl;
		//cout << linea_archivo.find("|") << endl;
		//cout << linea_archivo.substr(0, linea_archivo.find("|")) << endl;
		//


		
	}


	//miEmpleado.setDatos("Fernando", 20, 12345, 2.50);
	//miEmpleado.setDatosHora(5, 5.5);
	//
	//miEmpleado.pCalculaSueldo();

	//cout << miEmpleado.getNombre();
	//cout << miEmpleado.getSueldo();


	return 0;
}

