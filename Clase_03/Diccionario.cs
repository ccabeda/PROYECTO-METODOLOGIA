using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{	
	//PRACTICA 2 EJERCICIO 4. Creo la clase Diccionario con los metodos valorDe y Agregar 
	//PRACTICA 2 EJERCICIO 5. Agrego interfaz Coleccionable 
	
	public class Diccionario : Coleccionable , Iterable
	{
		private Conjunto dic;
	
		
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
		
		
		public int cuantos()
        { 
			return dic.cuantos(); //los llamo "recursivamente" para que utilizen el metodo del conjunto 
        }
		
		public Comparable minimo()
        {
			return dic.minimo();
       	}
		
		public Comparable maximo()
        {
			return dic.maximo();
       	}
		
		 public void agregar(Comparable elemento)
		 {
		 	if (!dic.contiene(elemento))
            {
               dic.agregar(elemento);    
            }
		 	
        }
		  
		 
		public bool contiene(Comparable elemento)
		{
            ClaveValor claveValor =(ClaveValor) elemento;
            return dic.contiene(elemento);
		}
		
		 public void agregar(Comparable clave, int valor)
		 {
		 	foreach (ClaveValor i in dic.Elementos) //busco en los elementos del diccionario
    		{
        		if (i.Clave.sosIgual(clave)) //si la clave esta
        		{
            		i.Valor = valor; //actualizo el valor de i
            		return; // Sale de la función después de actualizar el valor
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
    	public Iterador crearIterador()
    	{
    		return new IteradordeDiccionario(this);
    	}
	}
}