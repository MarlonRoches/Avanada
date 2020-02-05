#include "ArbolBB.cpp"

#include<iostream>
using namespace std;

int main() {
	ArbolBB *arbol = new ArbolBB();
	arbol->insertar(4);
	arbol->insertar(1);
	arbol->insertar(5);
	arbol->insertar(3);
	arbol->insertar(6);
	arbol->insertar(6);
	arbol->insertar(7);
	arbol->eliminar(6);
	
	arbol->imprimir();
	arbol->EliminarA();
	system("pause");
	return 0;

}
