using System;

namespace Trabajo_metodologia
{
//PRACTICA 5 EJERCICIO 5. paso 3: creo clases que sean "comportamientos" con una variable de aula
	public class OrdenInicio : OrdenEnAula1
	{
		private Aula aula;//receptor
		
		public OrdenInicio(Aula a)
		{
			aula = a;
		}
		
		public void ejecutar()
		{
			aula.comenzar();
		}
	}
}
