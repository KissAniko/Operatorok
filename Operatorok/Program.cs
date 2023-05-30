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


        int mod = kifejezesek.Count(sor => sor.Contains("mod"));

                       
                Console.WriteLine($"3.feladat: Kifejezések maradékos osztással: {mod}");

//---------------------------------------------------------------------------------------------------

            bool talalt = kifejezesek.Any(sor =>
            {
                string[] operandusok = sor.Split(' ');
                if (operandusok.Length == 3)
                {
                    int bal, jobb;
                    if (int.TryParse(operandusok[0], out bal) && int.TryParse(operandusok[2], out jobb))
                    {
                        return bal % 10 == 0 && jobb % 10 == 0;
                    }
                }
                return false;
            });
            Console.WriteLine($"4.feladat:  {(talalt ? "Van iylen kifejezés" : "Nincs ilyen kifejezés")}");
           





        }
    }
}