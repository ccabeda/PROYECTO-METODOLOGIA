using System;

namespace Trabajo_metodologia
{
	//PRACTICA 3 EJERCICIO 9.Creo la comparacion de los Profesores por antiguedad.
	public class EstrategiaPorAntiguedad : Estrategia
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
			Profesor profesor = (Profesor) a;
			Profesor profesor2 = (Profesor) b;
			return  profesor.Dni == profesor2.Dni;
		}
		
		public bool sosMayor(Comparable a, Comparable b)
		{
			Profesor profesor = (Profesor) a;
			Profesor profesor2 = (Profesor) b;
			return profesor.Dni > profesor2.Dni ;
		}
		
		public bool sosMenor(Comparable a, Comparable b)
		{
			Profesor profesor = (Profesor) a;
			Profesor profesor2 = (Profesor) b;
			return profesor.Dni < profesor2.Dni ;
		}
	}
}
