using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 2. Creo la clase Generador con las funciones que crean un numero aleatorio y una palabra aleatoria.
	public class GeneradorDeDatosAleatorios
	{
		
		public GeneradorDeDatosAleatorios() //constructor
		{
		}
		
		public int numeroAleatorio(int max)
		{
			Random rnd = new Random(); //creo objeto ramdon
            int numero = rnd.Next(0, max); //creo numero desde 0 al max
            return numero; //retorna el numero 
		}
		
 		public string stringAleatorio(int cant)
        {
 			string letras = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";
            string aleatorio = "";
            Random rnd = new Random();

            for (int i = 0; i < cant; i++)
            {
            	char caracter = letras[rnd.Next(0,letras.Length)];
                aleatorio += caracter;
            }
           
            return aleatorio;
        }

     
        
      }
            
}

