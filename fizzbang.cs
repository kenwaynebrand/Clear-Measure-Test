using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Fizzbang
    {
        public Fizzbang()
        {

        }

        public string Start(int upper)
        {
            int foo = 0;
            string res = "";

            while (foo < upper)
            {
                bool FizzBang = false;
                foo++;
                if (foo % 3 == 0.0) { res += "fizz "; FizzBang = true; }
                if (foo % 5 == 0.0) { res += "bang "; FizzBang = true; }
                if (!FizzBang) { res += foo.ToString(); }
                if (foo != upper) { res += Environment.NewLine; }
            }
            return res;
        }

    }
}
