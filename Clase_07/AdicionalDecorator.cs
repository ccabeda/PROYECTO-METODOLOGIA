using System;

namespace Trabajo_metodologia
{
//PRACTICA 4 EJERCICIO 6. Paso 3: creo clase abstracta que herede la interfaz, pero que los metodosredirigan hacia el
// objeto de la interfaz
	public abstract class AdicionalDecorator : IAlumno
	{	
		protected IAlumno alumno; //protected ara poder accecer de los decoradores 
		
		public AdicionalDecorator(IAlumno a)
		{
			alumno = a;
		}
		
		 public virtual string getNombre()
		{
			return alumno.getNombre();
		}
		 
		 public virtual int getLegajo()
		{
			return alumno.getLegajo();
		}
		 
		 public virtual int getDNI()
		{
			return alumno.getDNI();
		}
		 
		 public virtual double getPromedio()
		{
			return alumno.getPromedio();
		}
		 
		  public virtual int getCalificacion()
		{
			return alumno.getCalificacion();
		}
		
		 public virtual int responderPregunta(int pregunta)
		{
			return alumno.responderPregunta(pregunta);
		}
		
		public virtual void setCalificacion(int calificacion)
		{
			alumno.setCalificacion(calificacion);
		}
		
		public virtual string mostrarCalificacion()
		{
			return alumno.mostrarCalificacion();
		}
		
		public  virtual bool sosIgual(Comparable objeto)
		{
			
			return this.alumno.sosIgual(objeto);
		}
		
		public virtual bool sosMenor(Comparable objeto)
		{
			
			return this.alumno.sosMenor(objeto);
		}
		
		
		public virtual bool sosMayor(Comparable objeto)
		{
			
			return this.alumno.sosMayor(objeto);
		}		
	}
}
