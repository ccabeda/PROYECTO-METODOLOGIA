using System;

namespace Trabajo_metodologia
{
//PRACTICA 4 EJERCICIO 3. Paso 1: creo la interfaz "copiando" los metodos a adaptar con la clase que nos brinda la catedra
//PRACTICA 4 EJERCICIO 6. Paso 1: creamos una interfaz común con los metodos afectados por los adicionales	
	public interface IAlumno : Comparable
	{
		int responderPregunta(int pregunta);
		void setCalificacion(int calificación);
		string mostrarCalificacion();
		string getNombre();
		int getLegajo();
		int getDNI();
		double getPromedio();
		int getCalificacion();
	}
}
