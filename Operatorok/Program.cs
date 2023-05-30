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

        static List<string> kifejezesek;
        static void Main(string[] args)

        { // Ellenőrzés:
            /*     var sorok = File.ReadAllLines("kifejezesek.txt");
                 foreach (var sor in sorok)
                 {
                     Console.WriteLine(sor);
                 }
            */


            List<string> kifejezesek = new List<string>();
            kifejezesek = File.ReadAllLines("kifejezesek.txt")                            
                             .ToList();

//---------------------------------------------------------------------------------------------------
           
            Console.WriteLine($" 2.feladat: Kifejezések száma:{kifejezesek.Count()}");

//----------------------------------------------------------------------------------------------------

            Console.WriteLine($"Kifejezéesek maradékos osztással: {}");

        }
    }
}