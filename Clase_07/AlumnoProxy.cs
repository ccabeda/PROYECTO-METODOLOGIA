using System;

namespace Trabajo_metodologia
{
//PRACTICA 5 EJERCICIO 1. con la interfaz ya creada con los metodos "costosos" llamada IAlumnos y la clase que la hereda Alumno
// Creamos el proxy que herede la interface, donde solamente hara los metodos simples, y los costosos los manda al objeto
	public class AlumnoProxy : IAlumno
	{
		private IAlumno alumnoReal = null;
		private string nombre;
        private int dni;
        private int legajo;
        private double promedio;
		private int calificacion;
		private int opcion;
		private Estrategia estrategia;
		
		public AlumnoProxy(string  n, int d, int l, double p, int o)
		{
			nombre = n;
			dni = d;
			legajo = l;
			promedio = p;
			opcion = o;
			estrategia = new EstrategiaPorNombre();
		}
		
		public string getNombre()
		{
			return nombre;
		}
		
			public int getDNI()
		{
            return dni;
        }
		
		 public int getLegajo()
		{
            return legajo;
        }
        
		 public double getPromedio()
		{
            return promedio;
        }
		 
		public int getCalificacion()
		{
            return calificacion;
        }
		
		public void setCalificacion(int calif)
		{
			 calificacion = calif;
		}
		
		public bool sosIgual (Comparable objeto)
		{
			return estrategia.sosIgual(this,objeto);
		}
		
		public bool sosMayor (Comparable objeto)
		{
			return estrategia.sosMayor(this,objeto);
		}
		
		public bool sosMenor (Comparable objeto)
		{
			return estrategia.sosMenor(this,objeto);
		}
		
		public string mostrarCalificacion()
		{
			return getCalificacion().ToString();
		}
		
		public int responderPregunta(int pregunta)
		{
			 if (alumnoReal == null)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Instanciando a un Alumno... ");
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(2);
                }

                if (opcion == 2)
                {
                    Console.WriteLine("Instanciando a un Alumno muy estudioso... ");
                    alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(3);
                }
             }
			 return alumnoReal.responderPregunta(pregunta);
		}
	}
}
