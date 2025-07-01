/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 30/4/2025
 * Hora: 21:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MP1_TP2
{
	/// <summary>
	/// Description of IteraColeccion.
	/// </summary>
	public class IteraColeccion : Iterador
	{
		int elementoActual;
		List <IComparable> comparables;
		
		public IteraColeccion(List<IComparable> elementos)
		{
			this.comparables = elementos;
			primero();
		}
		
		public void primero()
		{
			elementoActual = 0;
		}
		
		public void siguiente()
		{
			elementoActual++;
		}
		
		public bool fin()
		{
			return elementoActual>= comparables.Count;
		}
		
		public IComparable actual()
		{
			return comparables[elementoActual];
		}
	}
}
