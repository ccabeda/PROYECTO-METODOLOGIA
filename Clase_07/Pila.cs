using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//EJERCICIO 4. Creo la clase Pila agregando (apilar, desapilar, ver si esta vacia), su constructor y su getter/settter. Luego
	//le implemento la interfaz coleccionable con sus metodos	
	public class Pila : Coleccionable , Iterable
	{
   		private List<Comparable> elementos;
   		//PRACTICA 5 EJERCICIO 9. Implemento interfaz Ordenable. 
   		private OrdenEnAula1 ordeninicial = null; //poner null para despues las comparaciones
   		private OrdenEnAula2 ordenllegada = null;  //poner null para despues las comparaciones
   		private OrdenEnAula1 ordenaulallena = null;  //poner null para despues las comparaciones
   				
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
   		
   		public void apilar(Comparable c) //metodo basico de pila
 		{
 			elementos.Add(c);
 		}
 		
 		public Comparable desapilar()//metodo basico de pila
 		{
 			if (esVacia())
 			{
 				return null;
 			}
 			Comparable c = elementos[elementos.Count - 1];

            elementos.RemoveAt(elementos.Count - 1);
            
            return c;
 		  }
 		
 		public bool esVacia() //heredado de coleciconable
        {
            return elementos.Count == 0;
        }

    	public int cuantos()//heredado de coleciconable
        {
        	return elementos.Count;
        }

        public Comparable minimo() //busca el elemento minimo de la pila utilizando sosMenor() de comparable //heredado de coleciconable
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

    	public Comparable maximo() //busca el elemento maximo de la pila utilizando sosMayor() de comparable //heredado de coleciconable
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
		//PRACTICA 5 EJERCICIO 9. Modifico agregar para que se cumpla
    	public void agregar(Comparable comparable) 
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
    			ordenllegada.ejecutar((IAlumno)comparable); //luego de ordenInicio, ejecuta ordenLlegaAlumno
    		}
    		if (elementos.Count == 40) //si hay 40 elementos
    		{
    			if (ordenaulallena != null) //si no es null
    			{
    				ordenaulallena.ejecutar(); //ejecuto ordenAulaLlena
    			}
    		}
    		elementos.Add(comparable); //lo agrego		
    	}

    	public bool contiene(Comparable comparable) //busca el elemento contenido de la pila utilizando sosIgual() de comparable //heredado de coleciconable
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
    	public Iterador crearIterador() //heredado de iterable
    		{
    			return new IteradordePila(this);
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

