#pragma once


struct sDatos
{
	int iNumero;
	char cLetra;
	bool bBuscar;
	bool bEncontrado;
};

class Nodo
{
public:
	sDatos sInformacion;
	Nodo *siguiente;
	Nodo *anterior;
};


class ListaDobleEnlazada
{

	Nodo *inicio;
	Nodo *final;



public:
	ListaDobleEnlazada();
	~ListaDobleEnlazada();

	void InsertarElementoInicio(sDatos psElemento);
	void InsertarElementoFinal(sDatos psElemento);

	void BuscarPivote(char cBuscar, char cPivote);

	// mostrar desde el inicio o desde el final
	void MostrarElementos(int iOrden);

	sDatos BuscarElemento(int piCodigoElemento);

	void EliminarElemento(int piCodigoElemento);

};

