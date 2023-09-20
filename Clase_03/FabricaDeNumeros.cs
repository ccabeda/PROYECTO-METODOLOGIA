using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 5. 
//Paso 2: Creo las fabricas, donde aqui creo números de forma aleatoria o no.
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public FabricaDeNumeros()
		{
		}
		
		public override Comparable crearPorTeclado()
		{
			Console.WriteLine("Ingrese un número: ");
			int valor = int.Parse(Console.ReadLine());
			Numero numero = new Numero(valor);
			return numero;
		}
		
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios(); //utilizo el generador de datos aleatorio
			Console.WriteLine("Ingrese la cantidad de digitos del número : ");
			int cant = int.Parse(Console.ReadLine());
			Numero numero = new Numero(generador.numeroAleatorio(cant));
			return numero;
			
		}
	}
}
