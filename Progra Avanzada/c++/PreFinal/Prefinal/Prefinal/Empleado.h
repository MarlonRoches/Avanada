#pragma once
#include <string>
using namespace std;
class Empleado
{
public:
	Empleado();
	~Empleado();
	//Variables en comun a heredar por las demas clases
	string nombre;
	int edad;
	string DIU; 
	string tipo;
	int sueldo;
};

