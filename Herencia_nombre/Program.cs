using System;
using System.Collections.Generic;

namespace Alumno_herencia
{

    // Clase Alumno
    class Alumno 
    {
        //Variables
        protected int num_control;
         protected string residencias;
        protected string servicio;
        protected string nombre;
        //construtor
        public Alumno (string nombre , int num_control,string servicio,string residencias)
        {
        this.num_control=num_control;
        this.nombre=nombre;
        }
        //metodo imprime
        public void  imprime()
        {
            Console.WriteLine("Su nombre es {0}, su numero de control es {1} ",nombre,num_control);
        }
    }
    //Clase Licenciatura que hereda de Alumno
    class Licenciatura:Alumno
    {
       
       
        //Constructor 
        public  Licenciatura(string no, int num, string re,string se):base(no,num,re,se)
        {
            residencias=re;
            servicio=se;
            nombre=no;
            num_control=num;
        }
        
       //metodo imprime
        public new void imprime()
        {
            Console.WriteLine("Su nombre es {0} es de licenciatura y su numero de control es {1}, practica sus recidencias en {2} y hace su servicio social en {3}",nombre,num_control,residencias,servicio);
        }
    }
    
    //Clase Posgrado que hereda de Alumno
    class Posgrado:Alumno
    {
        
          //Constructor de posgrado 
        public  Posgrado(string no, int num, string re,string se):base(no,num,re,se)
        {
            residencias=re;
            servicio=se;
            nombre=no;
            num_control=num;
        }

      

        // metodo imprime 
      public new void imprime()
        {
            Console.WriteLine("su nombre es {0} es de posgrado y su numero de control es {1}, hace sus recidencias en {2} y hace su servicio social en {3}",nombre,num_control,residencias,servicio);
        }
    
    }
    



    class Program
    {
        //Main
        static void Main(string[] args)
        {
                             //objetos
                //Alumno
            Alumno Gabriel = new Alumno("Gabriel",19210493,"","");
            //Alumno con licenciatura
            Licenciatura Garcia = new Licenciatura("Garcia",19210493,"cdm ","Coppel");
            //Alumno de posgrado
            Posgrado Angel = new Posgrado("Angel Garcia",19210516 , "x","carls jr");
            //Manda a llamar al metodo imprime de cada objeto
            Gabriel.imprime();
            Garcia.imprime();
            Angel.imprime();
            
        }
    }

}