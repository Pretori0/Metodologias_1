/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 23/6/2025
 * Hora: 21:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno:OrdenEnAula2
	{
		Aula aula;
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}
		
		public void ejecutar(IComparable comparable)
		{
			aula.nuevoAlumno((IAlumno)comparable);
		}
		
	}
}
