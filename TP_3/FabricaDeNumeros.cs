/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 4/6/2025
 * Hora: 12:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_3
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros:FabricaDeComparables
	{
		GeneradorDeDatosAleatorios nrnd = new GeneradorDeDatosAleatorios();
		public FabricaDeNumeros()
		{
		}
		
		
		public override IComparable crearComparable(string opcion)
		{
			Numero nmr = null;
			if(opcion=="a"){
			nmr = new Numero(nrnd.numeroAleatorio(99));
			}
			
			if(opcion=="t"){
				
				Console.WriteLine("Ingrese valor del numero");
				int v=int.Parse(Console.ReadLine());
				nmr= new Numero(v);
			}
		return nmr;
		}
	}
}
