/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 15/6/2025
 * Hora: 15:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
	{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter:Student
	{
		IAlumno alumnoAdaptado;
		
		public AlumnoAdapter(IAlumno alumnoadaptado){
			this.alumnoAdaptado = alumnoadaptado;
			
		}
		
		public string getName()
		{
			return this.alumnoAdaptado.getNombre();
		}
		
		public int yourAnswerIs(int question)
		{
			return this.alumnoAdaptado.responderPregunta(3);
		}
		
		public void setScore(int score)
		{
			this.alumnoAdaptado.setCalificacion(score);
		}
		
		public string showResult()
		{
			return this.alumnoAdaptado.mostrarCalificacion();
		}
		
		public bool @equals(Student student)
		{
			return this.alumnoAdaptado.sosIgual(((AlumnoAdapter)student).Alumnoadaptado);
		}
		
		public bool lessThan(Student student)
		{
			if ((student is AlumnoAdapter)) {
			}
			return this.alumnoAdaptado.sosMenor(((AlumnoAdapter)student).Alumnoadaptado);
		}
		
		public bool greaterThan(Student student)
		{
			return this.alumnoAdaptado.sosMayor(((AlumnoAdapter)student).Alumnoadaptado);
		}
		
		public IAlumno Alumnoadaptado {
			get{return this.alumnoAdaptado;}
			
		}
		
		public string mostrarCalificacion()
		{
			return this.showResult();
		}
	}
}
