#pragma once
#include "Barco.h"
#include<iostream>
using namespace std;
class Velero :
	public Barco
{
public:
	Velero();
	void Datos();
	~Velero();
	
public:
	int mastiles;
	
};

