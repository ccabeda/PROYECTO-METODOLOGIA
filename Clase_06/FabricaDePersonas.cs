using System;

namespace Trabajo_metodologia
{

	public class FabricaDePersonas : FabricaDeComparables
	{
		//Creado adicionalmente.
		public FabricaDePersonas()
		{
		}
		
		public override Comparable crearPorTeclado()
		{
			Console.WriteLine("Ingrese el nombre del alumno: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el DNI: ");			
			int dni = int.Parse(Console.ReadLine());
			Persona persona = new Persona(nombre,dni);
			return persona;
		}
		
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = generador.stringAleatorio(numero);
			int dni = generador.numeroAleatorio(8);
			Persona persona = new Persona(nombre,dni);
			return persona;
		}
	}
}
