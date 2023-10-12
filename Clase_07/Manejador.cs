using System;

namespace Trabajo_metodologia
{
	//PRACTICA 7 EJERCICIO 1. Paso 1: creo el Manejador con los metodos de los sucesores, donde verifiquen si el sucesor no existe, y vayan mandando el metodo al que corresponda
	public abstract class Manejador
	{
		Manejador sucesor = null;
		
		public Manejador(Manejador s)
		{
			sucesor = s;
		}
		
		public virtual int numeroAleatorio(int max)
		{
			int numero = 0;
			if (sucesor != null)
			{
				numero = sucesor.numeroAleatorio(max);
			}
			return numero;
		}
		
		public virtual string stringAleatorio(int cant)
		{
			string palabra = null;
			if (sucesor != null)
			{
				palabra = sucesor.stringAleatorio(cant);
			}
			return palabra;
		}
		
		public virtual int numeroPorTeclado()
		{
			int numero = 0;
			if (sucesor != null)
			{
				numero = sucesor.numeroPorTeclado();
				
			}
			return numero;
		}
		
		public virtual string stringPorTeclado()
		{
			string palabra = null;
			if (sucesor != null)
			{
				 palabra = sucesor.stringPorTeclado();
			}
			return palabra;
		}
		//PRACTICA 7 EJERCICIO 3. Agrego la clase LectorDeArchivos
		public virtual double numeroDesdeArchivo(double max)
        {
			double numero = 0;
			if (sucesor != null)
			{
				numero = sucesor.numeroDesdeArchivo(max);
			}
			return numero;
        }
		
		public virtual string stringDesdeArchivo(int cant)
        {
			string palabra = null;
			if (sucesor != null)
			{
				palabra = sucesor.stringDesdeArchivo(cant);
			}
			return palabra;
        }
		
		
	}
}
