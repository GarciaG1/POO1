using System;
using System.Collections.Generic;

namespace Parametros
{
    class Datos
    {
         public string nombre;
        public string nuevoID;

        public Datos()
        {
            nombre="Gabriel";
            nuevoID="GarciaG1";
        }
    }
    class Descuento
    { 
   public void descuento(in int n) {
       n= n/2;
   }
    
    }
    class Usuario
    {
  
        static public void usuarios (Datos Id) { 
			Id.nombre = "xxxxxxxxx";
			 Id.nuevoID = "xxxxxxxxx";
	    }
	    static public void Nuevo(Datos Id) { 
			Id = new Datos();
			Id.nombre = "Gabriel";
			Id.nuevoID = "GarciaG1";
	    }

	    static public void Nuevo_ref( ref Datos Id ) { 
			Id = new Datos();
			Id.nombre = "Gabriel";
			Id.nuevoID = "GarciaG1";
	    }
    
        //out
        static void carrito(int producto1, int cantidad, out carrito resultado ){
            resultado = producto1 * cantidad;
        }
        
    
	

        static void Main()
        {
            Datos usu= new Datos();

            Console.WriteLine("Usuario:");
            //ref;
                Console.WriteLine(usu.nombre);
		        usuarios(usu);
		        Console.WriteLine(usu.nombre);
		        Nuevo(usu);
		        Console.WriteLine(usu.nombre);
		        Nuevo_ref( ref usu);
		        Console.WriteLine(usu.nuevoID);
            //out
                int g =100;
                int g2=5;
                int r;
                carrito(g,g2,out resultado );
                Console.WriteLine(resultado);
            // in
                 Descuento d = new Descuento();
		        int x = 0.50;
                d.descuento( in x);
		        Console.WriteLine(x);   
        }
    }

}
    
        

