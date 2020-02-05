#pragma once
class CadenaPlus
{
public:
	char *pCadenaPrincipal;
	char *pCadena;

public:
	CadenaPlus();

	char *cadenaReves();

	char *ejercicio(char pletra, int iNum);

	~CadenaPlus();
};

