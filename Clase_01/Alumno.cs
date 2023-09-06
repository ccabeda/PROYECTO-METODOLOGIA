using System;

namespace Trabajo_metodologia
{	
	//EJERCICIO 15. Creo la clase alumno que es subclase de Persona.
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		
		public Alumno(string nombre, int dni, int l, double p): base(nombre, dni) //para que herede uso base y los atributos de persona
		{	
			legajo = l;
			promedio = p;			
		}
		
		public int Legajo
		{
			get {return legajo;}
		}
		
		public double Promedio
		{
			get {return promedio;}
		}
		
		//EJERCICIO 18. Se agregaron los metodos de la interfaz Comparable (no tiene que heredarlo ya que persona lo hereda). para que funcione se pone new.
		public new bool sosIgual(Comparable c)
		{
			Alumno a = (Alumno)c;
			return legajo == a.legajo;
		}
		
		public new bool sosMenor(Comparable c)
		{
			Alumno a = (Alumno)c;
			return legajo > a.legajo;
	    }
		
		public new bool sosMayor(Comparable c)
		{
			Alumno a = (Alumno)c;
			return legajo < a.legajo;
        }
		
		 public override string ToString()
    	{
        // Llama al ToString() de la clase base (Persona) para obtener su representación
        string personaString = base.ToString();

        // Agrega la información adicional del promedio
        return personaString + ". Legajo: "+ legajo.ToString() + ". Promedio: "+ promedio.ToString() + ".";
    	}
	}
}
