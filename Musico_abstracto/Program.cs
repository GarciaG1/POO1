using System;
using System.Collections.Generic;

namespace Musico
{  //clase abstract  Musico
    // La clase abstracta obliga a las clases derivadas 
    //de la misma a implementar los metodos y constructores utilizados en esta clase
    abstract class Musico 
    {       
            //protected sirve para que otras clases la hereden y la puedan usar
            protected string nombre;
            //constructor
            public Musico (string n)
            {
                nombre=n;
               ;
            }
            //metodo saluda
            //virtual sirve para crear otro metodo con el mismo nombre pero con contenido distinto
            public abstract void saluda();
            
        //public void afina(){
            //metodo afina
        public abstract void afina ();
    }
    class Bajista: Musico 
    {
        private string bajo;
        //constructor 
        //base: Su funcion es mandar a llamar las variables de la clase que estamos heredando
        public Bajista (string nom,string b):base(nom)
        {

            this.bajo=b;
        }
    
        //public new void afina(){
             public override void  afina()
             {
              Console.WriteLine("{0} afina su bajo {1}",nombre,bajo);
             }
         
              public override void saluda()
               {
                Console.WriteLine("soy {0} y soy bajista",nombre);
              }
    }
    class Baterista: Musico 
    {
        private string bateria;
        //constructor 
        //base: Su funcion es mandar a llamar las variables de la clase que estamos heredando
        public Baterista (string nom,string ba):base(nom)
        {

            this.bateria=ba;
        }
    
        //public new void afina(){
             public override void  afina()
             {
              Console.WriteLine("{0} prepara su bateria {1}",nombre,bateria);
             }
         
              public override void saluda()
               {
                Console.WriteLine("soy {0} y soy baterista",nombre);
              }
    }
    //Clase que hereda de Musico  
    class Guitarrista:Musico
    {
         private string guitarra;
            //constructor
         public Guitarrista(string n,string g):base(n)
         {
            this.guitarra=g;
         }
            //metodo afina
        public override void afina ()
        {
            //instrumento y nombre
            Console.WriteLine("{0} ,afina su guitarra {1}",nombre,guitarra);
        }
        //metodo saluda
        public override void saluda()
        {
            Console.WriteLine("soy {0} y soy guitarrista",nombre);
           ;
        }
        
     }
            
   
    class Program
    {   //main
        static void Main(string[] args)
        {   //objetos
            Musico Gabriel = new Baterista("Gabriel","Yamaha");
            Bajista Garcia = new Bajista("Garcia","Gibson");
            Guitarrista Angel= new Guitarrista("Angel","Paracho");
            
            //Lista (grupo de musicos)
            List < Musico > grupo = new List <Musico>();
            grupo.Add(Gabriel);
            grupo.Add(Garcia);
            grupo.Add (Angel);
            //estructura repetitiva
            foreach (Musico m in grupo)
            {
               m.saluda();
                m.afina();
            }
            
                
            
        }
    }    
    
}   

