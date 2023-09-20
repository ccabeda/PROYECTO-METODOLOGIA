using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 5. 
//Paso 1: creo la superclase abstracta que a base de if elija que objeto crear.
//Creo el metodo en abstract asi lo heredan y el metodo static 
	public abstract class FabricaDeComparables
	{
		public const int NUMERO = 1;
		public const int ALUMNO = 2;
		public static int PORDEFECTO = NUMERO;
		
		public static Comparable crearComparablePreseteado()
		{
			return crearPorTeclado(PORDEFECTO);
		}
		
		public static Comparable crearPorTeclado(int opcion)
		{
			FabricaDeComparables fabrica = null;
			if(opcion==2)
			{
				fabrica = new FabricaDeAlumnos();
			}
			else
			{
				fabrica = new FabricaDeNumeros();
			}
			return fabrica.crearPorTeclado();
		}
		
		public abstract Comparable crearPorTeclado();
		
		public static Comparable crearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica = null;
			if(opcion==2)
			{
				fabrica = new FabricaDeAlumnos();
			}
			else
			{
				fabrica = new FabricaDeNumeros();
			}
			return fabrica.crearPorTeclado();
		}
		
		public abstract Comparable crearAleatorio();
		
		
		
		
	}
}

