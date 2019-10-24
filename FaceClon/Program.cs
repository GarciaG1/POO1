using System;
using System.Collections.Generic;

namespace FaceClon
{
  
    abstract class Publicacion
    {
        protected string nombre;
    protected int fecha;
    protected int hora;
    protected string estado;
    protected string reaccion;
    
        public Publicacion (int f,int h,string e ,string r){
        this.fecha=f;
        this.hora=h;
        this.estado=e;
        this.reaccion=r;
        }    
       abstract public void   imprime();
       abstract public void   usuario();
        
    }

    class Estado:Publicacion
    {
       // protected string estado;
        public Estado (int fe,int ho,string es,string re):base(fe,ho,es,re)
        {
            this.reaccion=re;
            this.fecha=fe;
            this.estado=es;
            this.hora=ho;
        }
        public override  void imprime(){
            Console.WriteLine("fecha: {0} de octubre del 2019, hora: {1} pm, estado {2}, reaccion {3} " ,fecha,hora,estado,reaccion);
        
        }
       
        public override void usuario(){
            nombre="Gabriel Garcia";
            Console.WriteLine("Publicado por: "+nombre);
        }
    }
    class Foto: Publicacion
    {
        public  Foto (int fecha,int ho,string es,string re): base(fecha,ho,es,re)
        {
            
        }
         public override  void imprime(){
            Console.WriteLine("fecha: {0}, hora: {1}, estado {2}, reaccion{3} " ,fecha,hora,estado,reaccion);
        }
        
        public override void usuario(){
            nombre="Angel Garcia";
            Console.WriteLine("Publicado por: "+nombre);
        }

    }
    class Links:Publicacion
    {
        public  Links (int fecha,int ho,string es,string re): base(fecha,ho,es,re)
        {
            
        }
         public override  void imprime(){
            Console.WriteLine("fecha: {0}, hora: {1}, estado {2}, reaccion{3} " ,fecha,hora,estado,reaccion);
          
        }
        
        public override void usuario(){
            nombre="GarciaG1";
            Console.WriteLine("Publicado por: "+nombre);
        }
    }
   


    class Program
    {

        static void Main(string[] args)
        {

            List<Publicacion> muro= new List<Publicacion>();
            muro.Add(new Estado(23,12,"Me siento Feliz","10 Likes"));
            muro.Add(new Estado(24,1,"imagen.jpg","5 me divierte"));
            muro.Add(new Estado(25,2,"http://github,com/GarciaG1","7 me encanta"));
            muro[0].usuario();
            muro[0].imprime();
            Console.WriteLine("-------------------------------------------");
            muro[1].usuario();
            muro[1].imprime();
            Console.WriteLine("-------------------------------------------");
            muro[2].usuario();
            muro[2].imprime();
            
        }
    }
}
