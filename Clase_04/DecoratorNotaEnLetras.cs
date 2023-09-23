using System;

namespace Trabajo_metodologia
{
//PRACTICA 4 EJERCICIO 6. Paso 4: Creo los decoradores que hereden la clase abstracta y override a los metodos que quieren modificar
	public class DecoratorNotaEnLetras : AdicionalDecorator
	{
		public DecoratorNotaEnLetras(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			int calificacion = alumno.getCalificacion();
			string numero = "";
			switch(calificacion)
			{
					 case 1:
                    numero="(UNO)";
                    break;
                case 2:
                    numero="(DOS)";
                    break;
                case 3:
                    numero="(TRES)";
                    break;
                case 4:
                    numero="(CUATRO)";
                    break;
                case 5:
                    numero="(CINCO)";
                    break;
                case 6:
                    numero="(SEIS)";
                    break;
                case 7:
                    numero="(SIETE)";
                    break;
                case 8:
                    numero="(OCHO)";
                    break;
                case 9:
                    numero="(NUEVE)";
                    break;
                case 10:
                    numero="(DIEZ)";
                    break;
			}
			
			return alumno.mostrarCalificacion() + " " + numero;
				
		}
	}
}
