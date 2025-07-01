/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 2/4/2025
 * Hora: 16:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MP1_TP1
{
	/// <summary>
	/// Description of IComparable.
	/// </summary>
	public interface IComparable
	{
		bool sosIgual(IComparable comparable);
		bool sosMenor(IComparable comparable);
		bool sosMayor(IComparable comparable);
	}
}
