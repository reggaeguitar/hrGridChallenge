using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrGridChallenge;

namespace TestRunner
{
    class TestRunner
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Solve(new StreamReader(@"input1.txt")));
        }
    }
}
