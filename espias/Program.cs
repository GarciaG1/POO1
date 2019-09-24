using System;

namespace espias
{
  class persona
  {
     public string nombre;
     public string apellido;
     public persona()
     {
         nombre="fulano";
         apellido="De Tal";
     }
      
  }

    class anonymous{
        public static void anonimiza( persona p)
        {
            p.nombre= "xxxxxxxxxxx";
            p.apellido="xxxxxxxxxxxxxx";
        }

        public static void cambia (ref persona p)
        {
            p= new persona ();
            p.nombre= "new"; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             persona p=new persona();
             Console.WriteLine(p.nombre);
             anonymous.anonimiza(p);
             anonymous.cambia(ref p);
             Console.WriteLine(p.nombre);
             
             
           
        }
    }
}
