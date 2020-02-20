using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //(5, 105, 3)
            int i;
            int aux = 105 - 5;
            aux = aux / 3;
            Console.WriteLine(aux);
            if (aux % 3 == 1)
            {
                Console.WriteLine("entrei");
                aux += 1;
            }
            i = aux;


            Console.WriteLine(i);
            Console.WriteLine(75/3+"");
            Console.ReadKey();
        }
    }
}
