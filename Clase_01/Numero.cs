using System;

namespace Trabajo_metodologia
{
	// EJERCICIO 2. Creamos la clase Numero
	public class Numero: Comparable
	{
		//Aca le doy su atributo Atributo
		 private int valor; 
		
		 //Creo el constructor para que se le pueda dar valor al atributo
		 public Numero(int v)
		 {
		 	this.valor = v;
		 }
		 
		 //Getter y setter para poder interactuar desde main
		 public int Valor 
		 {
		 	get { return valor; }
		 	
		 	set { valor = value; }
		 }
		 
		 public bool sosIgual(Comparable objeto) //Compara el obejeto pasado por parametro con el valor
		 {
		 	Numero n = (Numero)objeto;
		 	return n.Valor == valor; 
		 }
		 
		 public bool sosMenor(Comparable objeto) //Devuelve True si es menor
		 {
		 	Numero n = (Numero)objeto;
		 	return n.Valor < valor;
		 }
		 
		 
		 public bool sosMayor(Comparable objeto) //Devuelve True si es mayor
		 {
		 	Numero n = (Numero)objeto;
		 	return n.Valor > valor;
		 }
		 
		  public override string ToString()
        {
		  	return valor.ToString();
        }
	}
}
