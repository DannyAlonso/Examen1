using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_DannyAlonsoCastroBarboza
{
    internal class ClsCategorias
    {
        int lista = 0;
        public virtual void promocion()
        {
            Console.WriteLine("++++ Descuentos y promociones ++++");


            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Sort();

            foreach (var categorias in lista)
            {
                Console.WriteLine("Categoria: "+categorias);

            }
        }
        //¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
        public void listadoCategorias()
        {
            bool existe;
            bool existe1;

            int cate = 0;
           Console.WriteLine("\nDigite el tipo de categoria del vendedor ");
            cate = int.Parse(Console.ReadLine());

            existe = cate == 1;
            existe = cate == 2;
            existe = cate == 3;

          
            if (existe == true)
            {
                Console.WriteLine("La categoria del vendedor existe");
            }
            else {
                Console.WriteLine("La categoria del vendedor NO existe");


            }





        }
        //¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


        public class categoria1 : ClsCategorias
        {
            public override void promocion()
            {
                Console.WriteLine("“Descuento de 15%”");
            }
        }
        public class categoria2 : ClsCategorias
        {
        public override void promocion()
            {
                Console.WriteLine("“Promoción dos por 1”");
            }
        }
        public class categoria3 : ClsCategorias
        {

            public override void promocion()
            {
                Console.WriteLine("“Todo a mitad de precio”");
            }

        }
        //¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨


    }
}
