using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 1 EJERCICIO 4. Creo la clase Cola agregando (encolar, desencolar, ver si esta vacia), su constructor y su getter/settter. Luego
	//le implemento la interfaz coleccionable con sus metodos
	public class Cola : Coleccionable , Iterable
	{
 		private List<Comparable> elementos;
 		//PRACTICA 5 EJERCICIO 9. Implemento interfaz Ordenable. 
   		private OrdenEnAula1 ordeninicial = null; //poner null para despues las comparaciones
   		private OrdenEnAula2 ordenllegada = null;  //poner null para despues las comparaciones
   		private OrdenEnAula1 ordenaulallena = null;  //poner null para despues las comparaciones
 
 		
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
 		
 		public void encolar(Comparable c) //metodo basico de cola
 		{
 			elementos.Add(c);
 		}
 		
 		public Comparable desencolar() //metodo basico de cola
 		{
 			Comparable d = elementos[0];
 			elementos.RemoveAt(0);
 			
 			return d;
 		}
 		
 		public bool esVacia() //heredado de coleciconable
        {
            return elementos.Count == 0;
        }
 		
        public int cuantos() //heredado de coleciconable
        {
        	return elementos.Count;
        }

        public Comparable minimo() //heredado de coleciconable
        {
        	if (elementos.Count == 0)
            {
               	return null;
            }

        	Comparable min = elementos[0];
            foreach (var elemento in elementos)
            {
                if (elemento.sosMayor(min))
                {
                   	min = elemento;
                }
            }
        	return min;
       	}

    	public Comparable maximo() //heredado de coleciconable
    	{
        	if (elementos.Count == 0)
        	{
            	return null;
        	}

        	Comparable max = elementos[0];
        	foreach (var elemento in elementos)
        	{
            	if (elemento.sosMenor(max))
            	{
                	max = elemento;
            	}
        	}
        	return max;
    		}
		//PRACTICA 5 EJERCICIO 9. Modifico agregar para que se cumpla
    	public void agregar(Comparable comparable) //heredado de coleciconable
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

    	public bool contiene(Comparable comparable) //heredado de coleciconable
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
    		return new IteradordeCola(this);
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