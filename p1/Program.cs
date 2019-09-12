using System;

namespace p1
{

class Bici
{
    //Campos
    public string marca;
    public string color;
    public string type;
    public int velocities;
    public int size;

    //Metodos 
    public void print(){
        Console.WriteLine("Marca{0},Color{1}",marca,color);
    }

}
    class Program
    {
        static void Main(string[] args)
        {
            Bici bici = new Bici();
            bici.marca ="BiciMex";
            bici.color="Rojo";
           bici.print();
            //Console.WriteLine("HolaTec");
        }
    }
}

