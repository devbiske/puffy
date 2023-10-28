using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace puffy
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.Title = "root@puffy";

            menu.wLogo();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Loading ...");

            menu.Menumain();
            

            Console.ReadLine();
        }
    }
}
