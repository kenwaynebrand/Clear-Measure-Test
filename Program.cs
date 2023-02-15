using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Fizzbang fb = new Fizzbang();
            Console.Write(fb.Start(100));

            Console.ReadKey();
        }
    }


}
