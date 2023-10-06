using System;

namespace Trabajo_metodologia
{
//PRACTICA 5 EJERCICIO 3. Creo la clase Aula.
//PRACTICA 5 EJERCICIO 5. paso 1: clase con comportamiento basico 
	public class Aula
	{
		private Teacher teacher; //variable
		
		public Aula(Teacher t) //constructor
		{
			teacher = t;
		}
		
		public void comenzar() //metodos
		{
			Console.WriteLine("Creando Teacher");
			Teacher teacher = new Teacher();	
		}
		
		public void nuevoAlumno(IAlumno alumno)
		{
            teacher.goToClass(new AlumnoAdapter(alumno));
            Console.WriteLine("Nuevo alumno agregado");
		}
		
		public void claseLista()
		{
			teacher.teachingAClass();
			Console.WriteLine("La clase esta lista");
		}
	}
}
