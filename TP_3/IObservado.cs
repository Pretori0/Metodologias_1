/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 13/6/2025
 * Hora: 16:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_3
{
	/// <summary>
	/// Description of IObservado.
	/// </summary>
	public interface IObservado
	{
		void agregarObservador(IObservador o);
		void quitarObservador(IObservador o);
		void notificar(int opcion);
		
	}
}
