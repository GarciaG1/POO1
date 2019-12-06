using System;
using System.Collections.Generic;

namespace Stack
{

    public class Pila <T>
    {
        readonly int tamaño;
                 int apuntador=0;
                 T [] elementos;

        
        
        public Pila (int size)
        {
            tamaño = size;
            elementos =new T [tamaño];
        } 
        public void Push ( T elemento )
        {
            if (apuntador >= tamaño)
            throw new StackOverflowException();
            elementos[apuntador]= elemento;
            apuntador++;
            {

            }
        }
        public T Pop ()
        {
       
            
			if (apuntador >= 0)
			{
				return elementos[apuntador];
			}
			else
			{
				apuntador= 0;
				throw new InvalidOperationException("vacio" );
			}
        }
  }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> m = new Stack<string>();
			m.Push("Adios ");
			m.Push(" , ");
			m.Push("Hola");
			
			Console.WriteLine(m.Pop()+m.Pop()+m.Pop());
           
        }
    }
}
