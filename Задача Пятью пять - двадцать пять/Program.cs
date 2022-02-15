using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Пятью_пять___двадцать_пять
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            string n = Convert.ToString(a * a);
            Console.WriteLine(n);
        }
    }
}
