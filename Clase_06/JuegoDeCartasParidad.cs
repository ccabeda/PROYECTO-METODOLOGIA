using System;

namespace Trabajo_metodologia
{
	public class JuegoDeCartasParidad : JuegoDeCartasGeneral
	{
		//PRACTICA 6 EJERCICIO 4. Creo un juego de cartas con JuegoDeCartasGeneral, que gana quien tenga mas cartas.
		//GANA EL QUE ADIVINA MAS VECES
		Random rd = new Random();
				
		protected override int tomarCartas(Persona jugador)
		{
			int puntosfinal = 0;
			int carta = rd.Next(1,20); 
			Console.WriteLine(jugador.Nombre + " tomo una carta");
			Console.WriteLine("1. Par");
			Console.WriteLine("2. Impar");
			Console.WriteLine("");
			Console.WriteLine( jugador.Nombre + " tiene que adivinar si es par o impar: ");
			int respuesta = int.Parse(Console.ReadLine());
			if (respuesta == 1)
			{
				if (carta % 2 ==0)
				{
					Console.WriteLine("Correcto. Adivino! Suma 15 puntos.");
					return puntosfinal = puntosfinal + 15;
				}
				else
				{
					Console.WriteLine("Incorrecto. No suma nada");
					return puntosfinal;
				}
			}
			else if (respuesta == 2)
			{
				if (carta % 2 ==0)
				{
					Console.WriteLine("Incorrecto. No suma nada");
					return puntosfinal;
				}
				else
				{
					Console.WriteLine("Correcto. Adivino! Suma 15 puntos.");
					return puntosfinal = puntosfinal + 15;
				}
			}
			else
			{
				Console.WriteLine("¡APRENDA A LEER! Por equivocarse no suma nada.");
				return puntosfinal;
			}
		}
		
		protected override int descartarCartas(Persona jugador)
		{			
			Console.WriteLine(jugador.Nombre + " decarto la carta que habia agarrado");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			return 0; //como en este juego no se pierde puntos, que retorne 0 asi se le descuenta 0 puntos
		}
		
		protected override Persona chequearJugadorGanador(Persona jugador1, Persona jugador2) //verifico quien es el ganador
		{		
			 if (puntosJugador1 > puntosJugador2)
    		{
        		Console.WriteLine("Ganador de la partida: " + jugador1.Nombre);
        		this.ganador = jugador1;
    		}
    		else if (puntosJugador2 > puntosJugador1)
    		{
        		Console.WriteLine("Ganador de la partida: " + jugador2.Nombre);
        		this.ganador = jugador2;
    		}
    		else
    		{
        		Console.WriteLine("La partida terminó en empate.");
        		this.ganador = null;
    		}
    		return ganador;
		}
		
	}
}
