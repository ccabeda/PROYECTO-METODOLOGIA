using System;

namespace Trabajo_metodologia
{
	// EJERCICIO 1. Creamos una interface simple con algunos metodos que comparen objetos
	public interface Comparable
	{
		bool sosIgual (Comparable objeto);
		bool sosMenor (Comparable objeto);
		bool sosMayor (Comparable objeto);	
	}
}
