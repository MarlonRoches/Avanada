#pragma once


struct sDatos
{
	int iNumero;
};

class Nodo
{
public:
	//INFORMACI�N
	int iNumero;
	Nodo *siguiente;
};

class ListaEnlazada
{
public:

	Nodo *inicio;
	Nodo *final;
	
	void InsertarElementoInicio(int iDato);
	void InsertarElementoFinal(int iDato);

	void MostrarElementos();

	ListaEnlazada();
	~ListaEnlazada();
};

