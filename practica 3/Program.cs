

using System;
using System.Collections;

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
			string clave_elegida;
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
			
			Console.WriteLine(" Deseas Modificar[1] o eliminar[2] un valor");
			int eleccion = int.Parse(Console.ReadLine());
			Console.Clear();
			
			if(eleccion == 1){
				
				Console.WriteLine("Captura la clave a modificar");
				clave_elegida = Console.ReadLine();
				Console.Clear();
				if(tabla.Contains(clave_elegida)){
					Console.WriteLine("¿Seguro que quiere modificar este registro?");
					Console.WriteLine("Clave  Nombre");
					Console.WriteLine(clave_elegida + ' ' +  tabla[clave_elegida].ToString());
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
						}
					else{
						Console.WriteLine("No se ah hecho ningun cambio");
						}
					}
				else{
					Console.WriteLine("La Clave ingresada no existe");
				}
				
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		
			 	}
	
		
		
		
		
		
	      public static void PrintKeysAndValues( Hashtable tabla )  {
    	  Console.WriteLine( "\tClave \t Nombre " );
    	  foreach ( DictionaryEntry de in tabla )
          Console.WriteLine( "\t{0}:\t{1}", de.Key, de.Value );
    	  Console.WriteLine();
   	}
	
		
		
		
		
		
		
			//if(tabla.ContainsKey()){
				//editar o eliminar
			//	persona per = (persona) tabla [p.clave];
		//	}
			
			
			
		}
	}
