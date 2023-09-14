using System.Collections.Generic;
using System;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 1. Creo la interfaz con los metodos que utilizaran las diferentes estrategias
	public interface Estrategia
	{
		bool sosIgual (Comparable a, Comparable b);
		bool sosMayor (Comparable a, Comparable b);
		bool sosMenor (Comparable a, Comparable b);
		
	}
}
