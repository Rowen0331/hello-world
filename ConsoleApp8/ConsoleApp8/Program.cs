using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new List<int> { 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(var i in test.Skip(4).Take(2))
            {
                Console.WriteLine("Result : " + i);
            }
        }
    }
}
