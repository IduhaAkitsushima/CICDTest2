using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace CICDTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            int result = class1.Add(2, 3);
            Console.WriteLine($"The result of adding 2 and 3 is: {result}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}