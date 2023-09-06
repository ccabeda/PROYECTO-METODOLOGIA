using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//EJERCICIO 4. Creo la clase Pila agregando (apilar, desapilar, ver si esta vacia), su constructor y su getter/settter. Luego
	//le implemento la interfaz coleccionable con sus metodos	
	public class Pila : Coleccionable
	{
   		private List<Comparable> elementos;
   				
   		public Pila()
 		{
   			elementos = new List<Comparable>();
 		}
   		
   		public List<Comparable> Elementos //Get y set
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
   		
   		public void apilar(Comparable c) 
 		{
 			elementos.Add(c);
 		}
 		
 		public Comparable desapilar()
 		{
 			if (esVacia())
 			{
 				return null;
 			}
 			Comparable c = elementos[elementos.Count - 1];

            elementos.RemoveAt(elementos.Count - 1);
            
            return c;
 		  }
 		
 		public bool esVacia()
        {
            return elementos.Count == 0;
        }

    	public int cuantos()
        {
        	return elementos.Count;
        }

        public Comparable minimo() //busca el elemento minimo de la pila utilizando sosMenor() de comparable
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

    	public Comparable maximo() //busca el elemento maximo de la pila utilizando sosMayor() de comparable
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

    	public void agregar(Comparable comparable)
    	{
        	elementos.Add(comparable);
    	}

    	public bool contiene(Comparable comparable) //busca el elemento contenido de la pila utilizando sosIgual() de comparable
    	{
        	foreach (Comparable c in elementos)
            {
                if (c.sosIgual(comparable))
                {
                    return true;
                }
           }
           return false;
    	}
	}	
	  
}

