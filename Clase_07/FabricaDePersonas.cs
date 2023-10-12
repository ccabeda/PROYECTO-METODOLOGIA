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
			Manejador manejador = crearCadenaDeResponsabilidades();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = manejador.stringAleatorio(numero);
			int dni = manejador.numeroAleatorio(8);
			Persona persona = new Persona(nombre,dni);
			return persona;
		}
		
		public override Comparable crearDesdeArchivo()
		{
			Manejador manejador = crearCadenaDeResponsabilidades();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = manejador.stringDesdeArchivo(numero);
			int dni = ((int)manejador.numeroDesdeArchivo(3));
			Persona persona = new Persona(nombre,dni);
			return persona;
		}
	}
}
