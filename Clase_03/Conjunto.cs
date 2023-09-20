using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 3. Creo la clase conjunto con las funciones correspondientes
	//PRACTICA 2 EJERCICIO 5. Agrego la interfaz Coleccionable a la clase
	public class Conjunto : Coleccionable , Iterable
	{
		private List<Comparable> elementos; 
		
		public Conjunto() //Constructor
		{
			elementos = new List<Comparable>();
		}
		
		public List<Comparable> Elementos //getter y setter
        {
            get 
           	{ 
            	return elementos; 
            }
            set 
            { 
            	elementos = value; 
            }
        }
		
		public bool Esta(Comparable elemento) //Funcion agregada para ver si el elemento esta en el conjunto
        {
			 if (elemento == null) //verifico si hay algo dentro del conjunto
    		 {
        		 throw new ArgumentNullException("El elemento no puede ser nulo.");
    	     }
			
            foreach (Comparable e in Elementos) //si hay, busco 1 por 1 para ver si esta o no con la funcion SosIgual de la interfaz comparable
            {
                if (e.sosIgual(elemento))
                {
                    return true;
                }
            }

            return false;
        }
		
	
		
		public  void agregar (Comparable elemento) //Funcion para agregar el comparable al conjunto de elementos
		{
			if (!Esta(elemento))
			{
				elementos.Add(elemento);
			}
			
		}
		
		public int cuantos()
        {
            return elementos.Count;
        }
		
		public Comparable minimo()
        {
        	if (elementos.Count == 0)
            {
               	return null;
            }

        	Comparable min = elementos[0];
            foreach (var elemento in elementos)
            {
                if (elemento.sosMenor(min))
                {
                   	min = elemento;
                }
            }
        	return min;
       	}
		
		public Comparable maximo()
    	{
        	if (elementos.Count == 0)
        	{
            	return null;
        	}

        	Comparable max = elementos[0];
        	foreach (var elemento in elementos)
        	{
            	if (elemento.sosMayor(max))
            	{
                	max = elemento;
            	}
        	}
        	return max;
    	}
		
		public bool contiene(Comparable comparable)
        {
            return Esta(comparable);
        }
		//PRACTICA 2 EJERCICIO 6. Paso 4, creo los iteradores en las diferentes formas de guardar
		public Iterador crearIterador()
    		{
			return new IteradordeConjunto(this);
    		}

	}
}
