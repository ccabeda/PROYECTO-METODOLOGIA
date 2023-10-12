using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 3. Creo la clase LectorDeDatos con las funciones que leen palabras y numeros
public class LectorDeDatos : Manejador
	{
		//PRACTICA 7 EJERCICIO 4. Utilizo Singleton, poniendo privado el constructor y creando getInstance
		private static LectorDeDatos unicoLectorDatos = null;	
	
		private LectorDeDatos(Manejador manejador) : base(manejador) //PRACTICA 7 EJERCICIO 1. Paso 2: Heredo manejador y uso los metodos que sabe hacer cada sucesor
		{
		}
		
		public override int numeroPorTeclado()
		{
			Console.WriteLine("Ingrese unicamente un número: ");
			int numero = int.Parse(Console.ReadLine());
			return numero;
		}
		
		public override string stringPorTeclado()
		{
			Console.WriteLine("Ingrese unicamente una palabra: ");
			string palabra = Console.ReadLine();
			return palabra;
		}
		
		public static LectorDeDatos getInstance()
 		{
 			if(unicoLectorDatos == null)
 				unicoLectorDatos = new LectorDeDatos(GeneradorDeDatosAleatorios.getInstance());
 			return unicoLectorDatos;
		}
	}
}
