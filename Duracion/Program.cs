using System;

namespace Duracion
{

    class Duracion
    {
        public int horas;
        public int minutos;
        public int segundos;

        public Duracion (int h, int m,int s)
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
            Console.WriteLine("Duracion=["+horas+":"+minutos+":"+segundos+"]");
        }

        public void print2()
        {
            
            Console.WriteLine("a+b= "+segundos);
        }

        
        public int get_segundos()
        {
            int s;
            s=(minutos*60)+(horas*3600)+segundos;

            return s;
        }
        public int get_minutos()
        {
            int m;
            m= minutos=(horas*60)+minutos;

            return m;
        }
        public static Duracion operator +(Duracion a, Duracion b)
        {
            int sum=0;
            sum=sum+(a.horas+b.horas)*3600;
            sum=sum+(a.minutos+b.minutos)*60;
            sum=sum+(a.segundos+b.segundos);

            return new Duracion (sum);


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
           Duracion Total = new Duracion(03,20,10);
            Duracion a= new Duracion (5,22,43);
            Duracion b= new Duracion(07,23,08);
            Duracion c;
            
           
           Total.print();
           Console.WriteLine("Minutos:"+Total.get_minutos());
           Console.WriteLine("Segundos:"+Total.get_segundos());
            c=a+b;
           c.print2();
        }

    }
}

