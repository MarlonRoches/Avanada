#include "stdafx.h"
#include "cEmpleadoHora.h"


cEmpleadoHora::cEmpleadoHora()
{
}


cEmpleadoHora::~cEmpleadoHora()
{
}


void cEmpleadoHora::setDatosHora(int pHorasTrabajadas, float pPrecioHora)
{
	cEmpleadoHora::horas_trabajadas = pHorasTrabajadas;
	cEmpleadoHora::precio_hora = pPrecioHora;
	
}

void cEmpleadoHora::pCalculaSueldo()
{
	cEmpleado::sueldo_final = cEmpleadoHora::horas_trabajadas * cEmpleadoHora::precio_hora;
}

float cEmpleadoHora::getSueldo()
{
	return cEmpleado::sueldo_final;
}