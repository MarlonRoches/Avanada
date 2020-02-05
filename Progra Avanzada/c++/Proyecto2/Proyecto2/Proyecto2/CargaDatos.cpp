#include "pch.h"
#include "CargaDatos.h"
#include <iostream>
#include<fstream>
#include <stdlib.h>
#include <string>
#include <vector>
using namespace std;

CargaDatos::CargaDatos()
{
}

void CargaDatos::lectura()
{
	ifstream filedata;
	string linea;
	vector<string> vlinea;

	filedata.open("datos.txt");

	if (!filedata)
	{
		cout << "Archivo No encontrado";

		exit(1);
	}
	else
	{
		while (getline(filedata,linea))
		{
			linea.back() = '-';
			do
			{
 				rsize_t found = linea.find("|");
				vlinea.push_back((linea.substr(0,found)));
				linea = linea.substr((found +1) ,linea.size());
			
			} while (linea != "");


			//agregarmetodo del arbol

			if (vlinea[2]=="sassa")
			{

			}
		}
		filedata.close();

	}
}

CargaDatos::~CargaDatos()
{
}
