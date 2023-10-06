using System;

namespace Trabajo_metodologia
{
	//PRACTICA 1 EJERCICIO 11 comparando por DNI (Utilice la clase Numero como referencia ya que es casi igual)
	public class Persona : Comparable
	{
		// Atributos
		private string nombre;
		private int dni;
		
		// Constructor
		public Persona(string n, int d)
		{
			nombre = n;
			dni = d;
		}
		//Getters
		public  string Nombre
		{
			get {return nombre;}
		}
		
		public  int Dni
		{
			get {return dni;}
		}
		
		public virtual bool sosIgual(Comparable c)
		{
			Persona p = (Persona)c;
			return dni == p.dni;
		}
		
		public virtual bool sosMenor(Comparable c)
		{
			Persona p = (Persona)c;
			return dni > p.dni;
	    }
		
		public virtual bool sosMayor(Comparable c)
		{
			Persona p = (Persona)c;
			return dni < p.dni;
        }
		
		public override string ToString()
        {
			return "Nombre: "+nombre.ToString();
        }
	}
}