#pragma once

#include <string>

using namespace std;

class cEmpleado
{
protected:
	string nombre;
	int edad;
	int dui;
	float sueldo;
	float sueldo_final;


public:
	cEmpleado();
	~cEmpleado();

	void setDatos(string pNombre, int pEdad, int pDui, float sueldo);	
	string getNombre();
	int getEdad();
	int getDui();
	float getsueldo();


};

