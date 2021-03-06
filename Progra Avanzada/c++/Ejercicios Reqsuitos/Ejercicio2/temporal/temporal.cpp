// ejemplo arbol binario.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
#include<string>
using namespace std;
struct Nodo
{
public:
	Nodo *siguiente;
	int valor;
};

int contador = 0;
struct Pila
{
public:
	Nodo* cabeza;
	//metodo que agrega un elemento a la pila
	void Push(int num)
	{
		Nodo *nuevo = new Nodo;
		nuevo->valor = num;
		if (cabeza == NULL)
		{
			cabeza = nuevo;
		}
		else
		{
			nuevo->siguiente = cabeza;
			cabeza = nuevo;
		}
	}
	//metodo para retornar el valor de cada nodo
	int Pop()
	{
		if (cabeza == NULL)
		{
			return NULL;
		}
		else
		{

			Nodo* tmp = cabeza;
			cabeza = tmp->siguiente;
			return tmp->valor;
		}
	}


};

Pila pila;


class node {
public:
	int value;
	node *left;
	node *right;
};

class btree {
public:
	btree();
	~btree();
	void preorder_push();
	void preorder_search(node *leaf);
	void insert(int key);
	node *search(int key);
	void destroy_tree();
	void inorder_print();
	void postorder_print();
	void preorder_print();

private:
	void destroy_tree(node *leaf);
	void insert(int key, node *leaf);
	node *search(int key, node *leaf);
	void inorder_print(node *leaf);
	void postorder_print(node *leaf);
	void preorder_print(node *leaf);

	node *root;
};


btree::btree() {
	root = NULL;
}

btree::~btree() {
	destroy_tree();
}

void btree::destroy_tree(node *leaf) {
	if (leaf != NULL) {
		destroy_tree(leaf->left);
		destroy_tree(leaf->right);
		delete leaf;
	}
}

void btree::insert(int key, node *leaf) {

	if (key < leaf->value) {
		if (leaf->left != NULL) {
			insert(key, leaf->left);
		}
		else {
			leaf->left = new node;
			leaf->left->value = key;
			leaf->left->left = NULL;
			leaf->left->right = NULL;
		}
	}
	else if (key >= leaf->value) {
		if (leaf->right != NULL) {
			insert(key, leaf->right);
		}
		else {
			leaf->right = new node;
			leaf->right->value = key;
			leaf->right->right = NULL;
			leaf->right->left = NULL;
		}
	}

}

void btree::insert(int key) {
	if (root != NULL) {
		insert(key, root);
	}
	else {
		root = new node;
		root->value = key;
		root->left = NULL;
		root->right = NULL;
	}
}

node *btree::search(int key, node *leaf) {
	if (leaf != NULL) {
		if (key == leaf->value) {
			return leaf;
		}
		if (key < leaf->value) {
			return search(key, leaf->left);
		}
		else {
			return search(key, leaf->right);
		}
	}
	else {
		return NULL;
	}
}

node *btree::search(int key) {
	return search(key, root);
}

void btree::destroy_tree() {
	destroy_tree(root);
}

void btree::inorder_print() {
	inorder_print(root);
	cout << "\n";
}

void btree::inorder_print(node *leaf) {
	if (leaf != NULL) {
		inorder_print(leaf->left);
		cout << leaf->value << ",";
		inorder_print(leaf->right);
	}
}

void btree::postorder_print() {
	postorder_print(root);
	cout << "\n";
}

void btree::postorder_print(node *leaf) {
	if (leaf != NULL) {
		inorder_print(leaf->left);
		inorder_print(leaf->right);
		cout << leaf->value << ",";
	}
}

void btree::preorder_print() {
	preorder_print(root);
	cout << "\n";
}

void btree::preorder_print(node *leaf) {
	if (leaf != NULL) {
		cout << leaf->value << ",";
		inorder_print(leaf->left);
		inorder_print(leaf->right);
	}
}
//funcion que manda a llamar la funcion que encuentra los valores pares
void btree::preorder_push() {
	preorder_search(root);
	cout << "\n";
}
//en esta funcion cada dato que sea par se le hara un push a una lista simple
void btree::preorder_search(node *leaf) {
	if (leaf != NULL) {
		if (leaf->value % 2 == 0)
		{
			contador++;
			pila.Push(leaf->value);
		}
		preorder_search(leaf->left);
		preorder_search(leaf->right);
	}
}


int main() {

	//btree tree;
	btree *tree = new btree();
	Pila unaPila = Pila();
	pila = unaPila;
	for (int i = 0; i < 50; i++)
	{
		tree->insert(rand() % 100);
	}


	cout << "pre order\n";
	tree->preorder_print();
	cout << "in order\n";
	tree->inorder_print();
	cout << "post order\n";
	tree->postorder_print();
	//mando a llamar el metodo para creaer pila
	tree->preorder_push();
	//destruyo el arbol anterior liberando el stack
	delete tree;
	//creo un nuevo arbol
	btree *tree2 = new btree();
	for (int i = 0; i < contador; i++)
	{
		// le mando como parametros los que se encuentran en la pila
		int n = 0;
		n = pila.Pop();
		tree2->insert(n);
	}
	cout << "pre order\n";
	tree2->preorder_print();
	cout << "in order\n";
	tree2->inorder_print();
	cout << "post order\n";
	tree2->postorder_print();


	getchar();
}

