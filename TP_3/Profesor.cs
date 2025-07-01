/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 13/6/2025
 * Hora: 15:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace TP_3
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor:Persona,IObservado
	{
		int antiguedad;
		List <IObservador> observadores;
			public Profesor(string n, int d, int a):base(n,d)
			{
			this.antiguedad=a;
			observadores = new List<IObservador>();
			}
		
			public int Antiguedad{
			get{return this.antiguedad;}
			set{this.antiguedad = value;}
		}
		
			public void hablarALaClase(){
				Console.WriteLine("Hablando de algun Tema");
				this.notificar(1);
			}
			
			public void escribirEnPizarron(){
				Console.WriteLine("Escribiendo en el pizarron");
				this.notificar(2);
			}
			
			public void dictadoDeClases(){
				for(int i=0;i<5;i++){
					this.hablarALaClase();
					this.escribirEnPizarron();
				}
			}
			
			public override bool sosIgual(IComparable comparable){
			if( this.Antiguedad == ((Profesor)comparable).Antiguedad){
				return true;
			}
			return false;
		}
		public override bool sosMenor(IComparable comparable){
				if (this.Antiguedad > ((Profesor)comparable).Antiguedad){
				return true;
			}
			return false;
		}
		public override bool sosMayor(IComparable comparable){
				if(this.Antiguedad < ((Profesor)comparable).Antiguedad){
				return true;
			}
			return false;
		}
		
		public override string ToString()
		{
			return string.Format("[Profesor: {1} Dni:{2} Antiguedad={0}]", antiguedad,nombre,dni);
		}
			
		
		
		public void agregarObservador(IObservador o)
		{
			this.observadores.Add(o);
		}
		
		public void quitarObservador(IObservador o)
		{
			this.observadores.Remove(o);
		}
		
		public void notificar(int opcion)
		{
			foreach(IObservador o in observadores){
				o.actualizar(opcion);
			}
		}
	}
}
