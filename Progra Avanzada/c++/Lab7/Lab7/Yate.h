#pragma once
#include "Barco.h"
class Yate :
	public Barco
{
public:
	Yate();
	void ModuloFuncion();
	~Yate();

protected:
	int potencia;
	int camarotes;
};

