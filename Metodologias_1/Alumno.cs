/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 9/4/2025
 * Hora: 20:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MP1_TP1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		int legajo;
		int promedio;
		
		
		public Alumno(string n, int d, int l, int p):base(n, d)
		{
			this.legajo = l;
			this.promedio = p;
			
		}
		
		
		
		
		public int getLegajo{
			get{return this.legajo;}
		
		}
		
		public int getPromedio{
			get{return this.promedio;}
		}
		
		public override bool sosIgual(IComparable comparable){
			if( this.getLegajo == ((Numero)comparable).getValor){
				return true;
			}
			return false;
		}
		public override bool sosMenor(IComparable comparable){
			if (this.getLegajo > ((Alumno)comparable).getLegajo){
				return true;
			}
			return false;
		}
		public bool sosMayor(IComparable comparable){
			if(this.getLegajo < ((Alumno)comparable).getLegajo){
				return true;
			}
			return false;
		}
		
	}
		
		
	}

