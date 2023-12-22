using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22thdec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;//initial value
            int y = 30;

            x = x + y;
            y = x - y;
            x = x - y;

            //output the swapped values
            Console.WriteLine($"X ={x}");
            Console.WriteLine($"Y ={y}");
        }
    }
}
