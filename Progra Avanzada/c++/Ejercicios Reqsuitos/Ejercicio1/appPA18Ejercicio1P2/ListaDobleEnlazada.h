#pragma once

struct sDatos
{
	int iNumero;
	char cLetra;
	bool bPivote;
	bool bEncuentra;

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

	void InsertarElementoInicio(sDatos psElemento);
	void InsertarElementoFinal(sDatos psElemento);

	// mostrar desde el inicio o desde el final
	void MostrarElementos(int iOrden);

	void MarcarPivoteBuscar(char cPivote, char cBuscar);

	ListaDobleEnlazada();
	~ListaDobleEnlazada();
};

