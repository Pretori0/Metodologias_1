/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 2/4/2025
 * Hora: 18:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP_3
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila : IColeccionable,Iterable
	{
		List<IComparable> elementos ;
		
		public Pila(){
			this.elementos = new List<IComparable>();
		}
        
        public void agregar(IComparable comparable)
        {
            elementos.Add(comparable);
        }

        public void pop (IComparable comparable)
        {
            if (this.elementos.Count > 0) 
                this.elementos.RemoveAt(this.elementos.Count - 1);
        }
        public bool contiene (IComparable comparable)
        {
            foreach (IComparable elemento in elementos) 
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }
         return false;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public IComparable maximo()
        {
            IComparable maximo = null;
            if (elementos.Count > 0)
                maximo = elementos[0];
            foreach (IComparable elemento in elementos)
            {
                if (maximo.sosMayor(elemento))
                    maximo = elemento;
            }
            return maximo;
        }

        public IComparable minimo()
        {
            IComparable minimo = null;
            if (elementos.Count > 0)
                minimo = elementos[0];
            foreach (IComparable elemento in elementos)
            {
                if (minimo.sosMenor(elemento))
                    minimo = elemento;
            }
            return minimo;
        }
        public List <IComparable> Elementos {
        	get{return this.elementos;}
        }
        
        /*public void llenar()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Numero comparable = new Numero(rnd.Next(10, 30));
                this.agregar(comparable);
            }
        }*/
		
		public Iterador crearIterador()
		{
			return new IteraColeccion(this.Elementos);
		}
	}
}
