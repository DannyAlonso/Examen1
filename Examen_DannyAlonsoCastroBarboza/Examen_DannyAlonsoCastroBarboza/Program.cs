using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_DannyAlonsoCastroBarboza
{
    internal class Program:ClsMenu
    {
        static void Main(string[] args)
        {

            ClsMenu menu = new ClsMenu();
            menu.menu();
            Console.Read();
        }
    }
}
