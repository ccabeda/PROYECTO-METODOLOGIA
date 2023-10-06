using System;

namespace Trabajo_metodologia
{
	//PRACTICA 4 EJERCICIO 3. Paso 2: Como queremos adaptar al Alumno a la clase que nos dieron, heredamos
	// la clase a la que queremos que se adapte 
	public class AlumnoAdapter : Student
    {
        private IAlumno alumno;

        public AlumnoAdapter(IAlumno a)
        {
            alumno=a;
        }
        
      

        public string getName()
        {
        	return alumno.getNombre();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            return alumno.sosIgual(((AlumnoAdapter)student).alumno); //se usa el .alumno para que puedas usar cualquier IAlumno 
        }

        public bool lessThan(Student student)
        {
            return alumno.sosMenor(((AlumnoAdapter)student).alumno);
        }

        public bool greaterThan(Student student)
        {
            return alumno.sosMayor(((AlumnoAdapter)student).alumno);
        }


    }
}