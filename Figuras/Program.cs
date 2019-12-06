using System;
using System.Collections.Generic;

namespace Figuras
{
    //clase abstracta
    abstract class Figura
    {
         
        //Tamaño de la figura
        protected int py;
        protected  double px;
        //color de la figura
        protected string color;
         protected double a;
        
        //constructor
        public Figura ( double x, int y, string col)
        {
           
            px=x;
            py=y;
            color=col;
            
        
        }
        //metodo dibuja
        public abstract void  dibuja();
        //metodo area
        public abstract void area ();
        
        
    }
    //clase Rectangulo que hereda de Figura
    class Rectangulo:Figura
    
    {
        //constructor 
        //base sirve para invocar las variables de la clase figura 
        public Rectangulo(double x,int y, string col): base(x,y,col)
        {
            

        }
        //metodo dibuja
        //imprime el color y tamaño de la figura
        public override void dibuja(){
            Console.WriteLine("Se dibuja un rectangulo color: {0},de base: {1} y de largo: {2}",color,px,py);
        }
        //metodo area
        //imprime el area de la figura
        public override void area(){
           
            a= (px*py)/2;
            Console.WriteLine("El area es de b*h/2= "+a);
        }
    }
    
    
    // clase circulo que hereda de la clase 
    class Circulo:Figura
    
    {
        //constructor 
        //base sirve para invocar las variables de la clase figura 
        public Circulo(double x,int y, string col): base(x,y,col)
        {
            

        }
        //metodo dibuja
        public override void dibuja(){
            Console.WriteLine("Se dibuja un circulo color: {0},de base: {1} y de largo: {2}",color,px,py);
        }
        //metodo area
        public override void area(){
           
            a= px*(py*py);
            Console.WriteLine("El area es de pi*r^2="+a);
        }
    }
    
    
    
    class Program
    {   //Main
        static void Main(string[] args)
        {   // Se crean los Objetos
            Rectangulo re= new Rectangulo(2,4,"Verde");
            Rectangulo re2=new Rectangulo(3,7,"Azul");
            Circulo ci= new Circulo(3.15,4,"Negro");
            Circulo ci2= new Circulo(3.15,6,"Rojo");

            // lista de figuras
            List<Figura> figu=new List<Figura>();
            figu.Add(re);
            figu.Add(re2);
            figu.Add(ci);
            figu.Add(ci2);
            //Dibuja e imprime el area de cada figura
            foreach( Figura Fi in figu)
            {
                Fi.dibuja();
                Fi.area();
            }
        }
    }
}
