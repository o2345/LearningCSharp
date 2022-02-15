using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Два_бандита
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int a = Convert.ToInt32(parts[0]);
            int b = Convert.ToInt32(parts[1]);
            int g = b - 1;
            int l = a - 1;
            Console.WriteLine(g + " " + l);
        }
    }
}
