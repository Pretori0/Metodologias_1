/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 27/4/2025
 * Hora: 17:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace TP_3
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : IColeccionable, Iterable
	{
		List <IComparable> conjunto;
		
		public Conjunto()
		{
			this.conjunto = new List<IComparable>();
		}
		
		
		public int cuantos()
		{
			return this.conjunto.Count;
		}
		
		public IComparable minimo()
		{
			IComparable minimo = null;
            if (conjunto.Count > 0)
                minimo = conjunto[0];
            foreach (IComparable elemento in this.conjunto)
            {
                if (elemento.sosMenor(elemento))
                    minimo = elemento;
            }
            return minimo;
		}
		
		public IComparable maximo()
		{
			IComparable maximo = null;
            if (conjunto.Count > 0)
                maximo = conjunto[0];
            foreach (IComparable elemento in conjunto)
            {
                if (elemento.sosMayor(elemento))
                    maximo = elemento;
            }
            return maximo;
		}
		
		/*
		public void agregar(IComparable comparable)
		{
			elementos.Add(comparable);
		}
		*/
		
		public bool contiene(IComparable comparable)
		{
			foreach (IComparable elemento in conjunto) 
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }
         return false;
		}
		
		public void agregar( IComparable elemento){
			if(!(this.pertenece(elemento))){
				this.conjunto.Add(elemento);
				Console.WriteLine("Elemento Agregado");
			}else{
				Console.WriteLine("Elemento ya se encuentra en el Conjunto");
			}
			
		}
			
		
		public bool pertenece(IComparable elemento){
			return this.conjunto.Contains(elemento);
			
		}
		
		
		
		public Iterador crearIterador()
		{
			return new IteraColeccion(this.conjunto);
		}
	}
}
