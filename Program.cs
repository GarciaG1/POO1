using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ProyectoP4
{
    public class Producto
    {
        public string codigo{get; set;}
        public string descripcion {get; set;}
        public double precio {get; set;}
        public int departamento {get; set;}
        public int likes {get; set;}
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
  
            
    

  class ProductoDB
    {
        public List <Producto> productos = new List<Producto>();
        public const string dir = @"C:\Users\GABRIEL\desktop\github\p3\archivos\productos.bin";
        public const string path = dir + "Productos.bin";
       public static void EscribeProductosBIN(string archivo, List<Producto> productos)
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


        public static void EscribeProductosTXT(string archivo, List<Producto> productos)
        {
         try{
                FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter txtOut = new StreamWriter(fs);

                foreach(Producto p in productos)
                    {
            
                      txtOut.WriteLine("|{0}|{1}|{2}|{3}|{4}|",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
                    }
                        txtOut.Close();
            }
            catch(IOException e) {
				Console.WriteLine(" Hubo un error, el archivo no se pudo abrir ("+e.Message+")");
			} catch(Exception e) {
				Console.WriteLine(e.Message+")");
			}

        }
    
       public static List<Producto> LeeProductosBIN(string archivo)
        {
           
                 List<Producto> productos = new List<Producto>();  
                 FileStream fs = new FileStream(archivo , FileMode.Open, FileAccess.Read);
         
                 using( BinaryReader binIn = new BinaryReader(fs))
                {
            
                  while( binIn.PeekChar() != -1 ) // No lleguemos al final del archivo
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
                
                
                
            
            
        
           
        
              public static List<Producto> LeeProductosTXT(string archivo)
        { 
             
             List<Producto> productos = new List<Producto>();        
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
           
             
         public void GetDepartment(int Depto) {
			IEnumerable<Producto> pd =
				from p in productos
				where p.departamento == Depto
				select p;
			Console.WriteLine("Se mostraran los productos del departamento: "+Depto);
			foreach(Producto p in pd) {
				Console.WriteLine("{0},{1},{2},{3},{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
			}
		}
		public void OrdenarLikes() {
			IEnumerable<Producto> pd =
				from p in productos
				orderby p.likes
				select p;
			Console.WriteLine("Se mostraran los productos en orden de likes:");
			foreach(Producto p in pd) {
				Console.WriteLine("{0},{1},{2},{3},{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
			}
		}
        
           
		

    }
    class Program: ProductoDB
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
           ProductoDB lista=new ProductoDB();
            List<Producto> productos = new List<Producto>();

                productos.Add(new Producto("AQW", "Lapiz Azul w2 ", 12.23d, 1, 56));
				productos.Add(new Producto("AQE", "Lapiz Verde w3", 12.23d, 1, 33));
				productos.Add(new Producto("GEW", "Pluma Azul w4", 12.23d, 1, 20));
				productos.Add(new Producto("ERW", "Borrador ww2", 10.33d, 1, 100));
				productos.Add(new Producto("RWW", "Computadora", 5000.00d, 2, 200));
				productos.Add(new Producto("T3W", "Pantalla", 1200.00d, 2, 80));

				productos.Add(new Producto("GGP 723", "Camisa Rayada ", 500.00d, 1, 56));
				productos.Add(new Producto("RFD 435", "Camisa verde", 400.00d, 1, 33));
				productos.Add(new Producto("GDE 634", "Cinturon negro", 250.00d, 1, 20));
				productos.Add(new Producto("HJR 664", "Balon de futbol", 200.00d, 2, 100));
				productos.Add(new Producto("GFD 742", "jersey oficial chivas", 1500.00d, 2, 200));
				productos.Add(new Producto("CXZ 764", "Jersey oficial Seleccion Mexicana", 800.00d, 2, 80));
             
             lista.OrdenarLikes();
            lista.GetDepartment(2);
            FileStream fs = new FileStream(@"productos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);
            
            
            ProductoDB.EscribeProductosBIN(@"productos.bin",productos);
            Console.WriteLine("Archivo Grabado bin");
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





