using System;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 1. Creo la primera estrategia para comparar Alumnos
	//Las tuve que cambiar para que comparen IAlumnos y no solo Alumnos
	public class EstrategiaPorNombre : Estrategia
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return  alumno.getNombre() == alumno2.getNombre();
		}
		
		public bool sosMayor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getNombre().CompareTo(alumno2.getNombre()) > 0;
		}
		
		public bool sosMenor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getNombre().CompareTo(alumno2.getNombre()) < 0;
		}
		
	}
}
