
using System;

namespace Trabajo_metodologia
{
//PRACTICA 5 EJERCICIO 7. Creo la peticion ordenllegaalumno con aula como receptor
	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		private Aula aula; //receptor
		
		public OrdenLlegaAlumno(Aula a)
		{
			aula = a;
		}
		
		public void ejecutar(Comparable c)
		{		
			aula.nuevoAlumno((IAlumno)c);
		}
	}
}