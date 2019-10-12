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
 public Duracion (int s)  
 {
     
     
    this.segundos=s;
 } 
 public void print()
 {
     Console.WriteLine("Duracion= ["+horas+":"+minutos+":"+segundos+"]");
 }
  
 public int get_minutos ()
 {
     int m;
     m=minutos=(horas*60) + minutos;
    return m;
    
 }
  public int  get_segundos()
 {  int s;
     s= (minutos*60) + (horas*3600)+segundos;
   
     
    return s;
 }
}

class Program
    {
        static void Main(string[] args)
        {
          Duracion Total=new Duracion(03,20,10);
         
         
         Total.print();  
        Console.WriteLine("segundos:"+Total.get_segundos());
        Console.WriteLine("minutos:"+Total.get_minutos());

        }
    }
}