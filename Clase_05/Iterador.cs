using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 6. Paso 1, creo la interfaz Iterador con los metodospara recorrer las diferentes coleccionables
	public interface Iterador
	{
	   void primero();
       void siguiente();
       bool fin();
       Comparable actual();
		
	}
}
