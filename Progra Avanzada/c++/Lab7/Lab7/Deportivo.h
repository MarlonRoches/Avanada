#pragma once
#include "Barco.h"
class Deportivo :
	public Barco
{
public:
	Deportivo();

	~Deportivo();

protected:
	int potencia;
};

