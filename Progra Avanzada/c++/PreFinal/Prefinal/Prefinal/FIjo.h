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
	int a�odeentrada;
	int sueldobase;
	int complemento;
	int a�ostrabajados=2018;
	//metodos
	void calcularsueldo(FIjo*);
};

