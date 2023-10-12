using System;

namespace Trabajo_metodologia
{
//PRACTICA 6 EJERCICIO 4. 
	public class JuegoDeCartas : JuegoDeCartasGeneral
	{
		//PRACTICA 6 EJERCICIO 4. Creo un juego de cartas con JuegoDeCartasGeneral, que gana quien tenga mas cartas.
		//GANA EL QUE TENGA MAS CARTAS. SI AGARRAS 3 CARTAS, SUMAS 30 PUNTOS
		Random rd = new Random();
		protected override int tomarCartas(Persona jugador)
		{
			int puntosfinal = 0; //dentro de la funcion asi no s guarda el valor, ya que lo guardo en la clase esqueleto
			int cartas = rd.Next(1,5); //cantidad al azar simulando un dado
			int puntos = cartas *10;
			Console.WriteLine(jugador.Nombre + " tomo " + cartas + " cartas, por lo que sumo " + puntos + " puntos."); //lo que sale lo agarra
			return puntosfinal = puntosfinal + puntos;
		}
		
		protected override int descartarCartas(Persona jugador)
		{
			int cartas2 = rd.Next(1,5); //numero al zar simulando dado
			int descarte = cartas2 * 10;
			Console.WriteLine(jugador.Nombre + " decarto "+ cartas2 +" cartas , por lo que se le descartan " + descarte + " puntos."); //lo que sale lo descarta 
			return descarte;

			
		}
		
		protected override Persona chequearJugadorGanador(Persona jugador1, Persona jugador2) //verifico quien es el ganador
		{
			Console.WriteLine("El jugador: " + jugador1.Nombre + " consiguio " + puntosJugador1 + " cartas.");
			Console.WriteLine("El jugador: " + jugador2.Nombre + " consiguio " + puntosJugador2 + " cartas.");
		
			
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
