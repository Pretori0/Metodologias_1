/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 20/6/2025
 * Hora: 01:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_5
{
	/// <summary>
	/// Description of AlumnoEstudiosoProxy.
	/// </summary>
	public class AlumnoEstudiosoProxy:AlumnoProxy
	{
		public AlumnoEstudiosoProxy(string n,int d, int l, int p):base(n,d,l,p)
		{
		}
		
		
		public override int responderPregunta(int p)
		{
			if(alumnoReal==null){
			alumnoReal = new AlumnoMuyEstudioso(nombre,legajo,dni,promedio);
				
			Console.WriteLine("Creada Instancia Real ALUMNO ESTUDIOSO");
			}
			return alumnoReal.responderPregunta(p);
		}
	}
}
