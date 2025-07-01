/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 2/4/2025
 * Hora: 16:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;


namespace MP1_TP2
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : IComparable
	{
		
			int valor;
			public Numero (int v){
				this.valor = v;
			}
			
			public int getValor {
				get{return valor;}
				set{this.valor = value;}
			}
				
			
			
			public bool sosIgual(IComparable comparable){
				if (valor == ((Numero)comparable).getValor ){
					return true;
				}
				return false;
				
			}
			
			public bool sosMenor(IComparable numero){
				if(valor > ((Numero)numero).getValor){
					return true;
				}
				return false;
			}
			
			public bool sosMayor(IComparable numero){
				if(valor < ((Numero)numero).getValor){
					return true;
				}
				return false;
			}
			
			
			
	}
	
}
