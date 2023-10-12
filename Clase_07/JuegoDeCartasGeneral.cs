using System;

namespace Trabajo_metodologia
{
//PRACTICA 6 EJERCICIO 3. Creo el esqueleto de los juegos de cartas
//PRACTICA 6 EJERCICIO 6. Modifico el juego para que sea el que llegue primero a 50 puntos gane. 
	public abstract class JuegoDeCartasGeneral
	{
		
		protected Persona ganador;
		protected int puntosJugador1 = 0;
		protected int puntosJugador2 = 0;

		
		protected abstract int tomarCartas(Persona jugador);
		protected abstract int descartarCartas(Persona jugador);
		protected abstract Persona chequearJugadorGanador(Persona jugador1, Persona jugador2);
		
		
		protected void mezclarElMazo()
		{
			Console.WriteLine("Mezclando el mazo....");
			Console.WriteLine("Mazo mezclado.");
		}
		
		protected void repartirCartas()
		{
			Console.WriteLine("Repartiendo cartas...");
			Console.WriteLine("Cartas repartidas.");
		}
		
		
		public	Persona Partida(Persona jugador1, Persona jugador2) //La partida. El juego no tiene una logica en si, se elige el ganador aleatoriamente
		{
			Random rd = new Random();
			ganador = null;
			bool fin = true;
			int contador = 1;
			this.mezclarElMazo(); //mezclamos
           	this.repartirCartas();
			while (fin)
			{
            	puntosJugador1 = puntosJugador1 + this.tomarCartas(jugador1); //voy sumando los puntos acumuladamente
                puntosJugador1 = puntosJugador1 - this.descartarCartas(jugador1); //los voy restando
                puntosJugador2 = puntosJugador2 + this.tomarCartas(jugador2);
                puntosJugador2 = puntosJugador2 - this.descartarCartas(jugador2);
                Console.WriteLine("Termino la ronda n°" + contador +".");
                Console.WriteLine("El jugador: " + jugador1.Nombre + " consiguio " + puntosJugador1 + " puntos.");
				Console.WriteLine("El jugador: " + jugador2.Nombre + " consiguio " + puntosJugador2 + " puntos.");
            	
                
                if (puntosJugador1 > 50 || puntosJugador2 > 50)
                {               
            		Console.WriteLine("Juego terminado.");
            		this.chequearJugadorGanador(jugador1,jugador2); //verifico quien es el ganador
            		fin = false;
                }
                contador++;
			}
			return ganador;
		}
		
		
	}
}
