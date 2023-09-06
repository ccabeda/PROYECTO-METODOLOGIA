/*
 * Creado por SharpDevelop.
 * Usuario: cabed
 * Fecha: 31/8/2023
 * Hora: 04:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Trabajo_metodologia
{
	//EJERCICIO 11 comparando por DNI (Utilice la clase Numero como referencia ya que es casi igual)
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
		public string Nombre
		{
			get {return nombre;}
		}
		
		public int Dni
		{
			get {return dni;}
		}
		
		public bool sosIgual(Comparable c)
		{
			Persona p = (Persona)c;
			return dni == p.dni;
		}
		
		public bool sosMenor(Comparable c)
		{
			Persona p = (Persona)c;
			return dni > p.dni;
	    }
		
		public bool sosMayor(Comparable c)
		{
			Persona p = (Persona)c;
			return dni < p.dni;
        }
		
		public override string ToString()
        {
			return "Nombre: "+nombre.ToString() + ". D.N.I: " + dni.ToString();
        }
	}
}