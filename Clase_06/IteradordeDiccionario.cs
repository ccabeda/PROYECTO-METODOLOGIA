using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 6. Paso 2, creo los iteradores de los diferentes formas con las funciones de iterador
	public class IteradordeDiccionario : Iterador
	{
		private List <Comparable> paginas;
		private int paginaActual;
		
		public IteradordeDiccionario(Diccionario dic)
		{
			paginas = dic.Dic.Elementos; //Uso asi porque dic.Dic ase referencia a un conjunto, y en conjunto el geter y setter es Elementos
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
