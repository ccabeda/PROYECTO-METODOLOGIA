using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 5. 
//Paso 1: creo la superclase abstracta que a base de if elija que objeto crear.
//Creo el metodo en abstract asi lo heredan y el metodo static 
	public abstract class FabricaDeComparables
	{
		
		public static Comparable crearComparablePreseteado()
		{
			return crearPorTeclado(1); //numero por defecto
		}
		
		public static Comparable crearPorTeclado(int opcion)
		{
			FabricaDeComparables fabrica = null;
			
			if(opcion==1)
			{
				fabrica = new FabricaDeNumeros();
			}
			else if(opcion == 2)
			{
				fabrica = new FabricaDeAlumnos();
			}
			else if(opcion == 3)
			{
				fabrica = new FabricaDeAlumnosMuyEstudiosos();
			}
			else if(opcion == 4)
			{
				fabrica = new StudentsFactory();
			}
			else if(opcion == 5)
			{
				fabrica = new FabricaDeAlumnosCompuestos();
			}
			else if(opcion == 6)
			{
				fabrica = new FabricaDePersonas();
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
				if(opcion == 1)
			{
				fabrica = new FabricaDeNumeros();
			}
			else if(opcion == 2)
			{
				fabrica = new FabricaDeAlumnos();
			}
			else if(opcion == 3)
			{
				fabrica = new FabricaDeAlumnosMuyEstudiosos();
			}
			else if(opcion == 4)
			{
				fabrica = new StudentsFactory();
			}
			else if(opcion == 5)
			{
				fabrica = new FabricaDeAlumnosCompuestos();
			}
			else if(opcion == 6)
			{
				fabrica = new FabricaDePersonas();
			}
			else
			{
				fabrica = new FabricaDeNumeros();
			}
            return fabrica.crearAleatorio();
		}
		
		public abstract Comparable crearAleatorio();
		
		//PRACTICA 7 EJERCICIO 2. Creo el metodo que crea los manejadores aca y en cada fabrica
		public static Comparable crearDesdeArchivo(int opcion)
		{
			FabricaDeComparables fabrica = null;
			
			if(opcion==1)
			{
				fabrica = new FabricaDeNumeros();
			}
			else if(opcion == 2)
			{
				fabrica = new FabricaDeAlumnos();
			}
			else if(opcion == 3)
			{
				fabrica = new FabricaDeAlumnosMuyEstudiosos();
			}
			else if(opcion == 4)
			{
				fabrica = new StudentsFactory();
			}
			else if(opcion == 5)
			{
				fabrica = new FabricaDeAlumnosCompuestos();
			}
			else if(opcion == 6)
			{
				fabrica = new FabricaDePersonas();
			}
			else
			{
				fabrica = new FabricaDeNumeros();
			}
			return fabrica.crearDesdeArchivo();
		}
		
		public abstract Comparable crearDesdeArchivo();
		
		public Manejador crearCadenaDeResponsabilidades() //creo la cadena de repsonsables aca para aplicarla en la fabrica
		{
			Manejador manejador = GeneradorDeDatosAleatorios.getInstance(); //utilizo getInstance por Singleton
			manejador = LectorDeDatos.getInstance();
			manejador = LectorDeArchivos.getInstance();
			return manejador;
		}

		
	}
}

