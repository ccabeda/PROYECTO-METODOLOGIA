using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 1 EJERCICIO 4. Creo la clase Cola agregando (encolar, desencolar, ver si esta vacia), su constructor y su getter/settter. Luego
	//le implemento la interfaz coleccionable con sus metodos
	public class Cola : Coleccionable , Iterable
	{
 		private List<Comparable> elementos;
 		
 		public Cola()
 		{
 			elementos = new List<Comparable>();
 		}
 		
 		public List<Comparable> Elementos
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
 		
 		public void encolar(Comparable c)
 		{
 			elementos.Add(c);
 		}
 		
 		public Comparable desencolar()
 		{
 			Comparable d = elementos[0];
 			elementos.RemoveAt(0);
 			
 			return d;
 		}
 		
 		public bool esVacia()
        {
            return elementos.Count == 0;
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

    		public void agregar(Comparable comparable)
    		{
        		elementos.Add(comparable);
    		}

    		public bool contiene(Comparable comparable)
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
    		//PRACTICA 2 EJERCICIO 6. Paso 4, creo los iteradores en las diferentes formas de guardar
    		public Iterador crearIterador()
    		{
    			return new IteradordeCola(this);
    		}
	}
}