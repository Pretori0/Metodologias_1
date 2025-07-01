/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 11/4/2025
 * Hora: 15:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
namespace MP1_TP1
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple : IColeccionable
		
	{
		Pila pila;Cola cola;
		
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		public int cuantos(){
			return this.pila.cuantos() + this.cola.cuantos();
		}
		public IComparable minimo(){
			if(((Persona)this.cola.minimo()).getDni < ((Persona)this.pila.minimo()).getDni){
				return this.cola.minimo();
			}
			return this.pila.minimo();
		}
		public IComparable maximo(){
			if(((Persona)this.cola.maximo()).getDni < ((Persona)this.pila.maximo()).getDni){
				return this.pila.maximo();
			}
			return this.cola.maximo();
		}
		public void agregar(IComparable comparable){
			
		}
		public bool contiene (IComparable comparable){
			
			return this.pila.contiene(comparable) || this.cola.contiene(comparable);
			
		}
	}
}
