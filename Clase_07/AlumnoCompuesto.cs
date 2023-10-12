using System;
using System.Collections.Generic;
using System.Collections;

namespace Trabajo_metodologia
{
//PRACTICA 6 EJERICIO 1. Paso 3: Creo clase AlumnoCompuesto que implemente todas las funciones en base a la lista que tiene.
//las reocrre y llama el metodo de alumno 
	public class AlumnoCompuesto : IAlumno
	{
		private List<IAlumno> lista;
		
		public AlumnoCompuesto() //constructor vacio
		{
			lista = new List<IAlumno>();
		}
		
		
		public List<IAlumno> Lista 
		 {
		 	get { return lista; }
		 	
		 	set { lista = value; }
		 }
		
		public void agregarHijo(IAlumno alumno)
		{
			lista.Add(alumno);
		}
		
		public void eliminarHijo(IAlumno alumno)
		{
			lista.Remove(alumno);
		}
		
		public string getNombre()
		{
			string nombre = "";
			foreach (IAlumno a in lista)
			{
				nombre = nombre + " " + a.getNombre() + " ";
			}
			return nombre;
		}
		
		public int responderPregunta(int pregunta)
		{
			int general = 0;
			int respuesta1 = 0;
			int respuesta2 = 0;
			int respuesta3 = 0;
			int maximo= 0;
			foreach (IAlumno a in lista)
			{
				general = a.responderPregunta(pregunta);
				if (general == 1)
				{
                    respuesta1 = respuesta1 + 1;
				}
                else if (general == 2)
				{
                    respuesta2 = respuesta2 + 1;
				}
                else if (general == 3)
				{
                    respuesta3 = respuesta3 + 1;
				}
			}
                
            int[] numeros = new int[3];
            numeros[0] = respuesta1;
            numeros[1] = respuesta2;
            numeros[2] = respuesta3;
                
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
            }
            int final = 0;
            if (maximo == numeros[0])
            {
                final = 1;
            }
            if (maximo == numeros[1])
            {
                final = 2;
            }
            if (maximo == numeros[2])
            {
                final = 3;
            }
            return final;
		}
		
		public void setCalificacion(int calificacion)
		{
			foreach (IAlumno a in lista)
			{
				a.setCalificacion(calificacion);
			}
		}
		
		public bool sosIgual(Comparable comparable)
		{
			bool resultado = false;
			foreach (IAlumno a in lista)
			{	
				if(a.sosIgual(comparable))
				{
					resultado = true;
				}
				if(resultado == true)
				{
					return resultado; //por si la lista es grande si ya el primero es true que retorne
				}
			}
			return resultado;
		 }
		
		public bool sosMayor(Comparable comparable)
		{
			bool resultado = false;
			foreach (IAlumno a in lista)
			{
				if(!a.sosMayor(comparable)) //si hay un solo alumno que no es mayor
				{
					return resultado;	//retorna false
				}
			}
			resultado = true; //si ninguno es menor, retorna true
			return resultado;
		}
		
		public bool sosMenor(Comparable comparable)
		{
			bool resultado = false;
			foreach (IAlumno a in lista)
			{
				if(!a.sosMenor(comparable)) //si hay un solo alumno que no es menor
				{
					return resultado;	//retorna false
				}
			}
			resultado = true; //si ninguno es mayor, retorna true
			return resultado;
		}
		
		//METODOS QUE NO PIDE EL ENUNCIADO EN BLANCO 
		
		public int getCalificacion()
		{
			return 0;
		}
		
		public double getPromedio()
		{
			return 0;
		}
		
		public int getDNI()
		{
			return 0;
		}
		
		public int getLegajo()
		{
			return 0;
		}
		
		public string mostrarCalificacion()
		{
			return "";
		}
	}
}
