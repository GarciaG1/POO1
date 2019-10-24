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
       
        public double descuento( double re,double desc ,in double n) {
      
      re= desc*n;
   
      
       
        return re;
        
        }
    }
    class Usuario
    {
  
        static public void usuarios (Datos Id) { 
			Id.nombre = "xxxxxxxxx";
			 Id.nuevoID = "xxxxxxxxx";
	    }
	    //ref

	    static public void Usuarios_ref( ref Datos Id ) { 
			Id = new Datos();
			Id.nombre = "Gabriel";
			Id.nuevoID = "GarciaG1";
	    }
    
        //out
        static void carrito(int producto1, int cantidad, out  double resultado ){
            resultado = producto1 * cantidad;
        }
        
     
	

        static void Main()
        {
            Datos usu= new Datos();

            Console.WriteLine("Usuario:");
            //ref;
                Console.Write(usu.nombre+"  ");
		        usuarios(usu);
		       // Console.WriteLine(usu.nombre);
		        Usuarios_ref(ref usu);
		        Console.WriteLine(usu.nuevoID);
		        
            //out
                 
                int p =100;
                int c=5;
                double r;
                carrito(p,c,out r);
                Console.WriteLine("Costo del producto:{0}  Cantidad de productos:{1} ",p,c);
                Console.WriteLine("Total de la compra: "+r);
            // in
                 Descuento d = new Descuento();
		        double dc=0.50;
                r=p*c;
                double res=r;
                //double x = 0.5;
                //d.descuento(res,dc,in r);
                
              Console.WriteLine("Total con descuento de 50%: "+d.descuento(r,dc, in r));   
        }
    }

}
