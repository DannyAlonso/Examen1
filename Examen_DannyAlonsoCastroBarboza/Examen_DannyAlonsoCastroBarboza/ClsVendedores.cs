using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_DannyAlonsoCastroBarboza
{
    internal class ClsVendedores
    {
        public String nombre { get; set; }
        public int codigo { get; set; }

        public ClsVendedores() { }
        public ClsVendedores(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }

        private static Dictionary<int, ClsVendedores> vendedores = new Dictionary<int, ClsVendedores>()
        {
            {1,new ClsVendedores("jose",21)},
            {2,new ClsVendedores("Pablo",33)}

        }; 

         

            public  void listadoVendedores()
            {

      
           
            foreach (KeyValuePair<int, ClsVendedores> cod in vendedores)
            {
                Console.WriteLine($"llave:{cod.Key} codigo:{cod.Value.codigo} nombre: {cod.Value.nombre}");
            }


            Console.WriteLine("Digite el codigo del vendedor");
              int cdVen = int.Parse(Console.ReadLine());
             
            int resultado ;
            /*if (vendedores.TryGetValue(cdVen, out resultado))
            {

                Console.WriteLine($"El codigo {resultado} del vendedor si esxiste");
            }       
            else {
                Console.WriteLine($"El codigo {resultado} del vendedor no existe ");
            }*/

        }


     
        }
     
    
    
    class vendedor1:ClsInterfaces {
        public String vendedor { get; set; }

        public vendedor1(string vendedor)
        {
            this.vendedor = "Jose";
        }
        public void ventasContado() {
            Console.WriteLine("ventas al contado");        

        }


    }
    
    
    
    
    
    class vendedor2 {
        public String vendedor { get; set; }
        public vendedor2(string vendedor)
        {
            this.vendedor = "Pablo";
        }
        public void ventasCredito()
        {
            Console.WriteLine("ventas de credito");

        }
    }
    
}
