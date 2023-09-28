using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 1. Creo la primera estrategia para comparar Alumnos
	public class EstrategiaPorDNI : Estrategia
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return  alumno.getDNI() == alumno2.getDNI();
		}
		
		public bool sosMayor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getDNI() > alumno2.getDNI() ;
		}
		
		public bool sosMenor(Comparable a, Comparable b)
		{
			IAlumno alumno = (IAlumno) a;
			IAlumno alumno2 = (IAlumno) b;
			return alumno.getDNI() < alumno2.getDNI() ;
		}
	}
}
