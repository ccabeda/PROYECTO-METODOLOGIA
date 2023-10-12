using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{	
	//PRACTICA 2 EJERCICIO 4. Creo la clase Diccionario con los metodos valorDe y Agregar 
	//PRACTICA 2 EJERCICIO 5. Agrego interfaz Coleccionable 
	
	public class Diccionario : Coleccionable , Iterable
	{
		private Conjunto dic;
		//PRACTICA 5 EJERCICIO 9. Implemento interfaz Ordenable. 
   		private OrdenEnAula1 ordeninicial = null; //poner null para despues las comparaciones
   		private OrdenEnAula2 ordenllegada = null;  //poner null para despues las comparaciones
   		private OrdenEnAula1 ordenaulallena = null;  //poner null para después las comparaciones
	
		
		public Diccionario() //Constructor
		{
			
			dic = new Conjunto();
		}
		
		
		public Conjunto Dic //getter y setter
        {
            get 
        	{ 
            	return dic; 
            }
            set 
            { 
            	dic = value; 
            }
	    }
		
		
		public int cuantos() //funcion heredada de coleccionable 
        { 
			return dic.cuantos(); //los llamo "recursivamente" para que utilizen el metodo del conjunto 
        }
		
		public Comparable minimo()//funcion heredada de coleccionable
        {
			return dic.minimo();
       	}
		
		public Comparable maximo()//funcion heredada de coleccionable
        {
			return dic.maximo();
       	}
		
		 public void agregar(Comparable elemento)//funcion heredada de coleccionable
		 {
		 	if (!dic.contiene(elemento))
            {
               dic.agregar(elemento);    
            }
		 	
        }
		  
		 
		public bool contiene(Comparable elemento)//funcion heredada de coleccionable
		{
            ClaveValor claveValor =(ClaveValor) elemento;
            return dic.contiene(elemento);
		}
		
		 public void agregar(Comparable clave, int valor)//funcion heredada de coleccionable
		 {
		 	foreach (ClaveValor i in dic.Elementos) //busco en los elementos del diccionario
    		{
        		if (i.Clave.sosIgual(clave)) //si la clave esta
        		{
            		i.Valor = valor; //actualizo el valor de i
            		return; // Sale de la función después de actualizar el valor
        		}
    		}
		 	if (dic.cuantos() == 1) //si hay solo 1 elemento
    			{
    				if ( ordeninicial != null) //si no es null
    				{
    					ordeninicial.ejecutar(); //ejecuto una ordenInicio
    				}
    			}
    			if (ordenllegada != null) //si no es null
    			{
    				ordenllegada.ejecutar((IAlumno)clave); //luego de ordenInicio, ejecuta ordenLlegaAlumno
    			}
    			if (dic.cuantos() == 40) //si hay 40 elementos
    			{
    				if (ordenaulallena != null) //si no es null
    				{
    					ordenaulallena.ejecutar(); //ejecuto ordenAulaLlena
    				}
    			}			 	
    		ClaveValor nuevaClaveValor = new ClaveValor(clave, valor); // Si la clave no existe, agrega la nueva clave-valor al diccionario
    		dic.agregar(nuevaClaveValor);
		 }
		 	
		 
		 
		 public Comparable valorDe(Comparable clave) //Recibo la clave
		 {
            Comparable valor = null; //Creo null
            foreach (ClaveValor i in dic.Elementos) //busco en los elementos del diccionario
            {
                if (i.sosIgual(clave)) //si alguna tiene la clave igual a la recibida
                {
                    valor = i; //guardo el valor
                    return valor; //retorno el valo
                }
            }
            return valor; //si no esta, retorno null
         }
		 
		 //PRACTICA 2 EJERCICIO 6. Paso 4, creo los iteradores en las diferentes formas de guardar
    	public Iterador crearIterador() //funcion heredada de iterable 
    	{
    		return new IteradordeDiccionario(this);
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