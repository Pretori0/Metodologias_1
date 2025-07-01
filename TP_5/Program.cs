/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 7/5/2025
 * Hora: 12:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
						
			
			Teacher teacher = new Teacher();
			GeneradorDeDatosAleatorios gda=new GeneradorDeDatosAleatorios();
            
            for(int i=0;i<10;i++){
				
				IAlumno alu=new AlumnoProxy(gda.stringAleatorio(7),gda.numeroAleatorio(49999999),gda.numeroAleatorio(99999),gda.numeroAleatorio(8));
				AlumnoAdapter aAdaptado=new AlumnoAdapter(alu);
            	teacher.goToClass(aAdaptado);
            	IAlumno muyE=new AlumnoEstudiosoProxy(gda.stringAleatorio(7),gda.numeroAleatorio(49999999),gda.numeroAleatorio(99999),gda.numeroAleatorio(8));
            	AlumnoAdapter aMuyE=new AlumnoAdapter(muyE);
            	teacher.goToClass(aMuyE);
            }
			
            teacher.teachingAClass();
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
            
			
		}
		
     }
 }
