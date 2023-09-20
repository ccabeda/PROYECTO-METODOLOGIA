﻿using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{	
	//PRACTICA 1  EJERCICIO 15. Creo la clase alumno que es subclase de Persona.
	public class Alumno : Persona, Observador
	{
		private int legajo;
		private double promedio;
		private Estrategia estrategia; //PRACTICA 2 EJERCICIO 1. Creo una variable que sea de la interfaz que va a usar la estrategias
		
		public Alumno(string nombre, int dni, int l, double p): base(nombre, dni) //para que herede uso base y los atributos de persona
		{	
			legajo = l;
			promedio = p;
			estrategia = new EstrategiaPorNombre(); //PRACTICA 2 EJERCICIO 1. Agrego esto para defenir una estrategia default asi no se le pasa por parametro
		}
		
		public int Legajo
		{
			get {return legajo;}
		}
		
		public double Promedio
		{
			get {return promedio;}
		}
		
		public void Estrategia(Estrategia e)// Método para modificar la estrategia de comparación
        {
           estrategia = e;
        }
		
		//PRACTICA 1  EJERCICIO 18. Se agregaron los metodos de la interfaz Comparable (no tiene que heredarlo ya que persona lo hereda). UPLOATED: Cambio para usar el patron Estrategy.
		public  override bool sosIgual(Comparable c)
		{
			return estrategia.sosIgual(this, c); //CAMBIAMOS LAS MANERAS DE QUE ALUMNO UTILIZA LA INTERFAZ COMPARABLE PÁRA ASOSIARSE CON LA ESTRATEGIA
		}										// El this es para referirse a donde se implemente. ej: alumno1.SosIgual(alumno2) donde this se refiere a alumno1, mientras que c a alumno2. 
		
		public override bool sosMenor(Comparable c)
		{
			return estrategia.sosMenor(this, c);
	    }
		
		public override bool sosMayor(Comparable c)
		{
			return estrategia.sosMayor(this, c);
        }
		//PRACTICA 3 EJERCICIO 11. Creo las funciones
		public void prestarAtencion()
		{
			Console.WriteLine("Prestando atención...");
		}
		
		public virtual void distraerse() //elige una frase random y la escribe 
		{
			Random rd = new Random();
			string[] frases = { "Mirando el celular","Dibujando en el margen de la carpeta","Tirando aviones de papel"};
			int indice = rd.Next(frases.Length);
			string frase = frases[indice];
			Console.WriteLine(frase);
		}
		
		//PRACTICA 3 EJERCICIO 4. Paso 4: Heredo la interfaz Observador 
		public void actualizar(Observado o) //verifica si el observado es profesor
		{
			if (o is Profesor)
			{
				Profesor profesor = (Profesor) o;
				if (profesor.EstaHablando) //si esta hablando prestan atencion
				{
					prestarAtencion();
				}
				else
				{
					distraerse();
				}
			}
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
