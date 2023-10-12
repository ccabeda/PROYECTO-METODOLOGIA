﻿using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 5. 
//Paso 2: Creo las fabricas, donde aqui creo alumnos de forma aleatoria o no.
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		
		public FabricaDeAlumnos()
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
			Alumno alumno = new Alumno(nombre,dni,legajo,promedio);
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
			Alumno alumno = new Alumno(nombre,dni,legajo,promedio);
			return alumno;
		}
		
		public override Comparable crearDesdeArchivo()
		{
			Manejador manejador = crearCadenaDeResponsabilidades();
			Console.WriteLine("Ingrese la cantidad de letras del nombre: ");
			int numero = int.Parse(Console.ReadLine());
			string nombre = manejador.stringDesdeArchivo(numero);
			double dni = manejador.numeroDesdeArchivo(3);
			double legajo = manejador.numeroDesdeArchivo(3); //da desbordamiento (ya intente con math round)
			Random rd = new Random();
			double promedio = Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2);
			Alumno alumno = new Alumno(nombre,(int)dni,(int)legajo,promedio);
			return alumno;
		}
		
	}
}
