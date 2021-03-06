#include "pch.h"
#include <iostream>
#include <stdio.h>      /* printf, scanf, puts, NULL */
#include <fstream>   //file stream
#include <stdlib.h>
#include <string>
#include "CargaDatos.h"
#include <time.h>       /* time */

using namespace std;
struct Nodo
{
	string conferencia;
	string division;
	string ciudad;
	string equipo;
	string posicion;
	string numero;
	int codigo;
	string nombre;
	string altura;
	string peso;
	string fecha;
	string potencia;
	string habilidad;
	string puntos;
	string robos;
	string rebotes;
	string tapones;
	string votacion;
	double calificacion;
	Nodo *der;
	Nodo *izq;
	Nodo *padre;
};
struct NodoListaO
{
	string conferencia;
	string equipo;
	string posicion;
	string numero;
	string nombre;
	double calificacion;
	int codigo;
	NodoListaO *siguiente;
	NodoListaO *atras;
}*primerooeste, *ultimooeste;
struct NodoListaE
{
	string conferencia;
	string equipo;
	string posicion;
	string numero;
	string nombre;
	double calificacion;
	int codigo;
	NodoListaE *siguiente;
	NodoListaE *atras;
}*primeroeste, *ultimoeste;
struct NodoEstrella
{
	string conferencia;
	string equipo;
	string posicion;
	string numero;
	string nombre;
	double calificacion;
	int codigo;

};
NodoEstrella * PivoteOESTE = new NodoEstrella();
NodoEstrella * BaseOESTE = new NodoEstrella();
NodoEstrella * AleroOESTE = new NodoEstrella();
NodoEstrella * PivoteESTE = new NodoEstrella();
NodoEstrella * BaseESTE = new NodoEstrella();
NodoEstrella * AleroESTE = new NodoEstrella();
 //Prototipos
void CARGADATOS();
void nominados();
string linea_archivo;
int iPosicionEncuentra, iPosicionAnterior = 0;
ifstream ArchivoCarga("datos.txt");
//arbol base
void insertarNodoBASE(Nodo *&, Nodo *, Nodo *);
void mostrarArbolBASE(Nodo *, int);
//arbol aleros
void insertarNodoALERO(Nodo *&, Nodo *, Nodo *);
void mostrarArbolALERO(Nodo *, int);
//arbol pivotes
void insertarNodoPIVOTE(Nodo *&, Nodo *, Nodo *);
void mostrarArbolPIVOTE(Nodo *, int);
Nodo *aux = new Nodo();
Nodo *ArbolBASE = NULL;
Nodo *ArbolPIVOTE = NULL;
Nodo *ArbolALERO = NULL;
//Eliominar
string posicionaeliminar = "";
void sancionar(Nodo *); 
void eliminarNodo(Nodo *);
void eliminar(Nodo *, int);
Nodo *minimo(Nodo *);
void reemplazar(Nodo *, Nodo*);
void deshacerNodo(Nodo *);
int codigoaeliminar = 0;
//VECTOR DE ORDENAMIENTO
void mostrarTODOS();
int codigobuscar=0;
string equipobuscar="";
void calcularmedia(Nodo *);
int contador = 0;
//BUSQUEDA
void busquedaBASE(Nodo *, int);
void busquedaALERO(Nodo *, int);
void busquedaPIVOTE(Nodo *, int);
void mostrarporequipos(Nodo *,int , string);
int lugarvector = 0;
//listas
void InsertarNodoOeste(Nodo *);
void mostrarlistaOeste();
void InsertarNodoEste(Nodo *);
void mostrarlistaEste();
void OrdenarOeste();
void OrdenarEste();
//simulacion
void simulacion1();
void simulacion2();

