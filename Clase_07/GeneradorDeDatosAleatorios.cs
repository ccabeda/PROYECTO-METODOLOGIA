using System;

namespace Trabajo_metodologia
{
//PRACTICA 3 EJERCICIO 2. Creo la clase Generador con las funciones que crean un numero aleatorio y una palabra aleatoria.
public class GeneradorDeDatosAleatorios : Manejador //PRACTICA 7 EJERCICIO 1. Paso 2: Heredo manejador y uso los metodos que sabe hacer cada sucesor
	{
		//PRACTICA 7 EJERCICIO 4. Utilizo Singleton, poniendo privado el constructor y creando getInstance
		private static GeneradorDeDatosAleatorios unicoGenerador = null;
		
		private GeneradorDeDatosAleatorios(Manejador manejador) : base(manejador)//constructor
		{
		}
	
		public override int numeroAleatorio(int max)
		{
			Random rnd = new Random(); //creo objeto ramdon
            int numero = rnd.Next(0, max); //creo numero desde 0 al max
            return numero; //retorna el numero 
		}
		
 		public override string stringAleatorio(int cant)
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
 		
 		public static GeneradorDeDatosAleatorios getInstance()
 		{
 			if(unicoGenerador == null)
				unicoGenerador = new GeneradorDeDatosAleatorios(null);
 			return unicoGenerador;
		}

     
        
      }
            
}

