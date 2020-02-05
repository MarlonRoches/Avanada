#pragma once
#include "Barco.h"
#include<iostream>
using namespace std;
class Deportivo :
	public Barco
{
public:
	Deportivo();
	void Datos();
	~Deportivo();
public:
	int potencia;
};

