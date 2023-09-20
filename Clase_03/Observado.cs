using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 4. Paso 1: creo la interfaz Observado con los metodos 
	public interface Observado
	{
		void agregarObservador(Observador o);
		void quitarObservador(Observador o);
		void notificar();
	}
}
