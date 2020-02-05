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
	int añodeentrada;
	int sueldobase;
	int complemento;
	int añostrabajados=2018;
	//metodos
	void calcularsueldo(FIjo*);
};

