#pragma once
#include "Empleado.h"
class Temporal :
	public Empleado
{
public:
	Temporal();
	~Temporal();
	//variables propias de la clase temporal
	string a�oingreso;
	string a�osalida;
	int sueldofijo;
	//metodos
	void calcularsueldo(Temporal*);
};

