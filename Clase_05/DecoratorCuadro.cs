using System;

namespace Trabajo_metodologia 
{
//PRACTICA 4 EJERCICIO 6. Paso 4: Creo los decoradores que hereden la clase abstracta y override a los metodos que quieren modificar
	public class DecoratorCuadro : AdicionalDecorator
	{
		public DecoratorCuadro(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			string a = "**************************************";
			a += "\n *  " + alumno.mostrarCalificacion() + "*";
            a += "\n**************************************";
            return a;
		}
	}
}
