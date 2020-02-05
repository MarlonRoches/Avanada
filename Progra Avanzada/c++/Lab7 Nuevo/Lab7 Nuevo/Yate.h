#pragma once
#include "Barco.h"
#include<iostream>
using namespace std;
class Yate :
	public Barco
{
public:
	Yate();
	void Datos();
	~Yate();
public:
	int potencia;
	int camarotes;
};

