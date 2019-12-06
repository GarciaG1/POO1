using System;

namespace Duracion
{
    //class duracion
    class Duracion
    {

        public int horas;
        public int minutos;
        public int segundos;
        //constructor
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
        //metodo imprime los minutos,horas y segundos iniciales

        public void print()
        {
            Console.WriteLine("Duracion=["+horas+":"+minutos+":"+segundos+"]");
        }
        // imprime los segundos totales de la suma

        public void print2()
        {
            
            Console.WriteLine("a+b= "+segundos);
        }

        //metodo para convertir minutos y horas a segundos y los suma
        public int get_segundos()
        {
            int s;
            s=(minutos*60)+(horas*3600)+segundos;
                //retorna segudos
            return s;
        }
        //metodo para convertir las horas a segundos y sumarlas
        public int get_minutos()
        {
            int m;
            m= minutos=(horas*60)+minutos;

                //retorna minutos
            return m;
        }
        //operador,suma las duraciones
        public static Duracion operator +(Duracion a, Duracion b)
        {
            int sum=0;
            sum=sum+(a.horas+b.horas)*3600;
            sum=sum+(a.minutos+b.minutos)*60;
            sum=sum+(a.segundos+b.segundos);

            //retorna la suma
            return new Duracion (sum);


        }


    }
    class Program
    {
        //main
        static void Main(string[] args)
        {
            //objetos
            
           Duracion Total = new Duracion(03,20,10);
            Duracion a= new Duracion (5,22,43);
            Duracion b= new Duracion(07,23,08);
            Duracion c;
            
           // imprime los segundos y minutos totales
           Total.print();
           Console.WriteLine("Minutos:"+Total.get_minutos());
           Console.WriteLine("Segundos:"+Total.get_segundos());
           //suma de a+b
            c=a+b;
            //imprime la suma
           c.print2();
        }

    }
}

