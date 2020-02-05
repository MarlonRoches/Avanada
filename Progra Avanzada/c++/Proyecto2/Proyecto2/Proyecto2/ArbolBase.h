#pragma once
#include "Arbol.h"
#include "pch.h"
#include "CargaDatos.h"
#include <iostream>
#include<fstream>
#include <stdlib.h>
#include <string>
#include <vector>
using namespace std; class ArbolBase:
	public Arbol

{
public:
	ArbolBase();
	~ArbolBase();
	void lectura();
	Nodo *crearNodo(int, Nodo *);
	void insertarNodo(Nodo *&, int, Nodo *);
	void mostrarArbol(Nodo *, int);
	bool busqueda(Nodo *, int);
	void preOrden(Nodo *);
	void inOrden(Nodo *);
	void postOrden(Nodo *);
	void eliminarNodo(Nodo *);
	void eliminar(Nodo *, int);
	Nodo *minimo(Nodo *);
	void reemplazar(Nodo *, Nodo*);
	void deshacerNodo(Nodo *);
};

