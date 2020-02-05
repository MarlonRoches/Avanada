#pragma once


struct sDatos
{
	int iNumero;	
};

class Nodo
{
public:	
	sDatos sInformacion;
	Nodo *siguiente;
};

class ListaEnlazada
{
public:

	Nodo *inicio;
	Nodo *final;
	


	void InsertarElementoInicio(sDatos psElemento);
	void InsertarElementoFinal(sDatos psElemento);
	
	// mostrar desde el inicio o desde el final
	void MostrarElementos(int iOrden);

	sDatos BuscarElemento(int piCodigoElemento);

	void EliminarElemento(int piCodigoElemento);

	ListaEnlazada();
	~ListaEnlazada();
};

