using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 9.Creo una fabrica que cree profesores
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		public override Comparable crearPorTeclado()
		{
			Console.WriteLine("Ingrese el nombre del alumno: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el DNI: ");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la antiguedad: ");
			int promedio = int.Parse(Console.ReadLine());
			Profesor profesor = new Profesor(nombre,dni,promedio);
			return profesor;
		}
		
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = generador.stringAleatorio(numero);
			int dni = generador.numeroAleatorio(8);
			int antiguedad = generador.numeroAleatorio(2);
			Profesor profesor = new Profesor(nombre,dni,antiguedad);
			return profesor;
		}
	}
}
