#include "NodoAB.cpp";
#include<iostream>
using namespace std;


class ArbolBB {
private:
	NodoAB *raiz = nullptr;
	NodoAB *actual = nullptr;
public:
	ArbolBB() {}

	bool estaVacio() {
		return raiz == nullptr;
	}

	void insertar(int clave) {
		if (raiz == nullptr)
			raiz = new NodoAB(clave);
		else {
			buscarPI(raiz, clave);
		}
	}

	// PI: Punto de Insercion
	void buscarPI(NodoAB *nodo, int clave) {
		
		if (clave < nodo->clave && nodo->izq != nullptr)
			buscarPI(nodo->izq, clave);
		else if (clave < nodo->clave && nodo->izq == nullptr)
			nodo->izq = new NodoAB(clave);
		else if (clave > nodo->clave && nodo->der != nullptr)
			buscarPI(nodo->der, clave);
		else if (clave == nodo->clave)
			;
		else
			nodo->der = new NodoAB(clave);
	}

	void eliminar(int clave) {
		// el dato esta en la raiz y el arbol
		//solamente tiene un nodo
		if (raiz->clave == clave && raiz->esHoja()) {
			actual = raiz;
			raiz = nullptr;
			delete actual;
		}
		else {
			buscarClave(nullptr, raiz, clave);
		}

	}

	void buscarClave(NodoAB *padre, NodoAB *nodo, int clave) {
		//El nodo es una hoja
		if (nodo->clave == clave && nodo->esHoja()) {
			if (padre->izq == nodo) {
				actual = padre->izq;
				padre->izq = nullptr;
				delete actual;
			}
			else {
				actual = padre->der;
				padre->der = nullptr;
				delete actual;
			}
		
			//El nodo es interior con un hijo
		}
		else if (nodo->clave == clave && nodo->esInteriorUnHijo() && nodo == raiz)
			if (raiz->izq != nullptr) { 
				actual = raiz;
				raiz = raiz->izq; 
				delete actual;
			}
			else {
				actual = raiz;
				raiz = raiz->der;
				delete actual;
			}

			//El nodo es interior con un hijo
		else if (nodo->clave == clave && nodo->esInteriorUnHijo())
			if (padre->izq == nodo && nodo->izq != nullptr) {
				actual = padre->izq;
				padre->izq = nodo->izq;
				delete actual;
			}
			else if (padre->izq == nodo && nodo->der != nullptr) {
				actual = padre->izq;
				padre->izq = nodo->der;
				delete actual;
			}
			else if (padre->der == nodo && nodo->izq != nullptr) {
				actual = padre->der;
				padre->der = nodo->izq;
				delete actual;
			}
			else {
				actual = padre->der;
				padre->der = nodo->der;
				delete actual;
			}

		//El nodo es interior con dos hijos
		else if (nodo->clave == clave) {
			// La raiz del arbol izquierdo es hoja 
			// o un nodo interior con un hijo.
			if (nodo->izq->esHoja() || (nodo->izq->esInteriorUnHijo() && nodo->izq->der == nullptr)) {
				actual = nodo->izq;
				nodo->clave = nodo->izq->clave;
				nodo->izq = nodo->izq->izq;
				delete actual;
			}
			else {
				actual = nodo;
				nodo->clave = valorMax(nodo->izq, nodo->izq->der);
				delete actual;
			}
		}
		else if (clave < nodo->clave && nodo->izq != nullptr)
			buscarClave(nodo, nodo->izq, clave);
		else if (clave > nodo->clave && nodo->der != nullptr)
			buscarClave(nodo, nodo->der, clave);
	}

	int valorMax(NodoAB *padre, NodoAB *nodo) {
		while (nodo->der != nullptr) {
			padre = nodo;
			nodo = nodo->der;
		}
		padre->der = nodo->izq;
		return nodo->clave;
	}

	void imprimir() {
		if (raiz != nullptr)
			imprimirEnOrden(raiz);
		else
			cout<<"Arbol vacio";
	}
	void imprimirEnOrden(NodoAB *nodo) {
		if (nodo != nullptr) {
			imprimirEnOrden(nodo->izq);
			cout<<nodo->clave << " ";
			imprimirEnOrden(nodo->der);
		}
	}

	void EliminarA() {
		if (raiz != nullptr)
			EliminarArbol(raiz);
		else
			cout << "Arbol vacio";
	}

	void EliminarArbol(NodoAB *nodo) {
		if (nodo != nullptr) {
			EliminarArbol(nodo->izq);
			EliminarArbol(nodo->der);
			delete nodo;
			
		}
	}

	

};