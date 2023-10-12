using System;

namespace Trabajo_metodologia
{
//PRACTICA 4 EJERCICIOS 7 OPCIONAL. Cree StudentFactory que ya crea los alumnos decorados
	public class StudentsFactory : FabricaDeComparables
	{
		public StudentsFactory()
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
			IAlumno alumno = new Alumno(nombre,dni,legajo,promedio);
			IAlumno decorar = new DecoratorLegajo(alumno);
            decorar = new DecoratorNotaEnLetras(decorar);
            decorar = new DecoratorNotaFinal(decorar);
            decorar = new DecoratorOrdenSecuencial(decorar);
            decorar = new DecoratorCuadro(decorar);
			return decorar;
		}
			
		
		public override Comparable crearAleatorio()
		{
			Manejador manejador = crearCadenaDeResponsabilidades();
			GeneradorDeDatosAleatorios generador = GeneradorDeDatosAleatorios.getInstance();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = generador.stringAleatorio(numero);
			int dni = generador.numeroAleatorio(8);
			int legajo = generador.numeroAleatorio(4);
			Random rd = new Random();
			double promedio = Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2);
			IAlumno alumno = new Alumno(nombre,dni,legajo,promedio);
			IAlumno decorar = new DecoratorLegajo(alumno);
            decorar = new DecoratorNotaEnLetras(decorar);
            decorar = new DecoratorNotaFinal(decorar);
            decorar = new DecoratorOrdenSecuencial(decorar);
            decorar = new DecoratorCuadro(decorar);
			return decorar;
		}
		
		public override Comparable crearDesdeArchivo()
		{
			Manejador manejador = crearCadenaDeResponsabilidades();
			GeneradorDeDatosAleatorios generador = GeneradorDeDatosAleatorios.getInstance();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = generador.stringDesdeArchivo(numero);
			int dni = ((int)generador.numeroDesdeArchivo(8));
			int legajo = ((int)generador.numeroDesdeArchivo(4));
			Random rd = new Random();
			double promedio = Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2);
			IAlumno alumno = new Alumno(nombre,dni,legajo,promedio);
			IAlumno decorar = new DecoratorLegajo(alumno);
            decorar = new DecoratorNotaEnLetras(decorar);
            decorar = new DecoratorNotaFinal(decorar);
            decorar = new DecoratorOrdenSecuencial(decorar);
            decorar = new DecoratorCuadro(decorar);
			return decorar;
		}
	}
}
