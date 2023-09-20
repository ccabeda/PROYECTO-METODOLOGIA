using System;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 1. Creo la primera estrategia para comparar Alumnos
	public class EstrategiaPorPromedio : Estrategia
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
			Alumno alumno = (Alumno) a;
			Alumno alumno2 = (Alumno) b;
			return  alumno.Promedio == alumno2.Promedio;
		}
		
		public bool sosMayor(Comparable a, Comparable b)
		{
			Alumno alumno = (Alumno) a;
			Alumno alumno2 = (Alumno) b;
			return alumno.Promedio > alumno2.Promedio ;
		}
		
		public bool sosMenor(Comparable a, Comparable b)
		{
			Alumno alumno = (Alumno) a;
			Alumno alumno2 = (Alumno) b;
			return alumno.Promedio < alumno2.Promedio ;
		}
	}
}
