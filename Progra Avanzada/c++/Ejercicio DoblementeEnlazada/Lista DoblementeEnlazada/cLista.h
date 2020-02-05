#pragma once
#include <string>


using namespace std;
class cNodo
{
public:
	string Elemento;

};


class cLista
{
public:
	cNodo ListaR;

	void ElementoRepetidos();


	cLista();
	~cLista();
};

