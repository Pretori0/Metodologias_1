/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 2/4/2025
 * Hora: 17:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MP1_TP1
{
	/// <summary>
	/// Description of IColeccionable.
	/// </summary>
	public interface IColeccionable
	{
		int cuantos();
		IComparable minimo();
		IComparable maximo();
		void agregar(IComparable comparable);
		bool contiene (IComparable comparable);
		
	}
}
