using System;

namespace Duracion
{
class Duracion 
{
    public int horas;
    public int minutos;
    public int segundos;
public Duracion (int h,int m,int s)  
 {
     this.horas=h;
     this.minutos=m;
     this.segundos=s;
 } 
 public void print ()
 {
     Console.WriteLine("Duracion="+horas+":"+minutos+":"+segundos);
    convertir();
    Console.WriteLine("Minutos="+minutos);
    Console.WriteLine("Segundos="+segundos);
 }
 public void convertir()
 {
     minutos=horas*60 + minutos;
     segundos= (minutos*60) + (horas*3600)+segundos;

 }
}
class Program
    {
        static void Main(string[] args)
        {
          Duracion conversion=new Duracion(03,20,10);
         conversion.print();  

        }
    } 

 
}

/*class Duracion 
    {
        public int horas=2;
        public int minutos=15;
        public int segundos=10;

    public Duracion (int h,int m,int s)
    {
        //minutos=new  minutos()

       
        this.segundos=s;
        this.horas= h;
        this.minutos=m;
        
        
    }
    public Duracion (int s)
    {
       // minutos= horas*60;
        //segundos = minutos*3600;
        segundos=s;
        
    }
    public  int get_minutos(int s)
    {
        return s;
    }
    public void print_segundos ()
    {
       Console.WriteLine(segundos) ;
    }
    public int  print_minutos()
    {
           return minutos;
    }

    public void print_horas ()
    {
       Console.WriteLine(horas) ;
    }
     


    }
    */
    