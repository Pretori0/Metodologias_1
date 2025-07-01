/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 7/5/2025
 * Hora: 12:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pila pila = new Pila();
			Aula aula=new Aula();
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			Program.llenar(pila,1); //fabrica alumnos
			Program.llenar(pila,11); //fabrica muy estud
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
		
		public static void llenar(IColeccionable coleccionable, int opcion)
        {
			FabricaDeAlumnos fabrica = new FabricaDeAlumnos();
            for (int i = 0; i < 20; i++)
            {
            	
             	IComparable comparable = fabrica.crearComparable("a");
             	//AlumnoAdapter alumAdap = new AlumnoAdapter(comparable);
             	coleccionable.agregar(comparable);
            }
        }
		
     }
 }
