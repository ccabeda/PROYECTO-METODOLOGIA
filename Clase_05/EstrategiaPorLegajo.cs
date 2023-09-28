using System;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 1. Creo la primera estrategia para comparar Alumnos
	public class EstrategiaPorLegajo : Estrategia
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return  alumno.getLegajo() == alumno2.getLegajo();
		}
		
		public bool sosMayor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getLegajo() > alumno2.getLegajo() ;
		}
		
		public bool sosMenor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getLegajo() < alumno2.getLegajo() ;
		}
	}
}
