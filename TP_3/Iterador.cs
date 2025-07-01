/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 30/4/2025
 * Hora: 15:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_3
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador
	{
			void primero();
			void siguiente();
			bool fin();
			IComparable actual();
					
	}
}
