#include "pch.h"
#include <iostream>
#include<fstream>
#include <stdlib.h>
#include <string>
#include <vector>
#include "pch.h"
#include <iostream>
#include "cLista.h"


using namespace std;

void push(char);
struct Nodo
{
	string dato;
	bool pivote;
	int crepetidos;
	Nodo *siguiente;
	Nodo* atras;
}*primero, *ultimo;
struct nodo
{
	int dato;
	nodo *siguiente;
};



void mostrarPU();
string linea_archivo;
int iPosicionEncuentra, iPosicionAnterior = 0;
ifstream ArchivoCarga("prueba.txt");
int contador = 0;
string leido = "";

int main()
{
	
		
		Nodo *auxiliar = new Nodo();

		getline(ArchivoCarga, linea_archivo);
		leido = linea_archivo;

		
			contador++;
			cout << "NODO NUM.	" << contador << endl;
			
			for (int i = 0; i < linea_archivo.length(); i++)
			{
				while ((linea_archivo[i]!=('-') )&& (linea_archivo[i] != NULL))
				{
					push(linea_archivo[i]);
					i++; 
					
				}
			}
			
			
			cout << auxiliar->dato << endl;
			cout << "===============HASTA AQUI LLEGA EL NODO==============" << endl;
			
		
		mostrarPU();
	

	/*push
	*/
	
}	

void push(char dato)
{
	Nodo *auxiliar = new Nodo();
	auxiliar->dato = dato;
	if (primero == NULL)
	{
		
		primero = auxiliar;
		primero->siguiente = NULL;
		primero->atras = NULL;
		ultimo = primero;

	}
	else
	{
		ultimo->siguiente = auxiliar;
		auxiliar->siguiente = NULL;
		auxiliar->atras = ultimo;
		ultimo = auxiliar;
	}
}
void mostrarPU()
{
	Nodo* actual = new Nodo();
	actual = ultimo;
	if (primero!= NULL)
	{
		while (actual!=NULL)
		{
			cout << "\n" << actual->dato;
			actual = actual->atras
;
		}
		
	}
	else
	{
		cout << "Lista vacia";
	}
}
void buscar()
{
	Nodo* actual = new Nodo();
	actual = primero;
	bool encontrado = false;
	string nodobuscado = "";
	cout << "INgrese el nodo a buscar \n";
	cin >> nodobuscado;
	if (primero != NULL)
	{
		while (actual != NULL && encontrado != true)
		{
			if (actual->dato == nodobuscado)
			{

				cout << "Nodo con el dato buscado, encontrado";
				encontrado = true;
			}
			actual = actual->siguiente;
		}
		if (!encontrado)
		{
			cout << "\n Nodo no encontrado";
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}
void eliminar()
{
	Nodo* actual = new Nodo();
	actual = primero;
	Nodo* anterior = new Nodo();
	anterior = NULL;
	bool encontrado = false;
	string nodobuscado = 0;
	cout << "INgrese el nodo a eliminar \n";
	cin >> nodobuscado;
	if (primero != NULL)
	{
		while (actual != NULL && encontrado != true)
		{
			if (actual->dato == nodobuscado)
			{
				cout << "Nodo con el dato buscado, Encontrado";

				if (actual == primero)
				{
					primero = primero->siguiente;
				}
				else if (actual == ultimo)
				{
					anterior->siguiente = NULL;
					ultimo = anterior;
				}
				else
				{
					anterior->siguiente = actual->siguiente;
				}
				cout << "\n Nodo con el dato buscado, eliminado";

				encontrado = true;
			}
			anterior = actual;
			actual = actual->siguiente;
		}
		if (!encontrado)
		{
			cout << "\n Nodo no encontrado";
		}
	}
	else
	{
		cout << "La Lista esta vacia \n";
	}
}
//
//
//
//void InsertarLista(nodo *&lista, int n)
//{
//	nodo *nuevo_nodo = new nodo();//creando nuevo nodo
//	nuevo_nodo->dato = n;
//
//	
//	nodo *aux1 = lista;
//	nodo *aux2;
//
//	while ((aux1 != NULL) && (aux1->dato < n)) //insertando ordenado
//	{
//		aux2 = aux1;
//		aux1 = aux1->siguiente;
//	}
//	if (lista == aux1) //en el medio  final
//	{
//		lista = nuevo_nodo;
//	}
//	else
//	{
//		aux2->siguiente = nuevo_nodo;
//	}
//	nuevo_nodo->siguiente = aux1;
//
//
//	cout << "t\Elemento " << n << " insertado  lista correctamente\n";
//}
//
//void MostrarLista(nodo *lista)
//{
//	nodo *actual = new nodo();
//
//	actual = lista;
//
//	while (actual != NULL)
//
//	{
//		cout << actual->dato << " -> ";
//		actual = actual->siguiente;
//	}
//}
//
//void EliminarNodo(nodo *&lista, int n)
//{
//
//	if (lista != NULL)
//	{
//		nodo *aux_borrar;
//		nodo *anterior = NULL;
//		aux_borrar = NULL;
//		//recorrer la lista
//		while ((aux_borrar != NULL) && (aux_borrar->dato != n))
//		{
//			anterior = aux_borrar;
//			aux_borrar = aux_borrar->siguiente;
//		}
//		//elemento no encontrado
//		if (aux_borrar == NULL)
//		{
//			cout << "El Elemento no existe";
//		}
//		else if (anterior == NULL) // el primer elemento sera eliminado
//		{
//			lista = lista->siguiente;
//			delete aux_borrar;
//		}
//		else//elimina cualquiera que no sea el primero
//		{
//			anterior->siguiente = aux_borrar->siguiente;
//			delete aux_borrar;
//		}
//	}
//
//}