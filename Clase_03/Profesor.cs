using System;
using System.Collections.Generic;
using System.Collections;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 8. Creo la clase proefsor que escriba y hable de algun tema.
	public class Profesor : Persona , Observado
		
	{
		private int antiguedad;
		private Estrategia estrategia;
		private List<Observador> observadores; //creo lista de Observadores
		private bool estaHablando; //para ver si esta hablando o no
		//constructor
		public Profesor(string nombre, int dni, int a):base(nombre,dni)
		{
			antiguedad = a;
			estrategia = new EstrategiaPorAntiguedad();
			observadores = new List<Observador>();
			estaHablando = false;
		}
		//getters
		public  int Antiguedad
		{
			get {return antiguedad;}
		}
		
		public  bool EstaHablando
		{
			get {return estaHablando;}
		}
		
		public  List<Observador> Observadores
		{
			get {return observadores;}
		}
		//PRACTICA 3 EJERCICIO 9.Creo la comparación por antiguedad de profesor
		public void Estrategia(Estrategia e)// Método para modificar la estrategia de comparación
        {
           estrategia = e;
        }
		
		public void hablarALaClase()
		{
			Console.WriteLine("Hablando de algún tema...");
			estaHablando = true;
			this.notificar(); //para cada observador de la lista, lo actualiza para que mire
		}
		
		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarrón...");
			estaHablando = false; 
			this.notificar(); //para cada observador de la lista, lo actualiza para que no mire
		}
		
		public void hacerSilencio()
		{
			Console.WriteLine("Silencia, no se distraigan");
		}

		
		public  override bool sosIgual(Comparable c)
		{
			return estrategia.sosIgual(this, c); 
		}										// El this es para referirse a donde se implemente. ej: alumno1.SosIgual(alumno2) donde this se refiere a alumno1, mientras que c a alumno2. 
		
		public override bool sosMenor(Comparable c)
		{
			return estrategia.sosMenor(this, c);
	    }
		
		public override bool sosMayor(Comparable c)
		{
			return estrategia.sosMayor(this, c);
        }
		
		//PRACTICA 3 EJERCICIO 4. Paso 3: Heredo Obrservado con los metodos 
		
		public void agregarObservador(Observador o)
		{
			observadores.Add(o);
		}
		
		public void quitarObservador(Observador o)
		{
			if (observadores.Contains(o))
			{
				observadores.Remove(o);
			}
		}
		
		public void notificar() //notificar actualiza a la lista de observadores que tiene el profesor
		{
			foreach (Observador o in observadores)
			{
				o.actualizar(this);
			}
		}
		
		
		 public override string ToString()
    	{
        // Llama al ToString() de la clase base (Persona) para obtener su representación
          string personaString = base.ToString();
          return personaString + ". Antiguedad: "+ antiguedad.ToString() + " Años.";
		 }
	}
}
