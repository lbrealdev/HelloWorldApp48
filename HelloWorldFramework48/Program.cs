using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldFramework48
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String hostname = Environment.MachineName;

            Console.WriteLine($"Hello World {hostname}!");

            Console.ReadLine();
        }
    }
}
