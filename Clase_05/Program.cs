using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{		
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Trabajo de Metodologia: ");
 
            //PRACTICA 1 EJERCICIO 14. Crear una ColecciónMultiple de personas e infromar.
            //Coleccionable pila = new Pila();

            //Coleccionable cola = new Cola();
            
            //Coleccionable multiple = new ColeccionMultiple((Pila) pila, (Cola) cola );

            //llenarPersonas(pila);
            
            //llenarPersonas(cola);
            
            //informarPersonas(multiple);
       
            //PRACTICA 1 EJERCICIO 17. Creo una ColecciónMultiple de alumnos e informo
            //Coleccionable cola = new Cola();
            
            //Coleccionable pila = new Pila();
            
            //Coleccionable multiple = new ColeccionMultiple((Pila) pila, (Cola) cola);
            
            //llenarAlumnos(pila);
            
            //llenarAlumnos(cola);
            
            //informarAlumnos(multiple);
            
		    //PRACTICA 2 EJERCICIO 8. Invocar imprimirElemento 
			//Coleccionable pila = new Pila();
			//Coleccionable cola = new Cola();
			//Coleccionable conjunto = new Conjunto();
			//Coleccionable dic = new Diccionario();
			//llenarAlumnos(pila);
			//llenarAlumnos(cola);
			//llenarAlumnos(conjunto);
			//llenarAlumnos(dic);
			//imprimirElemento(pila);
			//imprimirElemento(cola);
			//imprimirElemento(conjunto);
			//imprimirElemento(dic);
			
			//PRACTICA 2 EJERCICIO 10. Utilizar la funcion cambiarEstrategia (Verificar tambien porque no imprime pero funciona)
			//Coleccionable pila = new Pila();
			//llenarAlumnos(pila);
			//Estrategia estrategia = new EstrategiaPorNombre();
			//cambiarEstrategia(pila,estrategia);
			//informarAlumnos(pila);
			//Estrategia estrategia2 = new EstrategiaPorDNI();
			//cambiarEstrategia(pila,estrategia2);
			//informarAlumnos(pila);
			//Estrategia estrategia3 = new EstrategiaPorLegajo();
			//cambiarEstrategia(pila,estrategia3);
			//informarAlumnos(pila);
			//Estrategia estrategia4 = new EstrategiaPorPromedio();
			//cambiarEstrategia(pila,estrategia4);
			//informarAlumnos(pila);
			
			//PRACTICA 1 EJERCICIO 7. Creo pila y cola y le aplico los metodos informar y llenar (que reciben coleccionable ) *modificado
			//PRACTICA 1 EJERCICIO 9. Hago lo mismo con una ColeccionMultiple *modificado
			//PRACTICA 1 EJERCICIO 17. Creo una ColecciónMultiple de alumnos e informo
			//PRACTICA 3 EJERCICIO 6. Verifico el ejercicio
			//Coleccionable pila = new Pila();
            //Coleccionable cola = new Cola();            
            //Coleccionable multiple = new ColeccionMultiple((Pila) pila, (Cola) cola );
            //llenar(pila,1);
            //llenar(cola,1);           
            //informar(pila,1);
            //informar(cola,1);            
            //informar(multiple,1); 
            
            //PRACTICA 3 EJERCICIO 14. Verifico si anda todo lo del metodo Observer. (FUNCIONA)
            //Profesor profesor = new Profesor("Jeronimo",22418748,7);
            //Alumno alumno = new Alumno("Agustin",44419745,2050,9.5);
            //profesor.agregarObservador(alumno);
            //dictadoDeClases(profesor); //dictado de clase imprime 4 veces cada comportamiento
     
            //PRACTICA 4 EJERICIO 4.
            //PRACTICA 4 EJERCICIO 7 8. Armo los Students y compruebo la correcta impresion
            //Teacher maestro = new Teacher();
             //for (int i = 0; i < 2; i++)
            //{
                //if (i <= 10)
                //{
                    //IAlumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(2); //creo 10 IAlumnos Alumnos aleatoriamente
					//IAlumno decorar = new DecoratorLegajo(alumno);
                    //decorar = new DecoratorNotaEnLetras(decorar);
                    //decorar = new DecoratorNotaFinal(decorar);
                    //decorar = new DecoratorOrdenSecuencial(decorar);
                    //decorar = new DecoratorCuadro(decorar);
                    //maestro.goToClass(new AlumnoAdapter(decorar));	
			
                //}
                //if (i > 10)
                //{
                    //IAlumno alumno = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(3); //creo 10 IAlumnos AlumnosMuyEstudiosos aleatoriamente
                    //IAlumno decorar = new DecoratorLegajo(alumno);
                    //decorar = new DecoratorNotaEnLetras(decorar);
                    //decorar = new DecoratorNotaFinal(decorar);
                    //decorar = new DecoratorOrdenSecuencial(decorar);
                    //decorar = new DecoratorCuadro(decorar);	
                    //maestro.goToClass(new AlumnoAdapter(decorar));
                //}
            //}
            //maestro.teachingAClass();
            
            //PRACTICA 4 EJERCICIOS 7 OPCIONAL. Cree StudentFactory que ya crea los alumnos decorados    
            //Teacher maestro = new Teacher();
            //IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(4);
            //maestro.goToClass(new AlumnoAdapter(alumno));
            //maestro.teachingAClass();
   		
 		//PRACTICA 5 EJERCICIO 2. Compruebo el correcto funcionamiento del Proxy. (Gebera siempre el mismo nombre nose porque)
            //Teacher maestro = new Teacher();
           //7GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			
            //for (int i = 0; i < 20; i++)
            //{
                //if (i <= 10)
                //{
                	//IAlumno alumno = new AlumnoProxy(generador.stringAleatorio(10), generador.numeroAleatorio(50000000),generador.numeroAleatorio(9999),generador.numeroAleatorio(10),1); //creo un alumnoporxy
                    //IAlumno decorar = new DecoratorLegajo(alumno);
                    //decorar = new DecoratorNotaEnLetras(decorar);
                    //decorar = new DecoratorNotaFinal(decorar);
                    //decorar = new DecoratorOrdenSecuencial(decorar);
                    //decorar = new DecoratorCuadro(decorar); //lo decoro
                    //maestro.goToClass(new AlumnoAdapter(decorar)); //lo adapto a student 
                //}
                //if (i > 10)
                //{
                    //IAlumno alumno = new AlumnoProxy(generador.stringAleatorio(10), generador.numeroAleatorio(50000000),generador.numeroAleatorio(9999),generador.numeroAleatorio(10),2);
                    //IAlumno decorar = new DecoratorLegajo(alumno);
                    //decorar = new DecoratorNotaEnLetras(decorar);
                    //decorar = new DecoratorNotaFinal(decorar);
                    //decorar = new DecoratorOrdenSecuencial(decorar);
                    //decorar = new DecoratorCuadro(decorar);
                    //maestro.goToClass(new AlumnoAdapter(decorar));
                //}
            //}
            //maestro.teachingAClass();
           
            //PRACTICA 5 EJERCICIO 10. Creo funcion maín que instancie un Aula y una instancia de cada una de las tres órdenes con el aula como receptor.
            //Pila pila = new Pila();
            //Teacher teacher = new Teacher();
            //Aula aula = new Aula(teacher);
            //pila.setOrdenInicio(new OrdenInicio(aula));
            //pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            //pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
            //llenar(pila,3);
            //llenar(pila,4);
            
            //PRACTICA 5 EJERCICIO 12. Pruebo el funcionamiento. funciona todo, pero el minimo devuelve el maximo y viceversa
            Coleccionable cola = new ColaProxy();
            Console.WriteLine(cola.cuantos()); //imprime cero como deberia
            Console.WriteLine(cola.minimo()); //null correctamente
            Console.WriteLine(cola.maximo()); //null correctamente
            cola.agregar(new Numero(5));
            cola.agregar(new Numero(3));
            cola.agregar(new Numero(8));
            Console.WriteLine(cola.cuantos()); //3 correctamente
            Console.WriteLine(cola.minimo());//3 correctamente
            Console.WriteLine(cola.maximo());//8 correctamente
            Numero numero = new Numero(15);
            cola.agregar(numero); //agrego 15
            Console.WriteLine(cola.minimo());//3
            Console.WriteLine(cola.maximo());//15
            
            
            
            Console.ReadKey(true);
		}
		//PRACTICA 1 EJERCICIO 6. 
		//public static void informar(Coleccionable c) //Recibe un coleccionable (pila o cola)
		//{
			//Console.WriteLine("Contiene "+ c.cuantos() + " Elementos");
			//Console.WriteLine("Elemento minimo: " + c.minimo());
			//Console.WriteLine("Elemento maximo: " + c.maximo());
			//Console.WriteLine("Ingrese un número: ");
			//int num = int.Parse(Console.ReadLine());
			//Comparable comparable = new Numero(num);
			//if (c.contiene(comparable))
			//{
				//Console.WriteLine("El elemento leído está en la colección");
			//}
			//else 
			//{
				//Console.WriteLine("El elemento leído no está en la colección");
			//}
		//}
		//PRACTICA 3 EJERCICIO 6. Creo un informar que muetra los elementos de un coleccionable
		public static void informar(Coleccionable c, int opcion)
		{
			Console.WriteLine("cantidad de elementos: "+c.cuantos());
            Console.WriteLine("elemento minimo: "+c.minimo());
            Console.WriteLine("elemento maximo: "+c.maximo());
            Comparable comparable= FabricaDeComparables.crearPorTeclado(opcion);
            if (c.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
               Console.WriteLine("El elemento leído no está en la colección");
            }
           
        }
		
		
		//PRACTICA 1 EJERCICIO 5. Función que le agrega 20 Numeros al Comparable con la funcion Random
		//public static void llenar(Coleccionable c)
		//{
            //Random rd = new Random();

            //for (int i = 0; i < 20; i++)
            //{
                //c.agregar(new Numero(rd.Next(1, 100)));
            //}
        //}
        //PRACTICA 3 EJERCICIO 6. Creo un metodo que llene un coleciconable de
        public static void llenar(Coleccionable c, int opcion)
        {
        	Random rd = new Random(); //creo un random
        	
        	for (int i = 0; i < 20; i++) //20 veces
        	{
        		Comparable comparable = FabricaDeComparables.crearAleatorio(opcion); //creo una fabrica dependiendo la opción
        		c.agregar(comparable); //lo agrego al coleccionable el obnjeto dependiendo de que fabrica se eligio
        	}
        }
        	
        	
		//PRACTICA 1 EJERCICIO 12. Cree la función llenarPersonas que reciba un coleccionable y lo llene con 20 personas (nombre y "dni" al azar)
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
		//PRACTICA 1 EJERCICIO 14. Para que fincione, se creo tambien la función informarPersonas
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
		//PRACTICA 1 EJERCICIO 16. Creo la función llenarAlumnos que llene un coleccionable con 20 alumnos, con sus "dni", "legajo" y "promedio". 
		//public static void llenarAlumnos(Coleccionable c)
		//{
            //Random rd = new Random();

            //string[] Lista = { "Agustin", "Lucas", "Ignacio", "Tomas", "Sasha", "Mauro", "Claribel", "Coral",
            //"Bruno", "Bautista", "Marcos", "Martin", "Fabiana", "Gabriela", "Micaela", "Lionel", "Andres", "Pablo", "Magali" , "Ricardo" };

            //for (int i = 0; i < 20; i++)
            //{
            	//double promedio = Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2); // Redondea el promedio a dos decimales
            	//c.agregar(new Alumno(Lista[rd.Next(20)], rd.Next(10000000, 99999999), rd.Next(1000, 9999), promedio)); //agrega cualquiera de los 20 nombres y un "dni" ramdon entre 1 y 100
            //}
        //}


		//PRACTICA 2 EJERCICIO 2. Modifico el metodo llenarAlumno para que cada alumno tenga la estrategia elegida
		public static void llenarAlumnos(Coleccionable c)
		{
            Random rd = new Random();

            string[] Lista = { "Agustin", "Lucas", "Ignacio", "Tomas", "Sasha", "Mauro", "Claribel", "Coral",
            "Bruno", "Bautista", "Marcos", "Martin", "Fabiana", "Gabriela", "Micaela", "Lionel", "Andres", "Pablo", "Magali" , "Ricardo" };
				
            Alumno alumno = new Alumno(Lista[rd.Next(20)], rd.Next(10000000, 99999999), rd.Next(1000, 9999), Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2));
            Estrategia estrategia = new EstrategiaPorNombre(); //agregamos una estrategia de comparacion default
            Console.WriteLine("Vamos a comparar el alumno creado con los que ya estan en la lista.");
            Console.WriteLine("Elija una estrategia para comparar: ");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. DNI");
            Console.WriteLine("3. Legajo");
            Console.WriteLine("4. Pormedio");
            Console.WriteLine("Elija un número: ");
            int numero = int.Parse(Console.ReadLine()); //pedimos que elija la que quiere
            switch (numero)
            {
            	case 1:
            		Console.WriteLine("Elijio la comparación por nombre.");
            		alumno.Estrategia(estrategia);
            		break;
            	
            	case 2:
            		Console.WriteLine("Elijio la comparación por DNI.");
            		estrategia = new EstrategiaPorDNI();
            		alumno.Estrategia(estrategia);
            		break;
            		
            	case 3:
            		Console.WriteLine("Elijio la comparación por legajo.");
            		estrategia = new EstrategiaPorLegajo();
            		alumno.Estrategia(estrategia);
            		break;
            		
            	case 4:
            		Console.WriteLine("Elijio la comparación por promedio.");
            		estrategia = new EstrategiaPorPromedio();
            		alumno.Estrategia(estrategia);
            		break;

            	default:
            		Console.WriteLine("ERROR. Elijio un número incorrecto.");
            		Console.WriteLine("Se utilizara la estrategia por defecto (por el nombre).");//NO HAY QUE COMPARAR AHORA, SE LE AGREGEGA LA ESTRATEGIA A CADA OBJETO DIFERENTE Y SE GUARDA. CADA ALUMNO SE GUARDARA CON LA ESTRATEGIA QUE DESEE ELEGIR
					alumno.Estrategia(estrategia);            		
            		break;
			 }
			int contador = 0;
			while (contador < 20) //uso contador para solo agregar 20 alumnos en cada coleciconable
    		{
				alumno = new Alumno(Lista[rd.Next(20)], rd.Next(10000000, 99999999), rd.Next(1000, 9999), Math.Round(rd.NextDouble() * (10.0 - 1.0) + 1.0, 2));
        		alumno.Estrategia(estrategia);
        		if (!c.contiene(alumno)) //si no esta conetenido el alumno lo agrego
        		{
            		c.agregar(alumno);
            		contador= contador +1;
        		}
    		}
       }
  	 
		//PRACTICA 1 EJERCICIO 17. Ademas, para informar de alumnos se tuvo que crear esta función
		public static void informarAlumnos(Coleccionable c) //Recibe un coleccionable (pila o cola) y por eso puede usar c.contiene
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
			if (c.contiene(comparable)) // MEJORADO. MUESTRA TODOS SUS DATOS ASI PODES ENCONTRARLO
			{
				Console.WriteLine("El nombre leído está en la colección");
			}
			else 
			{
				Console.WriteLine("El nombre leído no está en la colección");
			}
		}
		//PRACTICA 2 EJERCICIO 7. Creo la función imprimir
		public static void imprimirElemento (Coleccionable coleccionable) //Recibe un iterable 
		{
			Iterable i=(Iterable) coleccionable;
            Iterador iterador=i.crearIterador(); //creo un iterador
			while(!iterador.fin()) //mientras no llega a fin
			{
				Console.WriteLine(iterador.actual().ToString()); //que imprima las paginas
				iterador.siguiente();
			}
		}
		//PRACTICA 2 EJERCICIO 9. Creo funcion para cambiar estrategia de todos los elem
		public static void cambiarEstrategia(Coleccionable coleccionable, Estrategia estrategia) //recibo un coleccionable (puede ser pila,cola,etc) o una estrategia
		{
			Iterable iterable=(Iterable) coleccionable; //creo un iterable con la coleccion
            Iterador iterador=iterable.crearIterador(); //creo un iterador con el iterable de la coleccion
            while (!iterador.fin()) //mientras no llegue al fin
            {
            	 Comparable elementoActual = iterador.actual(); //agarro el elemento actual
        
        		 if (elementoActual is Alumno) //verifico si es un Alumno
        		 {
            		 Alumno alumno = (Alumno)elementoActual; //si lo es, lo casteo
            		 alumno.Estrategia(estrategia); //le cambio la estrategia
            	 }
        		 iterador.siguiente();
			}  
		}
		
		public static void multipleIteradores()
		{
			Coleccionable pila = new Pila();
			llenarAlumnos(pila);
			Iterador[] iteradores = new Iterador[3];
			bool[] fin = new bool[3];
			for (int i=0; i<3;i++)
			{
				iteradores[i] = ((Iterable) pila).crearIterador();
				fin[i] = false;
			}
			Random rand = new Random();
			while (!fin[0] || !fin[1] || !fin[2])
			{
				int ite = rand.Next(3);
				if (!iteradores[ite].fin())
				{
					 Console.WriteLine(iteradores[ite].actual()); // Imprimir el elemento actual
                	iteradores[ite].siguiente(); // Avanzar al siguiente elemento	
				}
				 else
            	{
                	fin[ite] = true; // Marcar el iterador como finalizado
				}
			
			}
			
		}
		//PRACTICA 3 EJERCICIO 14. Creo la función.		
		public static void dictadoDeClases(Profesor profesor)
		{
			for (int i=0;i<4;i++)
			{
				profesor.hablarALaClase();
				profesor.escribirEnElPizarron();
			}
		}
		
		//PRACTICA 1 EJERCICIO 19. Se podria hacer lo mismo sin interfacez, pero el costo seria escribir muchisimas mas lineas de codigo.
		
		//PRACTICA 3 EJERCICIO 1. La diferencia es con el objeto con el que llenan el Coleccionable. Si aparece la nueva clase Profesor,
		// se deberia crear el metodo llenarPorfesor, que llene los Collecionables con objetos de la clase Profesor
		
		//PRACTICA 3 EJERCICIO 7. Qué debería hacer si se quiere tener en el método main la opción de almacenar los comparables en una pila, en una cola, en una colección múltiple, en un conjunto o en un diccionario
		//Creo que se deberia utilizar el metodo Factory para que dependiendo la opcion se guarde en un tipo de coleccionable. Siento que sin el patron se puede hacer pero se repetiria mucho codigo.
		
		//PRACTICA 3 EJERCICIO 10. Las fabricas son practicamente iguales, a diferencia de las variables de cada uno de los objetos.
				
		//PRACTICA 5 EJERCICIO 11. Sin el patron Factory Method se ubiera tenido que instancias muchisimos mas alumnos y repetir mucho codigo.El metodo logra que sea mucho mas facil la instanciacion de alumnos
		// y hace el codigo mas practico. Para agregar una opinión personal, es uno de los patrones que mas me gusto 
	
		//PRACTICA 5 EJERCICIO 14. Para que el proxy se de cuenta que un elemento del coleccionable cambio, yo utilizria el patron Observer, avisando al coleccionable
	
	}
}