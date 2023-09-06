using System;

namespace Trabajo_metodologia
{
	//EJERCICIO 3. Creo la clase coleccionable con sus metodos
	public interface Coleccionable
	{
		int cuantos();
    	Comparable minimo();
    	Comparable maximo();
    	void agregar(Comparable comparable);
    	bool contiene(Comparable comparable);
	}
}
