using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Журавлики
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine());
            int x = s / 6;
            int k = 4 * x;
            Console.WriteLine(x + " " + k + " " + x);
        }
    }
}
