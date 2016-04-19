using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = StringOut.GetOutput();
            Console.WriteLine(output);
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}
