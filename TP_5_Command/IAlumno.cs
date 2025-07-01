/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 19/6/2025
 * Hora: 22:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno
	{
		int responderPregunta(int p);
		string getNombre();
		void setCalificacion(int c);
		bool sosIgual(IAlumno comparable);
		bool sosMenor(IAlumno comparable);
		bool sosMayor(IAlumno comparable);
		string mostrarCalificacion();
		int getLegajo();
		int getDni();
		int getPromedio();
		
		
	}
}
		
	

