/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 23/6/2025
 * Hora: 20:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		Teacher teacher;
		public Aula()
		{
		}
		
		public void comenzar(){
			Console.WriteLine("Comenzando");
			teacher = new Teacher();
		}
		
		public void nuevoAlumno(IAlumno alumno){
			AlumnoAdapter stud = new AlumnoAdapter(alumno);
			teacher.goToClass(stud);
		}
		
		public void claseLista(){
			teacher.teachingAClass();
		}
		
	}
}
