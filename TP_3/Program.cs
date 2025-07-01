/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 7/5/2025
 * Hora: 12:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Factory method{
			/*
			Pila pilanum = new Pila();
            Program.llenar(pilanum,3);
            Program.informar(pilanum,3);
            */
         
            //}Factory method
            
            //Obsever {
            
            FabricaDeProfesores fProf=new FabricaDeProfesores();
            FabricaDeAlumnos fAlum=new FabricaDeAlumnos();
            IComparable profesor = fProf.crearComparable("a");
            for(int i=0;i<20;i++){
            	IComparable alum=fAlum.crearComparable("a");
            	((Profesor)profesor).agregarObservador((IObservador)alum);
            }
            ((Profesor)profesor).dictadoDeClases();
            
			//}Observer
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void llenar(IColeccionable coleccionable, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
            	IComparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                coleccionable.agregar(comparable);
            }
        }
		
		public static void informar(IColeccionable coleccionable, int opcion)
        {
			
			Console.WriteLine(coleccionable.cuantos());
			Console.WriteLine(((IComparable)coleccionable.minimo()).ToString());
			Console.WriteLine(((IComparable)coleccionable.maximo()).ToString());
            						
            IComparable comparableAux = FabricaDeComparables.crearPorTeclado(opcion);
            
            if (coleccionable.contiene(comparableAux))
            {
                Console.WriteLine("El elemento esta en la coleccion");
            }
            else
            {
                Console.WriteLine("el elemento no esta en la coleccion");
            }
        }
	}
}