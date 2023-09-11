using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Inicijalno_ponavljanje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši te URL adresu: ");
            string url = Console.ReadLine();
            if(url.StartsWith("www.") && url.EndsWith(".hr"))
            {
                Console.WriteLine("URL adresa je u ispravnom formatu");
            }
            else
            {
                Console.WriteLine("URL adresa nije u ispravnom formatu");
            }
            Console.ReadKey();
        }
    }
}
