using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_А_В
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int a = Convert.ToInt32(parts[0]);
            int b = Convert.ToInt32(parts[1]);
            Console.WriteLine(a + b);

        }
    }
}
