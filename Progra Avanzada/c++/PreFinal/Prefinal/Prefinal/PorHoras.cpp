#include "pch.h"
#include "PorHoras.h"


PorHoras::PorHoras()
{
}


PorHoras::~PorHoras()
{
}

void PorHoras::calcularsueldo(PorHoras* empleado)
{
	empleado->sueldo = preciodehora * horastrabajadas;
}


