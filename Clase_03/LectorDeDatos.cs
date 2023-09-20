using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 3. Creo la clase LectorDeDatos con las funciones que leen palabras y numeros
	public class LectorDeDatos
	{
		public LectorDeDatos() //constructor
		{
		}
		
		public int numeroPorTeclado()
		{
			Console.WriteLine("Ingrese unicamente un número: ");
			int numero = int.Parse(Console.ReadLine());
			return numero;
		}
		
		public string stringPorTeclado()
		{
			Console.WriteLine("Ingrese unicamente una palabra: ");
			string palabra = Console.ReadLine();
			return palabra;
		}
	}
}
