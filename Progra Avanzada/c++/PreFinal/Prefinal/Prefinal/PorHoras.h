#pragma once
#include "Empleado.h"
class PorHoras :
	public Empleado
{
public:
	PorHoras();
	~PorHoras();
	//variables propias de la clase EMpleado por Hora
	int preciodehora;
	int horastrabajadas;
	//metodos
	void calcularsueldo(PorHoras*);
};

