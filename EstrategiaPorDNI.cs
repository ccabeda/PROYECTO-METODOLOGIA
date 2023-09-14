using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 1. Creo la primera estrategia para comparar Alumnos
	public class EstrategiaPorDNI : Estrategia
	{
		public bool sosIgual(Comparable a, Comparable b)
		{
			Alumno alumno = (Alumno) a;
			Alumno alumno2 = (Alumno) b;
			return  alumno.Dni == alumno2.Dni;
		}
		
		public bool sosMayor(Comparable a, Comparable b)
		{
			Alumno alumno = (Alumno) a;
			Alumno alumno2 = (Alumno) b;
			return alumno.Dni > alumno2.Dni ;
		}
		
		public bool sosMenor(Comparable a, Comparable b)
		{
			Alumno alumno = (Alumno) a;
			Alumno alumno2 = (Alumno) b;
			return alumno.Dni < alumno2.Dni ;
		}
	}
}
