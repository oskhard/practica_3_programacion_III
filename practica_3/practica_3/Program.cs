/*
 * Created by SharpDevelop.
 * User: oscar hernandez
 * Date: 03/11/2014
 * Time: 12:41 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_3
{
	
	class persona
	{
		public string nombre;
		public string clave;

	}
	
	class control_usuarios
    	{
		public static void Main(string[] args)
     		{
			int a=0;
			string clave_elegida, accion;
			Hashtable tabla = new Hashtable();
			
			do{
						
				persona p = new persona();
				Console.WriteLine("Nombre ");
				p.nombre = Console.ReadLine();
				Console.Clear();
				Console.WriteLine("Clave ");
				p.clave = Console.ReadLine();
				Console.Clear();
				tabla.Add(p.clave, p.nombre);
				a++;
			
			}while(a <= 2);
			
			PrintKeysAndValues(tabla);
			do{
			Console.WriteLine(" Seleccione una opcion:");
			Console.WriteLine(" Modificar=1");
			Console.WriteLine(" Eliminar=2");
			int eleccion = int.Parse(Console.ReadLine());
			Console.Clear();
			if(eleccion == 1){
				
				Console.WriteLine("Ingresela la clave a modificar");
				clave_elegida = Console.ReadLine();
				Console.Clear();
				if(tabla.Contains(clave_elegida)){
					Console.WriteLine("¿Seguro que quiere modificar este registro?");
					Console.WriteLine("Clave  Nombre");
					Console.WriteLine(clave_elegida + ' ' + ' ' + tabla[clave_elegida].ToString());
					char seguridad = char.Parse(Console.ReadLine());
					if (seguridad == 's'){
						
						persona p = new persona();
						Console.WriteLine("Nuevo nombre:");
						p.nombre = Console.ReadLine();
						Console.WriteLine("Nueva Clave");
						p.clave = Console.ReadLine();
						tabla.Remove(clave_elegida);
						tabla.Add(p.clave, p.nombre);
						Console.WriteLine("la tabla se ah modificado");
						PrintKeysAndValues(tabla);
						}
					else{
						Console.WriteLine("No se ah hecho ningun cambio");
						}
					}
				else{
					Console.WriteLine("La Clave ingresada no existe");
				}
				
			}
			else{
				Console.WriteLine("Teclee la clave a eliminar");
				clave_elegida = Console.ReadLine();
				if(tabla.Contains(clave_elegida)){
				   	Console.WriteLine("Seguro que desea Eliminar este Registro: " + clave_elegida);
				   	char seguridad = char.Parse(Console.ReadLine());
				   	if(seguridad == 's'){
				   		tabla.Remove(clave_elegida);
				   		Console.WriteLine("Se ah borrado el registro con exito");
				   		PrintKeysAndValues(tabla);
				   	}
				   	else{
				   		Console.WriteLine("No se ha Eliminado el registro" + clave_elegida);
				   		}
					}
				else{
					Console.WriteLine("La Clave ingresada no existe");
				}
			}
			
			Console.WriteLine("desea continuar editando los valores? [s/n]");
			accion = Console.ReadLine();
			}while( accion == "s");
			Console.Write("Gracias por utilizar Software LDMC ");
			Console.ReadKey(true);
		
			 	}
		
	      public static void PrintKeysAndValues( Hashtable tabla )  {
    	  Console.WriteLine( "\tClave \t Nombre " );
    	  foreach ( DictionaryEntry de in tabla )
          Console.WriteLine( "\t{0}:\t{1}", de.Key, de.Value );
    	  Console.WriteLine();
   	}			
			
			
		}
	}
