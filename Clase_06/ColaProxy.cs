using System;

namespace Trabajo_metodologia
{
//PRACTICA 5 EJERCICIO 12. Creo un proxy para el colecionable cola
	public class ColaProxy : Coleccionable
	{
		private Coleccionable Colareal;
        private Comparable min;
        private Comparable max;
        private int cuant;
        private bool cont;
		
        public ColaProxy() //constructor inicio todo 
		{
			Colareal = null;
			min = null;
			max = null;
			cuant = 0;
			cont = false;
		}
        
        public void agregar(Comparable comparable) //agregar
        {
            if (Colareal == null) //si no existe la pila
            { 
                Colareal = new Cola(); //Unicamente la crea
                
            }
            Colareal.agregar(comparable); //llama al metodo agregar de pila
        }
        
        public int cuantos() //cuantos
        {
        	if (Colareal != null) //si la pila existe
        	{
        		max = Colareal.maximo(); //lo pongo aca para que se actualize (preguntado a alumno que ya curso, no entendi muy bien)
                min = Colareal.minimo();
                cuant = Colareal.cuantos(); //hago el metodos cuantos de pila
        	}
        	return cuant; 
        }
        
        public bool contiene(Comparable comparable) //contiene
        {
        	if (Colareal != null) //si la pila existe
        	{
        		cont = Colareal.contiene(comparable); //llamo al metodo contiene de pila
        	}
        	return cont;
        }
        
        
        public Comparable minimo() //minimo
        {
        	if ( Colareal != null) //si la cola existe
            {
        		if (cuant != Colareal.cuantos()) //si se utilizo el metodo cuantos
        		{
                	min = Colareal.minimo();
        		}
            }
            return min;
        }
        
        public Comparable maximo()
        {
        	if ( Colareal != null)
            {
        		if (cuant != Colareal.cuantos())
        		{
        			max = Colareal.maximo();
        		}
            }
            return max;
        }
        
        
        
        
        
        
        
	}
}
