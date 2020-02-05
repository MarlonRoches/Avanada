#include "pch.h"
#include "FIjo.h"


FIjo::FIjo()
{
}


FIjo::~FIjo()
{
}

void FIjo::calcularsueldo(FIjo *empleado)
{
	empleado->sueldo = sueldobase + complemento *(añostrabajados - añodeentrada);
}
