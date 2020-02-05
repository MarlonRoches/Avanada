#pragma once
#include <iostream>
using namespace std;
class Barco
{
	void ModuloFuncion();
protected:
		string matricula;
		int eslora;
		int año;
		double valor;
	
		
public:
	
	Barco();
	~Barco();
};

