using System;
using System.Collections.Generic;

namespace Musico
{
    class Musico 
    {
            protected string nombre;
    
            public Musico (string n)
            {
                nombre=n;
            }
            public virtual void saluda()
            {
            return string.Format ("Hola soy {0}",nombre);

            }
        //public void afina(){
        public virtual void afina ()
        {
        Console.WriteLine("{0} afina su instrumento ",nombre);
        }
    }                                      
            class Bajista:Musico
    {
        private string bajo;
        public Bajista (string nom,string b):base(nom)
        {

            this.bajo=b;
        }
    
        //public new void afina(){
             public override void  afina()
             {
              Console.WriteLine("{0} afina su bajo {1}",nombre,bajo);
             }
         
              public override string saluda()
               {
                return base.saluda()+"y soy bajista";
              }
    }

    class Guitarrista:Musico
    {
         private string guitarra;

         public Guitarrista(string n,string g):base(n)
         {
            guitarra=g;
         }

        public override void afina ()
        {
            
            console.WriteLine("{0} afinando su  {1}",nombre,guitarra);
        }
        public override string saluda()
        {
            return base.saluda()+"y soy guitarrista";
        }
        
     }
            
   
    class Program
    {
        static void Main(string[] args)
        {
            Musico Gabriel = new Musico("Gabriel");
            Bajista Garcia = new Bajista("Garcia","Gibson");
            Guitarrista Angel= new Guitarrista("Angel","x");
            

            List < Musico > grupo = new List <Musico>();
            grupo.Add(Gabriel);
            grupo.Add(Garcia);
            grupo.Add (Angel);
            foreach (Musico m in grupo)
            {
                console.writeline(m.saluda());
                m.afina();
            }
            
                
            
        }
    }   
}   

