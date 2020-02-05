#pragma once



struct sDatos
{
	int iNumero;
};

class Nodo
{
public:
	sDatos sInformacion;
	Nodo *izquierda;
	Nodo *derecha;
};

class ArbolBinario
{
public:

	Nodo *raiz;

	void InsertarElemento(sDatos psElemento);
	void MostrarElementos(int iOrden);
	sDatos BuscarElemento(int piCodigoElemento);
	void EliminarElemento(int piCodigoElemento);


	ArbolBinario();
	~ArbolBinario();
};

