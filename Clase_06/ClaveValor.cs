using System;
using System.Collections.Generic;

namespace Trabajo_metodologia
{

	public class ClaveValor : Comparable
	{
		private Comparable clave;
		private int valor;
		
		public ClaveValor(Comparable c, int v )
		{
			clave = c;
			valor = v;
		}
		
		public Comparable Clave  //Get y set
        {
            get 
            { 
            	return clave; 
            }
            set 
            { 
            	clave = value; 
            }
        }
		
		public int Valor
        {
            get 
            { 
            	return valor; 
            }
            set 
            { 
            	valor = value; 
            }
        }
		
		public bool sosIgual(Comparable c)
		{
			return clave.sosIgual(c);
		}
		
		public bool sosMayor(Comparable c)
		{
			return clave.sosMayor(c);
		}
		
		public bool sosMenor(Comparable c)
		{
			return clave.sosMenor(c);
		}
		
	}
}
