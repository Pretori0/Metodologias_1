/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 23/6/2025
 * Hora: 21:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	/// <summary>
	/// Description of Ordenable.
	/// </summary>
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 ordenInicio);
		void setOrdenLlegaAlumno(OrdenEnAula2 llegaAlu);
		void setOrdenAulaLlena(OrdenEnAula1 aulaLlena);
	}
}
