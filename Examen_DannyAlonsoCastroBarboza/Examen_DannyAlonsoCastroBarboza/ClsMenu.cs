using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Examen_DannyAlonsoCastroBarboza
{
    internal class ClsMenu
    {
        private ClsArticulos clsArticulos;
        private ClsCategorias clsCategorias;
        private ClsCategorias.categoria1 categoria;
        private ClsCategorias.categoria2 categoria2;
        private ClsCategorias.categoria3 categoria3;
        private ClsVendedores clsVendedores;


        public ClsMenu()
        {
            clsArticulos = new ClsArticulos();
            clsCategorias = new ClsCategorias();
            categoria = new ClsCategorias.categoria1();
            categoria2 = new ClsCategorias.categoria2();
            categoria3 = new ClsCategorias.categoria3();
            clsVendedores = new ClsVendedores();
        }


        public  void menu()
        {
            int opcion = 0;
            ClsArticulos clsArticulos = new ClsArticulos();
            do {       
            Console.WriteLine(" ++++Bienvenido a la venta de articulos++++\nDigite una opcion:\n1-Articulos\n2-Facturacion\n3-Reporte\n4-Salir");
            opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Digite la opcion que decea:\n1-Agregar\n2-Borrar\n3-Consultar");
                        int opcion2 = int.Parse(Console.ReadLine());
                        switch (opcion2)
                        {
                            case 1:
                                clsArticulos.agregarArticulo();
                                break;
                            case 2:
                                clsArticulos.borrarArticulo();
                                break;
                            case 3:
                                clsArticulos.consultarArticulo();
                                break;
                        }
                        break;
                   
                    case 2:
                        clsCategorias.promocion();
                        clsCategorias.listadoCategorias();
                        categoria.promocion();
                        categoria2.promocion();
                        categoria3.promocion();
                        break;
                    case 3:
                        clsVendedores.listadoVendedores();
                        clsCategorias.promocion();

                        break;
                    case 4:
                        Console.WriteLine("Saliendo de la aplicacion");
                        break;

                } 
            } while (opcion !=4);


        }
    }
}
