#pragma once
#include "pch.h"
#include "CargaDatos.h"
#include <iostream>
#include<fstream>
#include <stdlib.h>
#include <string>
#include <vector>
using namespace std;
#include<string>
using namespace std;
class Arbol
{
public:
	Arbol();
	~Arbol();
	

	struct Nodo {
		int dato;
		string conferencia;
		string division;
		string ciudad;
		char posicion;
		int numero;
		string codigo;
		string nombre;
		int altura;
		int peso;
		int dia, mes, año;
		int potencia;
		int habilidad;
		int puntos;
		int robos;
		int rebotes;
		int tapones;
		int votacion;

		Nodo *der;
		Nodo *izq;
		Nodo *padre;
	};
};

