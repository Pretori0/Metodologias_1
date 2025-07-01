/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 23/6/2025
 * Hora: 20:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio:OrdenEnAula1
	{
		Aula aula;
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}
		
		public void ejecutar()
		{
			aula.comenzar();
		}
	}
}
