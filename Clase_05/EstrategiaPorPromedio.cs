using System;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 1. Creo la primera estrategia para comparar Alumnos
	//Las tuve que cambiar para que comparen IAlumnos y no solo Alumnos
	public class EstrategiaPorPromedio : Estrategia
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return  alumno.getPromedio() == alumno2.getPromedio();
		}
		
		public bool sosMayor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getPromedio() > alumno2.getPromedio() ;
		}
		
		public bool sosMenor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getPromedio() < alumno2.getPromedio() ;
		}
	}
}
