/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 2/4/2025
 * Hora: 22:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MP1_TP1
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : IColeccionable
	{
				
		List<IComparable> elementos ;
		
		public Cola (){
			this.elementos = new List<IComparable>();
		}
        
        public void agregar(IComparable comparable)
        {
            elementos.Add(comparable);
        }

        public IComparable pop ()
        {
        	IComparable _pop = elementos[0];
        		if (this.elementos.Count > 0) {
                this.elementos.RemoveAt(0);
                }
        	return _pop;
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
        
  	}
}
