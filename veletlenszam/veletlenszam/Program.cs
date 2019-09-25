using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veletlenszam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez egy véletlen számokat generáló forráskód. Kérem növekvő sorrendben adja meg a számokat.");
            Console.WriteLine("Kérem adja meg az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            Random veletlen = new Random();

            Console.WriteLine("A generalt szamok: {0}, {1}, {2}.",
               veletlen.Next(szam1, szam2),
               veletlen.Next(szam1, szam2),
               veletlen.Next(szam1, szam2));

            Console.ReadLine();

        }
    }
}
