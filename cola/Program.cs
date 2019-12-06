using System;
using System.Collections.Generic;

namespace Cola
{

    public class Cola <T>
    {
        readonly int tamaño;
                 int apuntador=0;
                 T [] elementos;

        
        
        public Cola (int size)
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
        if (apuntador > 0)
			{
				T elemento=elementos[0];
				for (int i=1; i < apuntador; i++)
				{
				    elementos[i-1]=elementos[i];					
				}
				apuntador--;
				return elemento;
			}
			else
			{
				apuntador = 0;
				throw new InvalidOperationException("Stack vacio");
			}
            
		
        }
  }
    class Program
    {
        static void Main(string[] args)
        {
            Cola<string> lista = new Cola<string>(7);
			lista.Push("Hola");
			lista.Push(" ");
			lista.Push("Que tal ,");
			lista.Push(" ");
			lista.Push("Como");
			lista.Push(" ");
			lista.Push("estas?");
			
			for(int i = 0; i < 7; i++) {
				Console.Write(lista.Pop());
            }
           
        }
    }
}
