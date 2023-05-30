using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sorok = File.ReadAllLines("kifejezesek.txt");
            foreach (var sor in sorok)
            {
                Console.WriteLine(sor);
            }

        }
    }
}
