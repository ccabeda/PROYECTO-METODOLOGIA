using System;

namespace Trabajo_metodologia
{
//PRACTICA 6 EJERCICIO 2. Fabrica de alumnocompuesto aunque siempre inicia vacia.
	public class FabricaDeAlumnosCompuestos : FabricaDeComparables
	{
		public FabricaDeAlumnosCompuestos()
		{
		}
		
		
		public override Comparable crearAleatorio()
		{
			AlumnoCompuesto alumno = new AlumnoCompuesto();
			return alumno;
		}
		
		public override Comparable crearPorTeclado()
		{
			AlumnoCompuesto alumno =  new AlumnoCompuesto();
			return alumno;
		}
		
		public override Comparable crearDesdeArchivo()
		{
			AlumnoCompuesto alumno = new AlumnoCompuesto();
			return alumno;
		}
	}
}
