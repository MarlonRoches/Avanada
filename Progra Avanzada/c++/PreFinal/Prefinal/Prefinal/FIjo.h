#pragma once
#include "Empleado.h"
class FIjo:

		public Empleado
	{
public:
	FIjo();
	~FIjo();
	double sueldohora;
	int horas;
	int aņodeentrada;
	int sueldobase;
	int complemento;
	int aņostrabajados=2018;
	//metodos
	void calcularsueldo(FIjo*);
};

