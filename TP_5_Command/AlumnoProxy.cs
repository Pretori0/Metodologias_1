/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 19/6/2025
 * Hora: 22:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Command
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy:IAlumno
		
	{
		protected IAlumno alumnoReal = null;
		GeneradorDeDatosAleatorios rnd=new GeneradorDeDatosAleatorios();
		StrategyAlumno estrategia;
		protected string nombre;
		protected int legajo,dni,promedio,calificacion;
		public AlumnoProxy(string n, int d, int l, int p )
		{
			this.nombre=n;
			this.dni=d;
			this.legajo=l;
			this.estrategia = new PorPromedio();
			this.promedio=p;
			this.calificacion = 4;
		}
		
		public string getNombre()
		{
		return	this.nombre;
		}
		
		public int getDni()
		{
			return this.dni;
		}
		
		public int getLegajo(){
			return this.legajo;
		
		}
		
				
		public int Calificacion{
			get{return this.calificacion;}
			set{this.calificacion=value;}
		}
		
		
		public virtual int responderPregunta(int p)
		{
			if(alumnoReal == null){
			alumnoReal = new Alumno(nombre,legajo,dni,promedio);
			
			Console.WriteLine("Creada Instancia Real ALUMNO");
			}
			return alumnoReal.responderPregunta(p);
			
		}
		
		public void setCalificacion(int c)
		{
			this.calificacion=c;
		}
		
		public string mostrarCalificacion()
		{
			return this.getNombre()+"  "+(this.getLegajo()).ToString()+"  "+(this.Calificacion).ToString();
		}
		
		public  bool sosIgual(IAlumno comparable){
			int resultado =  estrategia.comparar(this, comparable);
			if(resultado == 1){return true;}
			return false;
			
		}
		public  bool sosMenor(IAlumno comparable){
			int resultado =  estrategia.comparar(this,comparable);
			if(resultado == 2){return true;}
			return false;
		}
		public  bool sosMayor(IAlumno comparable){
			int resultado =  estrategia.comparar(this,comparable);
			if(resultado == 3){return true;}
			return false;

		}
		
		public int getPromedio()
		{
			return this.promedio;;
		}
	}
}
