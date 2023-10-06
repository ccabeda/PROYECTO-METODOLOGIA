using System;

namespace Trabajo_metodologia
{
//PRACTICA 4 EJERCICIO 6. Paso 4: Creo los decoradores que hereden la clase abstracta y override a los metodos que quieren modificar
//NOTA: CADA DECORADOR, LO VAS METIENDO DENTRO DE OTRA COMO UNA MAMUSHKA, LLAMANDO MOSTRARCALIFICACION EN TODOS.	
public class DecoratorLegajo : AdicionalDecorator
	{
		public DecoratorLegajo(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			//no utilizo base.alumno porque al no haber una variable alumno en esta clase se usa la de la super ya 
			return alumno.getNombre() + " (" + alumno.getLegajo() + ")           " + alumno.getCalificacion();
		}
	}
}