void main()
{
	
	bool flag = true;
	int menu = 0;
	do
	{
		system("CLS");
		cout << "MENU\n 1.MODULO 1 (CARGA DE DATOS)\n2.MODULO 2 (Ordenamiento)\n 3.MODULO 3 (Simulaciones)\n4.Salir" << endl;
		cin >> menu;
		switch (menu)
		{
			
		case 1:
			menu = 0;
			cout << "MODULO1\n 1.Cargar Datos\n 2.Sansionar\n 3.Salir" << endl;
			cin >> menu;
			switch (menu)
			{
			case 1:
				CARGADATOS();
				break;
			case 2:
				cout << "\nDigite posicio a eliminar: Base (G), Alero (F), Pivote (C) ";
				cin >> posicionaeliminar;
				cout << "\nDigite el elemento a eliminar: ";
				cin >> codigoaeliminar;
				if ((posicionaeliminar =="G" || posicionaeliminar == "g") && codigoaeliminar !=0  )
				{
					eliminar(ArbolBASE, codigoaeliminar);
				}
				else if ((posicionaeliminar == "F" || posicionaeliminar == "f") && codigoaeliminar != 0)
				{
					eliminar(ArbolALERO, codigoaeliminar);
				}
				else if ((posicionaeliminar == "C" || posicionaeliminar == "C") && codigoaeliminar != 0)
				{
					eliminar(ArbolPIVOTE, codigoaeliminar);
				}
				break;
			}
			break;
		case 2:
			menu = 0;
			cout << "Reporte Por:\n1.Jugador\n2.Mejores por Estadistica\n3.Por Esquipo\n4.Para el juego de las estrellas\n" << endl;
			cin >> menu;
			switch (menu)
			{
			case 1:
				cout << "Ingrese el Codigo del jugador que desea buscar\n";
				cin >> codigobuscar;
				busquedaBASE(ArbolBASE, codigobuscar);
				busquedaPIVOTE(ArbolPIVOTE, codigobuscar);
				busquedaALERO(ArbolALERO, codigobuscar);
				break;
			case 2:
				cout << "-------------------- Mejores Jugadores Del OESTE-----------------" << "\n\n";
				mostrarlistaOeste();
				cout << "-------------------- Mejores Jugadores Del ESTE------------------" << "\n\n";
				mostrarlistaEste();
				break;
			case 3:
				cout << "Ingrese el equipo que desea buscar\n";
				cin >> equipobuscar;
				cout << "Jugadores Encontrados del equipo " << equipobuscar << endl;
				cout << "		-----------------BASES-----------------\n" << endl;
				mostrarporequipos(ArbolBASE, contador, equipobuscar);
				cout << "		-----------------ALEROS-----------------\n" << endl;
				mostrarporequipos(ArbolALERO, contador, equipobuscar);
				cout << "		-----------------PIVOTES-----------------\n" << endl;
				mostrarporequipos(ArbolPIVOTE, contador, equipobuscar);

				break;
			case 4:
				cout << "========== Nominados Al Juego De Las Estrellas ==========" << endl;
				nominados();
				break;
			}
			break;
		case 3:
			cout << "Seleccine la Simulacion " << endl;
			cin >> menu;
			if (menu==1)
			{
				simulacion1();
			}
			else
			{
				simulacion2();
			}
			
			
			break;
		case 4:
			flag = false;
			break;
		}
		cout << "=========================		PROYECTO 2  MARLON ROCHES 12509-18			============================" << endl;
		system("pause");
	} while (true);
}
//===========================================================================METODOS========================================================================
//-----------------------------------------------------METODOS Tercera Entrega-----------------------------------------------
//busquedas
void calcularmedia(Nodo *jugador)
{
	double encontrado1=0, encontrado2=0;
	if (jugador->posicion == "G")
	{
		//peso en kilogramos
		double pesoengk=0, mesnacido=0;
		encontrado1 = jugador->peso.find("(");
		encontrado2 = jugador->peso.find("k");
		pesoengk = stod(jugador->peso.substr(encontrado1+1, encontrado2));
		//mes en el que nacio
		encontrado1 = jugador->fecha.find("–");
		encontrado2 = jugador->fecha.find("–",encontrado1+1);
		mesnacido = stod(jugador->fecha.substr(encontrado1 + 1, encontrado2));

		jugador->calificacion = pesoengk + (mesnacido * 10) + stod(jugador->habilidad) +
			stod(jugador->puntos) + stod(jugador->robos) + stod(jugador->votacion)  ;
		cout << "" << endl;
	}
	else if (jugador->posicion == "F")
	{
		double pulgadastotal = 0, pesoenlb = 0, añonacido = 0;
	//encontrando metros
		encontrado1 = jugador->altura.find("(");
		encontrado2 = jugador->altura.find("m");
		pulgadastotal = stod(jugador->altura.substr(encontrado1 + 1, encontrado2-1));
					//pasando a pulgadas
		pulgadastotal = pulgadastotal * 39.3701;
		
		//PESO EN LB
		encontrado1 = jugador->peso.find("(");
		encontrado2 = jugador->peso.find("k");
		pesoenlb = stod(jugador->peso.substr(encontrado1 + 1, encontrado2));
		pesoenlb = pesoenlb * 2.20462;
		

		//AÑO NACIDO
		encontrado1 = jugador->fecha.find("–");
		añonacido = stod(jugador->fecha.substr(0,encontrado1));

		jugador->calificacion = (pulgadastotal * 10) + pesoenlb + añonacido + stod(jugador->puntos) + stod(jugador->tapones) + stod(jugador->votacion);


		cout << "";
	}
	else if(jugador->posicion == "C")
	{//altura en metros
		int alturaenmetros = 0, pesoenkg = 0, dianacido = 0;
		encontrado1 = jugador->altura.find("(");
		encontrado2 = jugador->altura.find("m");
		alturaenmetros = stod(jugador->altura.substr(encontrado1 + 1, encontrado2 - 1));

		//peso en kg
		encontrado1 = jugador->peso.find("(");
		encontrado2 = jugador->peso.find("k");
		pesoenkg = stod(jugador->peso.substr(encontrado1 + 1, encontrado2));
	

		//dias nacido
		int encontrado3 = 0;
		encontrado1 = jugador->fecha.find("–");
		encontrado2 = jugador->fecha.find("–", encontrado1 + 1);
		encontrado3 = encontrado2 + 2;
		
		
		dianacido = stod(jugador->fecha.substr(encontrado2+1, encontrado3));

		jugador->calificacion = alturaenmetros + pesoenkg + (dianacido * 5)+stod(jugador->potencia)+stod(jugador->puntos)+stod(jugador->tapones)+stod(jugador->votacion);
		cout << "";

	}

}
void busquedaBASE(Nodo *arbolRecorre, int n)
{
	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		
		
	}
	else
	{
		if (arbolRecorre->codigo == n) //Si el nodo es igual al elemento
		{
			cout << endl;
			cout << endl;
			cout << "El Jugador Base: " + arbolRecorre->nombre << endl;
			cout << "Conferencia: " + arbolRecorre->conferencia << endl;
			cout << "Division: " + arbolRecorre->division<< endl;
			cout << "Ciudad: " + arbolRecorre->ciudad<< endl;
			cout << "Equipo: " + arbolRecorre->equipo<< endl;
			cout << "Posicion: " + arbolRecorre->posicion<< endl;
			cout << "Numero: " + arbolRecorre->numero<< endl;
			cout << "Codigo: " + arbolRecorre->codigo<< endl;
			cout << "Altura: " + arbolRecorre->altura<< endl;
			cout << "Peso: " + arbolRecorre->peso<< endl;
			cout << "Fecha De Nacimiento: " + arbolRecorre->fecha<< endl;
			cout << "Potencia: " + arbolRecorre->potencia<< endl;
			cout << "Habilidad: " + arbolRecorre->habilidad<< endl;
			cout << "Puntos: " + arbolRecorre->puntos<< endl;
			cout << "Robos: " + arbolRecorre->robos<< endl;
			cout << "Rebotes: " + arbolRecorre->rebotes<< endl;
			cout << "Tapones: " + arbolRecorre->tapones<< endl;
			cout << "Votacion: " + arbolRecorre->votacion<< endl;
			system("pause");
		}
		else
		{
			if (n < arbolRecorre->codigo)
			{
				return busquedaBASE(arbolRecorre->izq, n);
			}
			else
			{
				return busquedaBASE(arbolRecorre->der, n);
			}
		}
	}
}
void busquedaALERO(Nodo *arbolRecorre, int n)
{
	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		

	}
	else
	{
		if (arbolRecorre->codigo == n) //Si el nodo es igual al elemento
		{
			cout << endl;
			cout << endl;
			cout << "El Jugador Alero: " + arbolRecorre->nombre << endl;
			cout << "Conferencia: " + arbolRecorre->conferencia << endl;
			cout << "Division: " + arbolRecorre->division<< endl;
			cout << "Ciudad: " + arbolRecorre->ciudad<< endl;
			cout << "Equipo: " + arbolRecorre->equipo<< endl;
			cout << "Posicion: " + arbolRecorre->posicion<< endl;
			cout << "Numero: " + arbolRecorre->numero<< endl;
			cout << "Codigo: " + arbolRecorre->codigo<< endl;
			cout << "Altura: " + arbolRecorre->altura<< endl;
			cout << "Peso: " + arbolRecorre->peso<< endl;
			cout << "Fecha De Nacimiento: " + arbolRecorre->fecha<< endl;
			cout << "Potencia: " + arbolRecorre->potencia<< endl;
			cout << "Habilidad: " + arbolRecorre->habilidad<< endl;
			cout << "Puntos: " + arbolRecorre->puntos<< endl;
			cout << "Robos: " + arbolRecorre->robos<< endl;
			cout << "Rebotes: " + arbolRecorre->rebotes<< endl;
			cout << "Tapones: " + arbolRecorre->tapones<< endl;
			cout << "Votacion: " + arbolRecorre->votacion<< endl;
			system("pause");
		}
		else
		{
			if (n < arbolRecorre->codigo)
			{
				return busquedaALERO(arbolRecorre->izq, n);
			}
			else
			{
				return busquedaALERO(arbolRecorre->der, n);
			}
		}
	}
}
void busquedaPIVOTE(Nodo *arbolRecorre, int n)
{
	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		
		
	}
	else
	{
		if (arbolRecorre->codigo == n) //Si el nodo es igual al elemento
		{
			cout << endl;
			cout << endl;
			cout << "El Jugador Pivote: " + arbolRecorre->nombre << endl;
			cout << "Conferencia: " + arbolRecorre->conferencia << endl;
			cout << "Division: " + arbolRecorre->division<< endl;
			cout << "Ciudad: " + arbolRecorre->ciudad<< endl;
			cout << "Equipo: " + arbolRecorre->equipo<< endl;
			cout << "Posicion: " + arbolRecorre->posicion<< endl;
			cout << "Numero: " + arbolRecorre->numero<< endl;
			cout << "Codigo: " + arbolRecorre->codigo<< endl;
			cout << "Altura: " + arbolRecorre->altura<< endl;
			cout << "Peso: " + arbolRecorre->peso<< endl;
			cout << "Fecha De Nacimiento: " + arbolRecorre->fecha<< endl;
			cout << "Potencia: " + arbolRecorre->potencia<< endl;
			cout << "Habilidad: " + arbolRecorre->habilidad<< endl;
			cout << "Puntos: " + arbolRecorre->puntos<< endl;
			cout << "Robos: " + arbolRecorre->robos<< endl;
			cout << "Rebotes: " + arbolRecorre->rebotes<< endl;
			cout << "Tapones: " + arbolRecorre->tapones<< endl;
			cout << "Votacion: " + arbolRecorre->votacion<< endl;
			system("pause");
		}
		else
		{
			if (n < arbolRecorre->codigo)
			{
				return busquedaPIVOTE(arbolRecorre->izq, n);
			}
			else
			{
				return busquedaPIVOTE(arbolRecorre->der, n);
			}
		}
	}
}
void mostrarporequipos(Nodo *arbolRecorre, int cont, string equipo)
{

	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
	
	}
	else
	{
		
		mostrarporequipos(arbolRecorre->der, cont + 1, equipo);
		if (arbolRecorre->equipo == equipo)
		{
			cout << "Nombre: "<<arbolRecorre->nombre <<"	Codigo: " << arbolRecorre->codigo <<"		Calificacion: " << arbolRecorre->calificacion << "\n\n";
			
		}
		else
		{

		}
		mostrarporequipos(arbolRecorre->izq, cont + 1, equipo);
		


	}
}
//OESTE
void InsertarNodoOeste(Nodo *jugador)
{
	NodoListaO* nuevo = new NodoListaO();

	nuevo->conferencia = jugador->conferencia;
	nuevo->equipo = jugador->equipo;
	nuevo->posicion = jugador->posicion;
	nuevo->numero = jugador->numero;
	nuevo->codigo = jugador->codigo;
	nuevo->nombre = jugador->nombre;
	nuevo->calificacion = jugador->calificacion;
	if (primerooeste == NULL)
	{
		primerooeste = nuevo;
		primerooeste->siguiente = NULL;
		ultimooeste = nuevo;
	}
	else
	{
		ultimooeste->siguiente = nuevo;
		nuevo->siguiente = NULL;
		ultimooeste = nuevo;
	}
}
void mostrarlistaOeste()
{
	int conta =1;
	NodoListaO * actual = new NodoListaO();
	actual = primerooeste;
	if (primeroeste != NULL)
	{
		while (actual != NULL&& conta<11 )
		{
			cout << "Puesto #" << conta << ". " << actual->nombre << "			Calificacion: " << actual->calificacion << "\n";
			actual = actual->siguiente;
			conta++;
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}   
void OrdenarOeste()
{
	NodoListaO *p = primerooeste;
	NodoListaO *aux = new NodoListaO();
	while (p != NULL)
	{
		NodoListaO *j = p->siguiente;

		while (j != NULL)
		{
			if (p->calificacion < j->calificacion)
			{
				aux->conferencia = j->conferencia;
				aux->equipo = j->equipo;
				aux->posicion = j->posicion;
				aux->numero = j->numero;
				aux->codigo = j->codigo;
				aux->nombre = j->nombre;
				aux->calificacion = j->calificacion;

				j->conferencia = p->conferencia;
				j->equipo = p->equipo;
				j->posicion = p->posicion;
				j->numero = p->numero;
				j->codigo = p->codigo;
				j->nombre = p->nombre;
				j->calificacion = p->calificacion;


				p->conferencia = aux->conferencia;
				p->equipo = aux->equipo;
				p->posicion = aux->posicion;
				p->numero = aux->numero;
				p->codigo = aux->codigo;
				p->nombre = aux->nombre;
				p->calificacion = aux->calificacion;

			}
			j = j->siguiente;
		}
		p = p->siguiente;
	}
}
//ESTE
void InsertarNodoEste(Nodo *jugador)
{
	NodoListaE* nuevo = new NodoListaE();

	nuevo->conferencia = jugador->conferencia;
	nuevo->equipo = jugador->equipo;
	nuevo->posicion = jugador->posicion;
	nuevo->numero = jugador->numero;
	nuevo->codigo = jugador->codigo;
	nuevo->nombre = jugador->nombre;
	nuevo->calificacion = jugador->calificacion;
	if (primeroeste == NULL)
	{
		primeroeste = nuevo;
		primeroeste->siguiente = NULL;
		ultimoeste = nuevo;
	}
	else
	{
		ultimoeste->siguiente = nuevo;
		nuevo->siguiente = NULL;
		ultimoeste = nuevo;
	}
}
void mostrarlistaEste()
{
	int conta = 1;
	NodoListaE* actual = new NodoListaE();
	actual = primeroeste;
	if (primeroeste != NULL)
	{
		while (actual != NULL && conta < 11)
		{
			cout << "Puesto #"<<conta<<". " << actual->nombre << "			Calificacion: " << actual->calificacion << "\n";
			actual = actual->siguiente;
			conta++;
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}
void OrdenarEste()
{
	NodoListaE *p = primeroeste;
	NodoListaE *aux = new NodoListaE();
	while (p != NULL)
	{
		NodoListaE *j = p->siguiente;

		while (j != NULL)
		{
			if (p->calificacion < j->calificacion)
			{
				aux->conferencia = j->conferencia;
				aux->equipo = j->equipo;
				aux->posicion = j->posicion;
				aux->numero = j->numero;
				aux->codigo = j->codigo;
				aux->nombre = j->nombre;
				aux->calificacion = j->calificacion;

				j->conferencia = p->conferencia;
				j->equipo = p->equipo;
				j->posicion = p->posicion;
				j->numero = p->numero;
				j->codigo = p->codigo;
				j->nombre = p->nombre;
				j->calificacion = p->calificacion;


				p->conferencia = aux->conferencia;
				p->equipo = aux->equipo;
				p->posicion = aux->posicion;
				p->numero = aux->numero;
				p->codigo = aux->codigo;
				p->nombre = aux->nombre;
				p->calificacion = aux->calificacion;

			}
			j = j->siguiente;
		}
		p = p->siguiente;
	}
}
//-----------------------------------------------------METODOS Segunda Entrega-----------------------------------------------//
void deshacerNodo(Nodo *nodo)
{
	nodo->der = NULL;
	nodo->izq = NULL;

	delete nodo;
}
void mostrarTODOS()
{
	contador = 0;
	cout << "" << endl;
	cout << "================================ARBOL BASE=====================\n" << endl;
	mostrarArbolBASE(ArbolBASE, contador);
	cout << "" << endl;
	cout << "================================ARBOL PIVOTE=====================\n" << endl;
	mostrarArbolPIVOTE(ArbolPIVOTE, contador);
	cout << "" << endl;
	cout << "================================ARBOL ALERO=====================\n" << endl;
	mostrarArbolALERO(ArbolALERO, contador);
}
void sancionar(Nodo *nodoEliminar)
{
	if (nodoEliminar->izq && nodoEliminar->der) //Si el nodo tiene hijos derecha o izquierda
	{
		Nodo *menor = minimo(nodoEliminar->der);
		nodoEliminar->codigo = menor->codigo;
		eliminarNodo(menor);
	}
	else
	{
		if (nodoEliminar->izq)
		{
			reemplazar(nodoEliminar, nodoEliminar->izq);
			deshacerNodo(nodoEliminar);

		}
		else
		{
			if (nodoEliminar->der)
			{
				reemplazar(nodoEliminar, nodoEliminar->der);
				deshacerNodo(nodoEliminar);
			}
			else
			{
				reemplazar(nodoEliminar, NULL);
				deshacerNodo(nodoEliminar);
			}
		}
	}
}
void eliminarNodo(Nodo *nodoEliminar)
{
	if (nodoEliminar->izq && nodoEliminar->der) //Si el nodo tiene hijos derecha o izquierda
	{
		Nodo *menor = minimo(nodoEliminar->der);
		nodoEliminar->codigo = menor->codigo;
		eliminarNodo(menor);
	}
	else
	{
		if (nodoEliminar->izq)
		{
			reemplazar(nodoEliminar, nodoEliminar->izq);
			deshacerNodo(nodoEliminar);

		}
		else
		{
			if (nodoEliminar->der)
			{
				reemplazar(nodoEliminar, nodoEliminar->der);
				deshacerNodo(nodoEliminar);
			}
			else
			{
				reemplazar(nodoEliminar, NULL);
				deshacerNodo(nodoEliminar);
			}
		}
	}
}
void eliminar(Nodo *arbolRecorre, int n)
{
	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		return; //No hacer nada
	}
	else
	{
		if (n < arbolRecorre->codigo) //Si el valor es menor
		{
			eliminar(arbolRecorre->izq, n); //BUscar por la izquierda
		}
		else
		{
			if (n > arbolRecorre->codigo) //Si el valor es mayor
			{
				eliminar(arbolRecorre->der, n); //Buscar por la derecha
			}
			else //Si ya encontraste el valor
			{
				eliminarNodo(arbolRecorre);
			}
		}
	}
}
void reemplazar(Nodo *arbolRecorre, Nodo *nodoAux)
{
	if (arbolRecorre->padre)
	{
		//Arbol->Padre hay que asignarle su hijo
		if (arbolRecorre->codigo = arbolRecorre->padre->izq->codigo)
		{
			arbolRecorre->padre->izq = nodoAux;
		}
		else
		{
			if (arbolRecorre->codigo == arbolRecorre->padre->der->codigo)
			{
				arbolRecorre->padre->der = nodoAux;
			}
		}
	}
	if (nodoAux)
	{
		//Procedemos a asignarle su nuevo padre
		nodoAux->padre = arbolRecorre->padre;
	}
}
Nodo *minimo(Nodo *arbolRecorre)
{
	if (arbolRecorre == NULL)
	{
		return NULL;
	}
	if (arbolRecorre->izq) //Si tiene hijo a la izquierda
	{
		return minimo(arbolRecorre->izq); //BUscamos la parte mas izquierda posible
	}
	else //Si no tiene hijo izquierdo
	{
		return arbolRecorre; //Retornamos el mismo
	}
}
//---------------------BASES----------------------
void insertarNodoBASE(Nodo *&arbolrecorre, Nodo *datos, Nodo *padre)
{

	if (arbolrecorre == NULL) //Si el arbol esta vacio
	{

		arbolrecorre = datos;
	}
	else //Significa que si tiene un nodo o mas
	{
		int valorRaiz = arbolrecorre->codigo; //Obtenemos el valor de la raiz
		if (datos->codigo < valorRaiz) //Si el elemento insertado es menor que la raiz, se va para la izquierda
		{
			insertarNodoBASE(arbolrecorre->izq, datos, arbolrecorre);
		}
		else //Si el elemento insertado es mayor a la raiz, insertar a la derecha
		{
			insertarNodoBASE(arbolrecorre->der, datos, arbolrecorre);
		}
	}

}
void mostrarArbolBASE(Nodo *arbolRecorre, int cont)
{

	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		return;
	}
	else
	{
		mostrarArbolBASE(arbolRecorre->der, cont + 1);
		for (int i = 0; i < cont; i++)
		{
			cout << "          ";
		}
		cout << arbolRecorre->codigo << endl;

		mostrarArbolBASE(arbolRecorre->izq, cont + 1);


	}
}
//---------------------PIVOTE----------------------
void insertarNodoPIVOTE(Nodo *&arbolrecorre, Nodo *datos, Nodo *padre)
{

	if (arbolrecorre == NULL) //Si el arbol esta vacio
	{

		arbolrecorre = datos;
	}
	else //Significa que si tiene un nodo o mas
	{
		int valorRaiz = arbolrecorre->codigo; //Obtenemos el valor de la raiz
		if (datos->codigo < valorRaiz) //Si el elemento insertado es menor que la raiz, se va para la izquierda
		{
			insertarNodoPIVOTE(arbolrecorre->izq, datos, arbolrecorre);
		}
		else //Si el elemento insertado es mayor a la raiz, insertar a la derecha
		{
			insertarNodoPIVOTE(arbolrecorre->der, datos, arbolrecorre);
		}
	}

}
void mostrarArbolPIVOTE(Nodo *arbolRecorre, int cont)
{

	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		return;
	}
	else
	{
		mostrarArbolPIVOTE(arbolRecorre->der, cont + 1);
		for (int i = 0; i < cont; i++)
		{
			cout << "          ";
		}
		cout << arbolRecorre->codigo << endl;

		mostrarArbolPIVOTE(arbolRecorre->izq, cont + 1);


	}
}
//---------------------ALERO----------------------
void insertarNodoALERO(Nodo *&arbolrecorre, Nodo *datos, Nodo *padre)
{

	if (arbolrecorre == NULL) //Si el arbol esta vacio
	{

		arbolrecorre = datos;
	}
	else //Significa que si tiene un nodo o mas
	{
		int valorRaiz = arbolrecorre->codigo; //Obtenemos el valor de la raiz
		if (datos->codigo < valorRaiz) //Si el elemento insertado es menor que la raiz, se va para la izquierda
		{
			insertarNodoALERO(arbolrecorre->izq, datos, arbolrecorre);
		}
		else //Si el elemento insertado es mayor a la raiz, insertar a la derecha
		{
			insertarNodoALERO(arbolrecorre->der, datos, arbolrecorre);
		}
	}

}
void mostrarArbolALERO(Nodo *arbolRecorre, int cont)
{

	if (arbolRecorre == NULL) //Si el arbol esta vacio
	{
		return;
	}
	else
	{
		mostrarArbolALERO(arbolRecorre->der, cont + 1);
		for (int i = 0; i < cont; i++)
		{
			cout << "          ";
		}
		cout << arbolRecorre->codigo << endl;

		mostrarArbolALERO(arbolRecorre->izq, cont + 1);


	}
}
//GENERALES
void CARGADATOS()
{
	while (!ArchivoCarga.eof())
	{
		contador++;

		Nodo *auxiliar = new Nodo();
		/*cout << "==================================NODO NUM.	" << contador <<"=======================" <<endl;*/
		//lectura archivo
		getline(ArchivoCarga, linea_archivo);


		//SPLIT
		//conferencia
		iPosicionEncuentra = linea_archivo.find("|");
		auxiliar->conferencia = linea_archivo.substr(0, iPosicionEncuentra);
		/*	cout << auxiliar->conferencia << endl;*/

			//division
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->division = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->division << endl;

		//ciudad
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->ciudad = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		/*cout << auxiliar->ciudad << endl;*/

		//equipo
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->equipo = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->equipo << endl;

		//posicion
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->posicion = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->posicion << endl;

		//numero
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->numero = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->numero << endl;

		//*codigo
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->codigo = stoi(linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1));
		//cout << auxiliar->codigo << endl;

		//	nombre
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->nombre = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->nombre << endl;

		//	altura
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->altura = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->altura << endl;

		//	peso
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->peso = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->peso << endl;

		//	fecha
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->fecha = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->fecha << endl;

		//	potencia
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->potencia = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->potencia << endl;

		//	habilidad
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->habilidad = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->habilidad << endl;

		//	puntos
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->puntos = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->puntos << endl;

		//	robos
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->robos = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->robos << endl;

		//	rebotes
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->rebotes = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->rebotes << endl;

		//	tapones
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->tapones = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->tapones << endl;

		//	votacion*/
		iPosicionAnterior = iPosicionEncuentra;
		iPosicionEncuentra = linea_archivo.find("|", iPosicionEncuentra + 1);
		auxiliar->votacion = linea_archivo.substr(iPosicionAnterior + 1, (iPosicionEncuentra - iPosicionAnterior) - 1);
		//cout << auxiliar->votacion << endl;
		calcularmedia(auxiliar);
		//cout << "===============HASTA AQUI LLEGA EL NODO==============" << endl;

		auxiliar->der = NULL;
		auxiliar->izq = NULL;
		auxiliar->padre = ArbolBASE;

		// insertando en los arboles
		if (auxiliar->posicion == "G")
		{
			insertarNodoBASE(ArbolBASE, auxiliar, NULL);
		}
		else if (auxiliar->posicion == "C")
		{
			insertarNodoPIVOTE(ArbolPIVOTE, auxiliar, NULL);
		}
		else if (auxiliar->posicion == "F")
		{
			insertarNodoALERO(ArbolALERO, auxiliar, NULL);
		}


		//insertando en las listas para ser ordenados
		if (auxiliar->conferencia == "Oeste")
		{
			InsertarNodoOeste(auxiliar);
		}
		else if (auxiliar->conferencia == "Este")
		{
			InsertarNodoEste(auxiliar);
		}
	}

	system("CLS");
	cout << "---------------------------------------------|     DATOS CARGADOS     |---------------------------------------------" << endl;
	OrdenarEste();
	OrdenarOeste();

}
void nominados()
{
	ofstream archivo;
	archivo.open("JEstrellas.txt", ios::out);
	string equipo1 = "";
	string equipo2 = "";
	cout << "Ingrese el equipo del OESTE" << endl;
	cin >> equipo1;
	
	int	conta = 0;
	bool f = true, g = true, c = true;
	NodoListaO * actual = new NodoListaO();
	actual = primerooeste;
	if (primeroeste != NULL)
	{
		while (actual != NULL && conta !=3)
		{
			if (actual->posicion=="G" && g==true  && actual->equipo==equipo1)
			{
				 BaseOESTE->conferencia =actual->conferencia;
				 BaseOESTE->equipo =actual->equipo;
				 BaseOESTE->posicion =actual->posicion;
				 BaseOESTE->numero =actual->numero;
				 BaseOESTE->codigo =actual->codigo;
				 BaseOESTE->nombre =actual->nombre;
				BaseOESTE->calificacion =actual->calificacion ;

				archivo << BaseOESTE->conferencia << "|" << BaseOESTE->equipo << "|" << BaseOESTE->posicion << "|" << BaseOESTE->numero << "|" << BaseOESTE->codigo << "|" << BaseOESTE->nombre << "|" << BaseOESTE->calificacion << endl;
				g = false;
				conta++;
			}else  if (actual->posicion == "F" && f==true && actual->equipo == equipo1)
			{
				AleroOESTE->conferencia = actual->conferencia;
				AleroOESTE->equipo = actual->equipo;
				AleroOESTE->posicion = actual->posicion;
				AleroOESTE->numero = actual->numero;
				AleroOESTE->codigo = actual->codigo;
				AleroOESTE->nombre = actual->nombre;
				AleroOESTE->calificacion = actual->calificacion;
				conta++;
				archivo << AleroOESTE->conferencia << "|" << AleroOESTE->equipo << "|" << AleroOESTE->posicion << "|" << AleroOESTE->numero << "|" << AleroOESTE->codigo << "|" << AleroOESTE->nombre << "|" << AleroOESTE->calificacion << endl;

				f = false;
			} else if (actual->posicion == "C" && c==true && actual->equipo == equipo1)
			{
				PivoteOESTE->conferencia = actual->conferencia;
				PivoteOESTE->equipo = actual->equipo;
				PivoteOESTE->posicion = actual->posicion;
				PivoteOESTE->numero = actual->numero;
				PivoteOESTE->codigo = actual->codigo;
				PivoteOESTE->nombre = actual->nombre;
				PivoteOESTE->calificacion = actual->calificacion;
				archivo << PivoteOESTE->conferencia << "|" << PivoteOESTE->equipo << "|" << PivoteOESTE->posicion << "|" << PivoteOESTE->numero << "|" << PivoteOESTE->codigo << "|" << PivoteOESTE->nombre << "|" << PivoteOESTE->calificacion << endl;

				conta++;
				c = false;
			}
			
			actual = actual->siguiente;
			
		}
	}
	cout << "Ingrese el eqiopo del ESTE\n" << endl;
	cin >> equipo2;
	g = true;
	c = true;
		f = true;
	conta = 0;
	NodoListaE * actual2 = new NodoListaE();
	actual2 = primeroeste;
	if (primeroeste != NULL)
	{
		while (actual2!= NULL && conta != 3)
		{
			if (actual2->posicion == "G" && g == true && actual2->equipo==equipo2)
			{
				BaseESTE->conferencia = actual2->conferencia;
				BaseESTE->equipo = actual2->equipo;
				BaseESTE->posicion = actual2->posicion;
				BaseESTE->numero = actual2->numero;
				BaseESTE->codigo = actual2->codigo;
				BaseESTE->nombre = actual2->nombre;
				BaseESTE->calificacion = actual2->calificacion;
				archivo << BaseESTE->conferencia << "|" << BaseESTE->equipo << "|" << BaseESTE->posicion << "|" << BaseESTE->numero << "|" << BaseESTE->codigo << "|" << BaseESTE->nombre << "|" << BaseESTE->calificacion << endl;

				g = false;
				conta++;
			}
			else  if (actual2->posicion == "F" && f == true && actual2->equipo == equipo2)
			{
				AleroESTE->conferencia = actual2->conferencia;
				AleroESTE->equipo = actual2->equipo;
				AleroESTE->posicion = actual2->posicion;
				AleroESTE->numero = actual2->numero;
				AleroESTE->codigo = actual2->codigo;
				AleroESTE->nombre = actual2->nombre;
				AleroESTE->calificacion = actual2->calificacion;
				archivo << AleroESTE->conferencia << "|" << AleroESTE->equipo << "|" << AleroESTE->posicion << "|" << AleroESTE->numero << "|" << AleroESTE->codigo << "|" << AleroESTE->nombre << "|" << AleroESTE->calificacion << endl;

				conta++;
				f = false;
			}
			else if (actual2->posicion == "C" && c == true && actual2->equipo == equipo2)
			{
				PivoteESTE->conferencia = actual2->conferencia;
				PivoteESTE->equipo = actual2->equipo;
				PivoteESTE->posicion = actual2->posicion;
				PivoteESTE->numero = actual2->numero;
				PivoteESTE->codigo = actual2->codigo;
				PivoteESTE->nombre = actual2->nombre;
				PivoteESTE->calificacion = actual2->calificacion;
				archivo << PivoteESTE->conferencia << "|" << PivoteESTE->equipo << "|" << PivoteESTE->posicion << "|" << PivoteESTE->numero << "|" << PivoteESTE->codigo << "|" << PivoteESTE->nombre << "|" << PivoteESTE->calificacion << endl;

				conta++;
				c = false;
			}

			actual2 = actual2->siguiente;

		}
		archivo.close();
	}

	system("CLS");

	cout << "				======== LOS NOMINADOS PARA EL JUEGO DE LAS ESTRELLAS SON ======== "<< "\n\n";
	cout << "------------------------------------------------------------OESTE-------------------------------------------------------"<< "\n\n";

	cout << "Como el mejor Base Del Oste: " << BaseOESTE->nombre << "\n		Del: " << BaseOESTE->equipo << endl << endl;
	cout << "Como el mejor Alero Del Oste: " << AleroOESTE->nombre << "\n		Del: "  << AleroOESTE->equipo << endl << endl;
	cout << "Como el mejor Pivote Del Oste: " << PivoteOESTE->nombre << "\n		Del: "  << PivoteOESTE->equipo << endl<< endl;
	
	cout << "-------------------------------------------------------------ESTE-------------------------------------------------------" << "\n\n";

	cout << "Como el mejor Base Del Este: " << BaseESTE->nombre << "\n		Del: "  << BaseESTE->equipo << endl << endl;
	cout << "Como el mejor Alero Del Eeste: " << AleroESTE->nombre << "\n		Del: "  << AleroESTE->equipo << endl << endl;
	cout << "Como el mejor Pivote Del Eeste: " << PivoteESTE->nombre << "\n		Del: "  << PivoteESTE->equipo << endl << endl;
	system("pause");
}
// Simulaciones
void simulacion1()
{
	bool ingame=true;
	srand(time(NULL));
	
	contador = rand() % 2;
	
	//Primer paso
	cout << BaseESTE->nombre << " Quiere pasar el balon a " << AleroESTE->nombre<<endl;
	if ((BaseESTE->calificacion > BaseOESTE->calificacion|| contador !=0 ) && ingame==true)
	{
				cout << "Y lo logra!"<< endl;

	}
	else
	{
		cout << "Pero " << BaseOESTE->nombre << "  lo detiene y termina la jugada." << endl;		ingame = false;

	}

	//Segundo paso
	if (ingame==true)
	{
		contador = rand() % 2;

		cout << AleroESTE->nombre << " Intenta driblar." << endl;
		if ((AleroESTE->calificacion > AleroOESTE->calificacion) && ingame == true)
		{
			cout << "Y lo logra driblar, ahora tiene que decidir si lanza o pasara la bola" << endl;

			if (contador == 0)
			{
				cout << "Decide Tirar y anota!" << endl;
				ingame = false;
			}

			if (contador == 1)
			{
				cout << "Decide pasarsela a " << PivoteESTE->nombre << endl;

			}


		}
		else
		{
			cout << "Pero " << AleroOESTE->nombre << "  lo detiene y termina la jugada." << endl;		ingame = false;

		}

	}
	//Tercer paso
	contador = rand() % 2;
	if (ingame==true)
	{
		cout << PivoteESTE->nombre << " Recibe la bola " << endl;
		if ((PivoteESTE->calificacion > PivoteOESTE->calificacion || contador != 0) && ingame == true)
		{
			cout << "Y anota!" << endl;
			ingame = false;
		}
		else
		{
			cout << "Pero " << PivoteOESTE->nombre	<< "  lo detiene y termina la jugada." << endl;		
			ingame = false;
		}
	}

	cout << "-----------------------------------------------Jugada Teminada------------------------------------------------------";
	system("pause");
}
void simulacion2()
{srand(time(NULL));
	contador = rand() % 10 + 1;
	cout << "No supe como hacerlo, lo siento :(" << endl;
	system("pause");
}