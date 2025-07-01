/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 23/6/2025
 * Hora: 21:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	/// <summary>
	/// Description of OrdenAulaLlena.
	/// </summary>
	public class OrdenAulaLlena:OrdenEnAula1
	{
		Aula aula;
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		
		public void ejecutar()
		{
			aula.claseLista();
		}
	}
}
