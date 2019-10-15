using System;
using System.Collections.Generic;
namespace Musico
{
    class Musico {
        protected string nombre;
    
    public Musico (string n){
        nombre=n;
    }
    public void saluda(){
        Console.WriteLine("Hola soy:",nombre);

    }
        public void afina(){
        Console.WriteLine("{0} afina su instrumento ",nombre);
    

        }

    }

    class Bajista: Musico{
     private string bajo;
     public Bajista (string nom,string bajo):base(nom){

            this.bajo=bajo;
        }
        public new void afina(){
        Console.WriteLine("{0} afina su bajo {1}",nombre,bajo);}
    

    }

     
 
    class Program
    {
        static void Main(string[] args)
        {
            Musico tom = new Musico("Tom");
            Bajista Flea = new Bajista("Flea","Gibson");
            tom.saluda();
            Flea.saluda();
            tom.afina();
            Flea.afina();
        }
    }   
}   

