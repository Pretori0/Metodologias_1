/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 2/4/2025
 * Hora: 16:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MP1_TP2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ej7
			/*
            Pila pilanum = new Pila();
            Cola colanum = new Cola();
		    Program.llenar(pilanum);
            Program.llenar(colanum);
            Program.informar(pilanum);
            Program.informar(colanum);*/
			
			/*
			//ej9
			Pila pilanum = new Pila();
            Cola colanum = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pilanum,colanum);
		    Program.llenar(pilanum);
            Program.llenar(colanum);
            Program.informar(pilanum);
            Program.informar(colanum);
            Program.informar(multiple);
            */

			//Ej 14
		/*	Pila pilanum = new Pila();
            Cola colanum = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pilanum,colanum);
		    Program.llenaAlumnos(pilanum);
            Program.llenaAlumnos(colanum);
            Program.informar(multiple);
		*/

			//TP_2
			//ej7
			/*
			Pila pilAlum = new Pila();
            Cola colAlum = new Cola();
            Conjunto alumnos = new Conjunto();
		    Program.llenaAlumnos(pilAlum);
            Program.llenaAlumnos(colAlum);
            Program.llenaAlumnos(alumnos);
            Program.imprimirElementos(pilAlum);
            Program.imprimirElementos(colAlum);
			Program.imprimirElementos(alumnos);
			
			StrategyAlumno comparar2 = new PorPromedio();
			
			Program.cambiarEstrategia(pilAlum,comparar2);
			*/
			
			Pila pilAlum = new Pila();
			llenaAlumnos(pilAlum);
			Program.cambiarEstrategia(pilAlum, 0);
			informar(pilAlum);
			Program.cambiarEstrategia(pilAlum, 1);
			informar(pilAlum);
			Program.cambiarEstrategia(pilAlum, 2);
			informar(pilAlum);
			Program.cambiarEstrategia(pilAlum, 3);
			informar(pilAlum);
						
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void llenar(IColeccionable coleccionable)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Numero comparable = new Numero(rnd.Next(10,50));
                coleccionable.agregar(comparable);
            }
        }
		
		public static void informar(IColeccionable coleccionable)
        {
			Console.WriteLine(coleccionable.cuantos());
			Console.WriteLine(((Alumno)coleccionable.minimo()).getDni);
			Console.WriteLine(((Alumno)coleccionable.maximo()).getDni);
            Console.WriteLine("Ingrese numero Legajo");
            
            int ver = Convert.ToInt32(Console.ReadLine());
          //IComparable comp = new Numero(ver);
            IComparable alumAux=new Alumno("alumnoAux",ver,ver,ver);
            if (coleccionable.contiene(alumAux))
            {
                Console.WriteLine("El legajo esta en la coleccion");
            }
            else
            {
                Console.WriteLine("el legajo no esta en la coleccion");
            }
        }
		
		//Ej 13
		public static void llenaAlumnos(IColeccionable coleccionable)
        {
            List<string> nombres = new List<string>();
            nombres.Add("Ana");
            nombres.Add("Juan");
            nombres.Add("Jose");
            nombres.Add("Alberto");
            nombres.Add("Rosa");
            nombres.Add("Juana");
            nombres.Add("Maria");

            for (int i = 0; i < 20; i++)
            {
                Random azar = new Random();
                Random _dni = new Random();
                Random _leg = new Random();
                Random _prom = new Random();
                
                IComparable comparable = new Alumno(nombres[azar.Next(0, nombres.Count - 1)], _dni.Next(25000000,55000000),_leg.Next(10000,99999),_prom.Next(2,10)); ;
                coleccionable.agregar(comparable);
            }
        }
		
		public static void imprimirElementos (Iterable coleccionable){
			Iterador iterador = coleccionable.crearIterador();
			while(!iterador.fin() ){
				Console.WriteLine((iterador.actual()).ToString());
				iterador.siguiente();
			}
		}
		
		public static void cambiarEstrategia(Pila coleccionable, int estrategia){
			StrategyAlumno comparar2 = new PorNombre();
			switch(estrategia){
					case 2:   comparar2 = new PorPromedio();break;
					case 3:   comparar2 = new PorDni();break;
					case 1:   comparar2 = new PorLegajo();break;
					case 0:   comparar2 = new PorNombre();break;
			}
			
			Iterador iteraStrategy = coleccionable.crearIterador();
			while(!iteraStrategy.fin()){
				((Alumno)iteraStrategy.actual()).Estrategia = comparar2;
				Console.WriteLine("Cambiando de estrategia a {0}",(iteraStrategy.actual()).ToString());
				iteraStrategy.siguiente();
			}
		}



		
		

		

     }
		
 }