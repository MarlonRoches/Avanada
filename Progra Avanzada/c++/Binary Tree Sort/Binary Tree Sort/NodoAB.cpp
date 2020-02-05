#include<iostream>
using namespace std;

class NodoAB {
public:
	NodoAB(int x) {
		clave = x;
		izq = der = nullptr;
	}
	

	bool esHoja() {
		return izq == nullptr && der == nullptr;
	}

	bool esInteriorUnHijo() {
		return (izq == nullptr && der != nullptr) || (izq != nullptr && der == nullptr);
	}

	int clave;
	NodoAB *izq;
	NodoAB *der;
};