#pragma once
#include "cEmpleado.h"
class cEmpleadoHora :
	public cEmpleado
{

protected:

	int horas_trabajadas;
	float precio_hora;

public:
	cEmpleadoHora();
	~cEmpleadoHora();


	void setDatosHora(int pHorasTrabajadas, float pPrecioHora);

	void pCalculaSueldo();

	float getSueldo();

};

