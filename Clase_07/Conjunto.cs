using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 2 EJERCICIO 3. Creo la clase conjunto con las funciones correspondientes
	//PRACTICA 2 EJERCICIO 5. Agrego la interfaz Coleccionable a la clase
	public class Conjunto : Coleccionable , Iterable
	{
		private List<Comparable> elementos;
		//PRACTICA 5 EJERCICIO 9. Implemento interfaz Ordenable. 
   		private OrdenEnAula1 ordeninicial = null; //poner null para despues las comparaciones
   		private OrdenEnAula2 ordenllegada = null;  //poner null para despues las comparaciones
   		private OrdenEnAula1 ordenaulallena = null;  //poner null para despues las comparaciones
		
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
		
	
		
		public  void agregar (Comparable elemento) //Funcion para agregar el comparable al conjunto de elementos //funcion heredada de coleccionable
		{
			if (!Esta(elemento))
			{
				if (elementos.Count == 1) //si hay solo 1 elemento
    			{
    				if ( ordeninicial != null) //si no es null
    				{
    					ordeninicial.ejecutar(); //ejecuto una ordenInicio
    				}
    			}
    			if (ordenllegada != null) //si no es null
    			{
    				ordenllegada.ejecutar((IAlumno)elemento); //luego de ordenInicio, ejecuta ordenLlegaAlumno
    			}
    			if (elementos.Count == 40) //si hay 40 elementos
    			{
    				if (ordenaulallena != null) //si no es null
    				{
    					ordenaulallena.ejecutar(); //ejecuto ordenAulaLlena
    				}
    			}
    			elementos.Add(elemento); //lo agrego	
			}
			
		}
		
		public int cuantos() //funcion heredada de coleccionable
        {
            return elementos.Count;
        }
		
		public Comparable minimo() //funcion heredada de coleccionable
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
		
		public Comparable maximo() //funcion heredada de coleccionable
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
		
		public bool contiene(Comparable comparable) //funcion heredada de coleccionable
        {
            return Esta(comparable);
        }
		
		//PRACTICA 2 EJERCICIO 6. Paso 4, creo los iteradores en las diferentes formas de guardar
		public Iterador crearIterador()
    	{
			return new IteradordeConjunto(this);
    	}
		
		//PRACTICA 5 EJERCICIO 9. Implemento las funciones para darle una tarea de aula 	
    	public void setOrdenInicio(OrdenEnAula1 orden)
    	{
    		ordeninicial = orden;
    	}
    	
    	public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
    	{
    		ordenllegada = orden;
    	}
    	
    	public void setOrdenAulaLlena(OrdenEnAula1 orden)
    	{
    		ordenaulallena = orden;
    	}

	}
}
