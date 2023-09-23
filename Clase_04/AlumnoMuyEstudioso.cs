using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 4 EJERCICIO 2. Creo la subclade de Alumno que reimplemente mostrarCalificación
	public class AlumnoMuyEstudioso : Alumno , IAlumno
	{
		public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio) : base(nombre, dni,legajo,promedio)
		{
			
		}
		
		public override int responderPregunta(int pregunta)
		{
			return pregunta % 3;
		}
		
		
	}
}
