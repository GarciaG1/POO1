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
        public void actualiza_estado(){

        }
        public short num_vecinas(){
            short cuenta=0;
            //1
            //grid [renglon-1][columna-1]
                if(renglon>0 && columna > 0)
                {
                   if( tablero.grid[renglon-1][columna-1].estado_actual==Estado.viva)
                   cuenta++;
                }
             return cuenta;
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
        public List <List<Celula >>    grid;
        public Tablero(short num_renglon,short num_columnas){

            grid = new List<List<Celula>>();
           
            for(short i=0; i<=num_renglon; i++)
            {
                grid.Add ( new List<Celula>());
                for(short j=0; j<=num_columnas; j++)
                {
                        grid[i].Add(new Celula(Estado.viva,this,i,j));
                }
            }
            public void inserta(Celula c){
                grid.[c.renglon][c.columnas]=c;
            }
            
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
              Tablero juego_delavida = new Tablero(10,5);
              juego_delavida.inserta(new Celula(Estado.viva,juego_delavida,3,3));
              juego_delavida.inserta(new Celula(Estado.viva,juego_delavida,3,2));
              juego_delavida.inserta(new Celula(Estado.viva,juego_delavida,3,1));
              
              juego_delavida.print();
              console.WriteLine(juego_delavida.inserta(new Celula(Estado.viva,juego_delavida,0,0));
              juego_delavida.grid[1][1].num_vecinas());
        }
    } 
}
