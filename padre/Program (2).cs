using System;
using System.Collections.Generic;
namespace Componentes
{
    class Componente 
   {
       public string nombre;
       public contenedor padre;
       public Componente (string nombre,contenedor padre)
       {
           this.nombre=nombre;
           this.padre=padre;
       }
       public void print (){
           Console.WriteLine($"soy {nombre} y mi padre es {padre.nombre}");
       }
   }
   class contenedor{
       public string nombre;
       public List<Componente> componentes = new List<Componente>();
       
       public contenedor(string nombre)
       {
           this.nombre=nombre;
           componentes.Add(new Componente("primero",this));
           componentes.Add(new Componente("segundo",this));
           componentes.Add(new Componente("tercero",this));
       }
       public void print(){
           foreach (var hijo in componentes)
           {
               hijo.print();

           }
       }
   }
    class Program
    {
        static void Main(string[] args)
        {
            contenedor padre1 = new contenedor("contenedor1");
            contenedor padre2 = new contenedor("contenedor2");
            Console.WriteLine("------------------------");
            padre1.print();
            padre2.print();
        }
    }
}
