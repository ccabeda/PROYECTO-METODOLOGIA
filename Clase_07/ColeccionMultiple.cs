using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{
	//PRACTICA 1 EJERCICIO 8. creo una clase que de aributo recibe dos coleccionables.
	public class ColeccionMultiple : Coleccionable 
	{
		private Coleccionable pila;

        private Coleccionable cola;

        // Constructor
        public ColeccionMultiple(Pila p, Cola c) 
        {
            pila = p;

            cola = c;
        }
        
         public int cuantos() //la suma de todos los elementos de la pila y cola (40)
        {
         	return pila.cuantos() + cola.cuantos();
        }

        public Comparable minimo() 
        {
        	if ( pila.minimo().sosMenor(cola.minimo()))
        	{
        		return pila.minimo();
        	}
          	
        	return cola.minimo();
        	
       	}

    	public Comparable maximo()
    	{
    		if ( pila.maximo().sosMayor(cola.maximo())) //NO ME PERMITE USAR > < ESOS COMPARADORES PORQUE LOS OBJETOS A LOS QUE HACE REFERENCIA PILA O COLA SON COMPARABLES Y SE USA SOSMAYOR()
        	{
        		return pila.maximo();
        	}
          	
        	return cola.maximo();
    		}

    		public void agregar(Comparable comparable)
    		{
        		//NADA
    		}

    		public bool contiene(Comparable comparable)
    		{
        		 return pila.contiene(comparable) || cola.contiene(comparable);
    		}
    }
}
