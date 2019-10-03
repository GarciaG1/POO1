using System;
using System.Collections.Generic;

namespace juego_delavida
{
    //conway game of life
    enum Estado{viva,vacia}
    class Celula 
    {
        public Estado estado_actual;
        public Estado estado_siguiente;
        //Posicion
        public short renglon;
        public short columnas;
        public Tablero tablero;

        public Celula(Estado inicial,Tablero tablero ,short renglon, short columnas)
        {
            estado_actual = inicial;
            this.renglon = renglon;
            this.columnas=columnas;
            this.tablero=tablero;
        }
        public void print(){
            if(this.estado_actual == Estado.vacia){
                //vacio
                Console.Write("-");
            }
            else
               //Viva
                Console.Write("|");

            
            
        }
        
        
        
    }
    class Tablero
    {
        private List <List<Celula >>    grid;
        public Tablero(){
            grid = new List<List<Celula>>();
            grid.Add ( new List<Celula>());

            grid[0].Add(new Celula(Estado.viva,this,0,0));
            grid[0].Add(new Celula(Estado.vacia,this,0,1));
             grid[0].Add(new Celula(Estado.vacia,this,0,2));

             grid[0].Add(new Celula(Estado.vacia,this,1,0));
            grid[0].Add(new Celula(Estado.vacia,this,1,1));
             grid[0].Add(new Celula(Estado.viva,this,1,2));

             grid[0].Add(new Celula(Estado.vacia,this,2,0));
            grid[0].Add(new Celula(Estado.vacia,this,2,1));
             grid[0].Add(new Celula(Estado.vacia,this,2,2));
        }
        public void print(){
             foreach ( List<Celula> renglon in grid){
                foreach (Celula c in renglon)
                {
                c.print();
                }
                Console.Write("\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           /*  Console.WriteLine("(alt+177) ");
              Console.WriteLine("|--");
              Console.WriteLine("--|");
              Console.WriteLine("--|");
              */
              Tablero juego_delavida = new Tablero();
              juego_delavida.print();
        }
    } 
}
