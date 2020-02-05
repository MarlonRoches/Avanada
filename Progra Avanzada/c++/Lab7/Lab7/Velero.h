#pragma once
#include "Barco.h"

using namespace std;
class Velero :
	public Barco
{
public:
	Velero();
	~Velero();
	void ModuloFuncion();
protected:
	int mastiles;
	 
};

