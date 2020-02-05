#include "stdafx.h"
#include "CadenaPlus.h"
#include <string.h>


CadenaPlus::CadenaPlus()
{
}

char *CadenaPlus::ejercicio(char p, int inum)
{
	char *pRecorre = new char;
	char *pPalabras = new char;
	char *pdiferenciador = new char;
	int x = 0;
	int y = 0;
	bool flag = true;
	int itam = strlen(pCadena);
	pRecorre = &pCadena[x];
	while (y!=inum)
	{
		x++;
		while (p != pCadena[x] && flag)
		{
			if (inum != y)
			{
				flag = true;
			}
			else
			{
				flag = false;
			}
			x++;
			*pRecorre++;
			
		}
		y++;
		pdiferenciador = &pCadena[x + 1];
		
	}
		
	return(pdiferenciador);
}

char *CadenaPlus ::cadenaReves()
{
	char *pRecorre = new char;
	char *pCompletaReves = new char;

	int iTam = strlen(pCadenaPrincipal);

	pRecorre = &pCadenaPrincipal[iTam - 1];
	for (int i = 0; i < iTam; i++)
	{
		pCompletaReves[i] = *pRecorre;
		pRecorre--;
	}
	pCompletaReves[iTam] = '\0';

	

	return pCompletaReves;
}

CadenaPlus::~CadenaPlus()
{
}
