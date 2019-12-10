using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Proyectop5
{
    //Clase producto
    public class Producto
    {
        public string codigo{get; set;}
        public string descripcion {get; set;}
        public double precio {get; set;}
        public int departamento {get; set;}
        public int likes {get; set;}
        //Constructor
        public Producto(string c,string d,double p, int dep, int l=0)
        {
            codigo=c;
            descripcion=d;
            precio=p;
            departamento=dep;
            likes=l;
        }

    
        
    public Producto(){}
    }
  
            
    
 //Clase productoDB
  class ProductoDB
    {

        public List <Producto> productos = new List<Producto>();
        //Direccion C:\Users\Informatica\desktop\github\p5\archivos\productos.bin
        public const string dir = @"C:\Users\Informatica\desktop\github\p5";
        //Ruta
        public const string path = dir + "Productos.bin";
        
       public  void EscribeProductosBIN(string archivo, List<Producto> productos)
        {
        try {
                //abre el archivo
                FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
                //escribre en el archivo
                BinaryWriter binOut = new BinaryWriter(fs);
                foreach(Producto p in productos)
                {
            
                    binOut.Write(p.codigo);
                    binOut.Write(p.descripcion);
                    binOut.Write(p.precio);
                }

                   binOut.Close();
           }
           catch(IOException e) {
				Console.WriteLine(" Hubo un error, el archivo no se pudo abrir ("+e.Message+")");
			} catch(Exception e) {
				Console.WriteLine(e.Message+")");
			}
        }


        public  void EscribeProductosTXT(string archivo, List<Producto> productos)
        {
         try{
                FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter txtOut = new StreamWriter(fs);

                foreach(Producto p in productos)
                    {
            
                      txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
                    }
                        txtOut.Close();
            }
            catch(IOException e) {
				Console.WriteLine(" Hubo un error, el archivo no se pudo abrir ("+e.Message+")");
			} catch(Exception e) {
				Console.WriteLine(e.Message+")");
			}

        }
    
       public  List<Producto> LeeProductosBIN(string archivo)
        {
           
                 List<Producto> productos = new List<Producto>();
                 //Clase que crea y lee el archivo
                 //FileStream Te provee acceso a entrada y salida del archivo 
                 FileStream fs = new FileStream(archivo , FileMode.Open, FileAccess.Read);
                           //
                 using( BinaryReader binIn = new BinaryReader(fs))
                {
            
                  while( binIn.PeekChar() != -1 ) 
                   {
                    Producto producto = new Producto();
                    producto.codigo = binIn.ReadString();
                    producto.descripcion = binIn.ReadString();
                    producto.precio = binIn.ReadDouble();
                      
                    productos.Add( producto);

                   }
                    binIn.Close();
                }
                return productos;
                
              }

              public  List<Producto> LeeProductosTXT(string archivo)
        { 
             
             List<Producto> productos = new List<Producto>();      
             //streamreader  
            using( StreamReader sr = new StreamReader(archivo))
            {
                    string line = "";
                while(  (line =  sr.ReadLine()) != null ) // No lleguemos al final del archivo
                {
                    string[] columnas = line.Split('|');
            
                    productos.Add( new Producto(columnas[0],columnas[1], Double.Parse( columnas[2]), int.Parse(columnas[3]),int.Parse(columnas[4])) );

                 }

            }
               return productos;
        }
           
             //Metodo que imprime solo las del departamento establecido
         public void GetDepto(int Depto) {
			IEnumerable<Producto> pd =
				from p in productos
				where p.departamento == Depto
				select p;
			Console.WriteLine("productos del departamento: "+Depto);
			foreach(Producto p in pd) {
				Console.WriteLine("{0},{1},{2},{3},{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
			}
		}
        //Metodo que ordena los productos por likes
		public void Likes() {
			IEnumerable<Producto> pd =
				from p in productos
				orderby p.likes
				select p;
			Console.WriteLine("Productos en orden de likes:");
			foreach(Producto p in pd) {
				Console.WriteLine("{0},{1},{2},{3},{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
			}
		}


    }
    class Program
    {
        static void Main(string[] args)
        {
           
           
                /*
           if (File.Exists(path))
           {
               Console.WriteLine("El archivo (Productos.bin) ya existe,desea eliminarlo?(s/n)");
               char n=char.Parse(Console.ReadLine());
               if (n=='s')
               {
                File.Delete(path);
               }
               
           }
           else { Directory.CreateDirectory(dir);}
            if(!Directory.Exists(dir))
           {
                Directory.CreateDirectory(dir);
           }
           */
           
           ProductoDB lista =new ProductoDB();
            List<Producto> productos = new List<Producto>();

                lista.productos.Add(new Producto("AQW", "Lapiz Azul w2 ", 12.23d, 1,56));
				lista.productos.Add(new Producto("AQE", "Lapiz Verde w3", 12.23d, 1, 33));
				lista.productos.Add(new Producto("GEW", "Pluma Azul w4", 12.23d, 1, 20));
				lista.productos.Add(new Producto("ERW", "Borrador ww2", 10.33d, 1, 100));
				lista.productos.Add(new Producto("RWW", "Computadora", 5000.00d, 2, 200));
				lista.productos.Add(new Producto("T3W", "Pantalla", 1200.00d, 2, 80));

				lista.productos.Add(new Producto("GGP 723", "Camisa Rayada ", 500.00d, 1, 56));
				lista.productos.Add(new Producto("RFD 435", "Camisa verde", 400.00d, 1, 33));
				lista.productos.Add(new Producto("GDE 634", "Cinturon negro", 250.00d, 1, 20));
				lista.productos.Add(new Producto("HJR 664", "Balon de futbol", 200.00d, 2, 100));
				lista.productos.Add(new Producto("GFD 742", "jersey oficial chivas", 1500.00d, 2, 200));
				lista.productos.Add(new Producto("CXZ 764", "Jersey oficial Seleccion Mexicana", 800.00d, 2, 80));
             
             lista.Likes();
            lista.GetDepto(2);
            FileStream fs = new FileStream(@"productos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);
            
            
            lista.EscribeProductosBIN(@"productos.bin",productos);
            Console.WriteLine("Archivo Grabado bin");
            Console.WriteLine("Pulse cualquier letra para grabar un archivo txt:");
            Console.ReadKey();

            foreach(Producto p in productos)
            {
            
             txtOut.WriteLine("{0}|{1}|{2}", p.codigo,p.descripcion,p.precio);
            }
            
            txtOut.Close();
            
            Console.WriteLine("Archivo Grabado txt");
            Console.ReadKey();

        

            /*
            foreach(Producto p in productos_leidos)
             {
            
             Console.WriteLine("{0} {1} {2}"), p.codigo,p.descripcion,p.precio);
            
              }
              */
       }
        
    }
}