using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
			//PRACTICA 2 EJERCICIO 6. Paso 2, creo los iteradores de los diferentes formas con las funciones de iterador
	public class IteradordeConjunto : Iterador
	{
		private List <Comparable> paginas;
		private int paginaActual;
		
		public IteradordeConjunto(Conjunto conjunto)
		{
			paginas = conjunto.Elementos;
			primero();
		}
		
		public void primero()
		{
			paginaActual = 0;
		}
		
		public void siguiente()
		{
			paginaActual = paginaActual + 1;
		}
		
		public bool fin()
		{
			return paginaActual >= paginas.Count;
		}
		
		public Comparable actual()
		{
			return paginas[paginaActual];
		}
	}
}
