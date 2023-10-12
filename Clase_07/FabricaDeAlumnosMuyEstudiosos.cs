using System;

namespace Trabajo_metodologia
{

	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
	{
		public FabricaDeAlumnosMuyEstudiosos()
		{
		}
		
		public override Comparable crearPorTeclado()
		{
			Console.WriteLine("Ingrese el nombre del alumno: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el DNI: ");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el legajo: ");
			int legajo = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el promedio: ");
			double promedio = double.Parse(Console.ReadLine());
			AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
			return alumno;
		}
		
		public override Comparable crearAleatorio()
		{
			Manejador manejador = crearCadenaDeResponsabilidades();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = manejador.stringAleatorio(numero);
			int dni = manejador.numeroAleatorio(8);
			int legajo = manejador.numeroAleatorio(4);
			Random rd = new Random();
			double promedio = Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2);
			AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
			return alumno;
		}
		
		public override Comparable crearDesdeArchivo()
		{
			Manejador manejador = crearCadenaDeResponsabilidades();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = manejador.stringDesdeArchivo(numero);
			int dni = ((int)manejador.numeroDesdeArchivo(3));
			int legajo = ((int)manejador.numeroDesdeArchivo(3));
			Random rd = new Random();
			double promedio = Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2);
			AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
			return alumno;
		}
	}
}
