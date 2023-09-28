using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
			//PRACTICA 2 EJERCICIO 6. Paso 2, creo los iteradores de los diferentes formas con las funciones de iterador
	public class IteradordePila : Iterador
	{
		private List <Comparable> paginas;
		private int paginaActual;
		
		public IteradordePila(Pila pila)
		{
			paginas = pila.Elementos;
			primero();
		}
		
		public void primero()
		{
			paginaActual = (paginas.Count) - 1;
		}
		
		public void siguiente()
		{
			paginaActual = paginaActual - 1;
		}
		
		public bool fin()
		{
			if (paginaActual == 0)
            {
                return true;
            }
            return false;
		}
		
		public Comparable actual()
		{
			return paginas[paginaActual];
		}
	}
}
