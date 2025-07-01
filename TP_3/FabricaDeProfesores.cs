/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 13/6/2025
 * Hora: 15:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_3
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores:FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		GeneradorDeDatosAleatorios dran = new GeneradorDeDatosAleatorios();
				
		public override IComparable crearComparable(string opcion)
		{
			Profesor prof = null;
			LectorDeDatos leer=new LectorDeDatos();
			if(opcion == "a"){
				prof=new Profesor(dran.stringAleatorio(5),dran.numeroAleatorio(40000000),dran.numeroAleatorio(30));
			return prof;
			}
			
			if(opcion=="t"){
				Console.WriteLine("Ingrese Nombre del Profesor:");
				string name=leer.stringPorTeclado();
				Console.WriteLine("Ingrese dni:");	
				int d=leer.numeroPorTeclado();
				Console.WriteLine("Ingrese antiguedad:");
				int a=leer.numeroPorTeclado();
				return new Profesor(name,d,a);
			}
			
			return prof;
		}
		
	}
}
