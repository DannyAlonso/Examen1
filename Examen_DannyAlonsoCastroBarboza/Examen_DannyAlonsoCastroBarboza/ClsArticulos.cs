using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_DannyAlonsoCastroBarboza
{
    internal class ClsArticulos
    {
        int[] espacios = new int[5];

        protected int contador1 { get; set; }
        protected int codigo { get; set; }
        protected string nombre { get; set; }
        protected double precio { get; set; }

        public ClsArticulos() { }

        public ClsArticulos(int[] vector, int contador1, int codigo, string nombre, double precio)
        {

            this.contador1 = 0;
            this.codigo =0;
            this.nombre = "ND";
            this.precio = 0.0;
        }
        //¨******************************************************************************************************

        public void agregarArticulo()
        {
            for (int i = 0; i < espacios.Length; i++)
            {
                if (contador1 < 5)
                {
                    Console.WriteLine("Digite el codigo");
                    this.codigo = int.Parse(Console.ReadLine());              
                    Console.WriteLine("Digite el nombre");
                    this.nombre = Console.ReadLine();
                    Console.WriteLine("digite el precio");
                    this.precio = double.Parse(Console.ReadLine());
                    this.contador1++;
                }
                else
                {
                    Console.WriteLine("El vector se encuentra lleno");
                }
            }
        }
        //¨******************************************************************************************************
        public int buscar(int busca) 
        {
        
            Console.WriteLine("Digite el codigo");
            busca = int.Parse(Console.ReadLine());
            for (int i = 0; i < espacios.Length; i++)
            {
                if (espacios[i].GetTypeCode().Equals(busca))
                {
                    Console.WriteLine(codigo);
                   Console.WriteLine(nombre);
                   Console.WriteLine(precio);
                    return i;
                }
            }
            return 1;
        }


        //¨******************************************************************************************************

        public int consultarArticulo() {
            int busca = 0;
            int codigo = buscar(busca);
            if (codigo != -1)
            { 
           
                Console.WriteLine("El codigo:"+this.codigo);
                Console.WriteLine("El nombre del producto es:"+this.nombre);
                Console.WriteLine("El el presio es:"+this.precio);
                return espacios[codigo];
            }
            return 1; 
        }

        //¨******************************************************************************************************
        public int borrarArticulo()
        {
            int busca = 0;
            int codigo = buscar(busca);          
                if (codigo != -1)
                {
                    espacios[codigo] = 0;
                
                    Console.WriteLine("El codigo a sido eliminado");
                }
                else
                {
                    Console.WriteLine("El codigo no se encuentra registrad");
               
                }

           
            return 1;
        }


        //¨******************************************************************************************************
        public void imprimir() { 
        
        
        }


    }
}
