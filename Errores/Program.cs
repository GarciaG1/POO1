using System;

namespace Errores
{
    class NegativeIntegerException:Exception
    {
        public NegativeIntegerException():base("No debes capturar numeros negativos")
        {

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {   //sites
            
           
           int valor;
         
            try
            {  
               
                
                    Console.WriteLine("Captura un entero positivo ");
                    //string captura = Console.ReadLine();
                    // int valor =int.Parse(captura);
                    //Console.WriteLine("El valor es {0}",valor);
                    valor = int.Parse(Console.ReadLine());
                
                    if(valor <0)
                        throw new NegativeIntegerException();
                                         
                    Console.WriteLine("El valor es: {0}",valor);
                
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Hubo un error");
                Console.WriteLine( e.Message);
             
            }
         finally {
              Console.WriteLine("Finally");
         }
            
        }
    }
}
