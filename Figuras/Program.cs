using System;
using System.Collections.Generic;

namespace Figuras
{
    abstract class Figura
    {
         protected  int ancho,alto;
        //coordenada de la figura
        protected int px,py;
        protected string color_relleno,color_borde;
        //grosor del borde
        public Figuras (string ancho,string alto, string px, string py, string color_borde,string color_relleno)
        {
            this.ancho=ancho;
            this.alto=ancho;
            this.px=px;
            this.py=py;
            this.color_borde=color_borde;
            this.color_relleno=color_relleno;
        }
        public abstract dibuja();

        public void area ()
        {
            console.WriteLine("Seleccione la figura: (1-. Rectangulo 2-. Circulo 3-. linea");
            f=string.parse(console.readline());
            switch(f)
            {
                
                
                default:
            }
        }
        
    }
    class Rectangulo:Figuras
    
    {
        public rectangulo(): base()
        {}
        public override void dibuja(){
            console.WriteLine("Se dibuja un rectangulo color{0},en x:{1} y Y:{2}",color_relleno,px,py);
        }
    }
    
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras=new list<figura>();
            figuras.Add(new Rectangulo(10,10));
        }
    }
}
