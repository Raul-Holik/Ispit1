using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak zamijeniti znakom '_'.

            string znak;

            Console.WriteLine("Upiši niz znakova sa razmacima. ");
            znak =(Console.ReadLine());

            Console.WriteLine(znak.Replace(" ", "_"));

            Console.ReadKey();

        }
    }
}
