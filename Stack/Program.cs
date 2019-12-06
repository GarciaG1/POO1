using System; 


namespace Stack
{
    public class Pila <T>
    {
        readonly int tamaño;
                 int apuntador=0;
                T [] elementos;
        public Pila (int size)
        {
            tamaño=size;
            elementos=new T [tamaño];
        }
    
    public void Push ( T elemento)
    {
        if (apuntador <tamaño)
        elementos[apuntador]=elemento;
        apuntador++;
        {

        }
    }
    public T Pop ()
    {
        apuntador --;
        return elementos[apuntador];
    }
}
     
    
}
