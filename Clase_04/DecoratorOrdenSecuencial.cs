using System;

namespace Trabajo_metodologia
{
//PRACTICA 4 EJERCICIO 6. Paso 4: Creo los decoradores que hereden la clase abstracta y override a los metodos que quieren modificar
	public class DecoratorOrdenSecuencial : AdicionalDecorator
	{
		static int contador = 1;
		
		public DecoratorOrdenSecuencial(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			string calificacion = base.mostrarCalificacion();
			string final = calificacion.Insert(0,contador + ")");
			contador++;
			return final;
		}
	}
}
