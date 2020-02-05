#include "stdafx.h"
#include "cEmpleado.h"


cEmpleado::cEmpleado()
{
}


void cEmpleado::setDatos(string pNombre, int pEdad, int pDui, float pSueldo)
{
	cEmpleado::nombre = pNombre;
	cEmpleado::edad = pEdad;
	cEmpleado::dui = pDui;
	cEmpleado::sueldo = pSueldo;
}

string cEmpleado::getNombre()
{
	return cEmpleado::nombre;
}

int cEmpleado::getEdad()
{
	return cEmpleado::edad;
}

int cEmpleado::getDui()
{
	return cEmpleado::dui;
}

float cEmpleado::getsueldo()
{
	return cEmpleado::sueldo;
}

cEmpleado::~cEmpleado()
{
}



