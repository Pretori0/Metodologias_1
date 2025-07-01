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

namespace MP1_TP2
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		int legajo;
		int promedio;
		StrategyAlumno estrategia;
						
		public Alumno(string n, int d, int l, int p):base(n, d)
		{
			this.legajo = l;
			this.promedio = p;
			this.estrategia = new PorPromedio();
			
		}
		
						
		public int getLegajo{
			get{return this.legajo;}
		
		}
		
		public int getPromedio{
			get{return this.promedio;}
		}
		
		public override bool sosIgual(IComparable comparable){
			int resultado =  estrategia.comparar(this, (Alumno)comparable);
			if(resultado == 1){return true;}
			return false;
			
		}
		public override bool sosMenor(IComparable comparable){
			int resultado =  estrategia.comparar(this,(Alumno)comparable);
			if(resultado == 2){return true;}
			return false;
		}
		public override bool sosMayor(IComparable comparable){
			int resultado =  estrategia.comparar(this,(Alumno)comparable);
			if(resultado == 3){return true;}
			return false;

		}
		
		public override string ToString()
		{
			return string.Format("[Alumno Legajo={0}, Promedio={1}, Estrategia={2}]", legajo, promedio, estrategia);
		}

				
		public StrategyAlumno Estrategia{
			set{estrategia = value;}
		}

		
	}
		
		
	}

