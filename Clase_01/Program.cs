using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{		
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Trabajo de Metodologia");
			//EJERCICIO 7. Creo pila y cola y le aplico los metodos informar y llenar (que reciben coleccionable )
			//EJERCICIO 9. Hago lo mismo con una ColeccionMultiple
			//Coleccionable pila = new Pila();

            //Coleccionable cola = new Cola();
            
            //Coleccionable multiple = new ColeccionMultiple((Pila) pila, (Cola) cola );

            //llenar(pila);

            //llenar(cola);
            
            //informar(pila);

            //informar(cola);
            
            //informar(multiple);
            
            //EJERCICIO 14. Crear una ColecciónMultiple de personas e infromar.
            //Coleccionable pila = new Pila();

            //Coleccionable cola = new Cola();
            
            //Coleccionable multiple = new ColeccionMultiple((Pila) pila, (Cola) cola );

            //llenarPersonas(pila);
            
            //llenarPersonas(cola);
            
            //informarPersonas(multiple);
       
            //EJERCICIO 17. Creo una ColecciónMultiple de alumnos e informo
            Coleccionable cola = new Cola();
            
            Coleccionable pila = new Pila();
            
            Coleccionable multiple = new ColeccionMultiple((Pila) pila, (Cola) cola);
            
            llenarAlumnos(pila);
            
            llenarAlumnos(cola);
            
            informarAlumnos(multiple);
            
			Console.ReadKey(true);
		}
		//EJERCICIO 6. 
		public static void informar(Coleccionable c) //Recibe un coleccionable (pila o cola)
		{
			Console.WriteLine("Contiene "+ c.cuantos() + " Elementos");
			Console.WriteLine("Elemento minimo: " + c.minimo());
			Console.WriteLine("Elemento maximo: " + c.maximo());
			Console.WriteLine("Ingrese un número: ");
			int num = int.Parse(Console.ReadLine());
			Comparable comparable = new Numero(num);
			if (c.contiene(comparable))
			{
				Console.WriteLine("El elemento leído está en la colección");
			}
			else 
			{
				Console.WriteLine("El elemento leído no está en la colección");
			}
		}
		//EJERCICIO 5. Función que le agrega 20 Numeros al Comparable con la funcion Random
		public static void llenar(Coleccionable c)
		{
            Random rd = new Random();

            for (int i = 0; i < 20; i++)
            {
                c.agregar(new Numero(rd.Next(1, 100)));
            }
        }
		//EJERCICIO 12. Cree la función llenarPersonas que reciba un coleccionable y lo llene con 20 personas (nombre y "dni" al azar)
		public static void llenarPersonas(Coleccionable c)
		{
			  Random rd = new Random(); 
			
			string[] Lista = { "AGUSTIN", "LUCAS", "IGNACIO", "TOMAS", "SASHA", "MAURO", "CLARIBEL", "CORAL",
            "BRUNO", "BAUTISTA", "MARCOS", "MARTIN", "FABIANA", "GABRIELA", "MICAELA", "LIONEL", "ANDRES", "PABLO", "MAGALI" , "RICARDO" };

            for (int i = 0; i < 20; i++)
            {
                c.agregar(new Persona(Lista[rd.Next(20)], rd.Next(10000000, 99999999))); //agrega cualquiera de los 20 nombres y un "dni" ramdon entre 1 y 100
            }	
		}
		//EJERCICIO 14. Para que fincione, se creo tambien la función informarPersonas
		public static void informarPersonas(Coleccionable c) //Recibe un coleccionable (pila o cola)
		{
			Console.WriteLine("Contiene "+ c.cuantos() + " nombres");
			Console.WriteLine("Nombre minimo: " + c.minimo());
			Console.WriteLine("Nombre maximo: " + c.maximo());
			Console.WriteLine("Ingrese un nombre: ");
			string nombre = Console.ReadLine().ToUpper(); //ToUpper para leer los que ingresen en mayus
			Console.WriteLine("Ingrese su DNI: ");
			int dni = int.Parse(Console.ReadLine());
			Comparable comparable = new Persona(nombre,dni);
			if (c.contiene(comparable)) //compara dni y nombre, por lo que la mayoria de veces daria 1
			{
				Console.WriteLine("El nombre leído está en la colección");
			}
			else 
			{
				Console.WriteLine("El nombre leído no está en la colección");
			}
		}
		//EJERCICIO 16. Creo la función llenarAlumnos que llene un coleccionable con 20 alumnos, con sus "dni", "legajo" y "promedio". 
		public static void llenarAlumnos(Coleccionable c)
		{
            Random rd = new Random();

            string[] Lista = { "Agustin", "Lucas", "Ignacio", "Tomas", "Sasha", "Mauro", "Claribel", "Coral",
            "Bruno", "Bautista", "Marcos", "Martin", "Fabiana", "Gabriela", "Micaela", "Lionel", "Andres", "Pablo", "Magali" , "Ricardo" };

            for (int i = 0; i < 20; i++)
            {
            	double promedio = Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2); // Redondea el promedio a dos decimales
            	c.agregar(new Alumno(Lista[rd.Next(20)], rd.Next(10000000, 99999999), rd.Next(1000, 9999), promedio)); //agrega cualquiera de los 20 nombres y un "dni" ramdon entre 1 y 100
            }
        }
		//EJERCICIO 17. Ademas, para informar de alumnos se tuvo que crear esta función
		public static void informarAlumnos(Coleccionable c) //Recibe un coleccionable (pila o cola)
		{
			Console.WriteLine("Contiene "+ c.cuantos() + " alumnos");
			Console.WriteLine("Datos del alumno minimo: " + c.minimo());
			Console.WriteLine("Datos del alumno maximo: " + c.maximo());
			Console.WriteLine("Ingrese un nombre: ");
			string nombre = Console.ReadLine();
        	nombre = char.ToUpper(nombre[0]) + nombre.Substring(1).ToLower();   // Convierte la primera letra a mayúscula y el resto a minúscula
			Console.WriteLine("Ingrese su DNI: ");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese su legajo: ");
			int legajo = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese su promedio: ");
			double promedio = double.Parse(Console.ReadLine());
			Comparable comparable = new Alumno(nombre,dni,legajo,promedio);
			if (c.contiene(comparable)) // SIEMPRE VA A DAR QUE NO ESTA PORQUE CREA UN DNI ALEATORIO Y ES UN NUMERO SOLO (MEJORAR ESO DE RAMDOM)
			{
				Console.WriteLine("El nombre leído está en la colección");
			}
			else 
			{
				Console.WriteLine("El nombre leído no está en la colección");
			}
		}

		//EJERCICIO 19. Se podria hacer lo mismo sin interfacez, pero el costo seria escribir muchisimas mas lineas de codigo.		
		
	}
}