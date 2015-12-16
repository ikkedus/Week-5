using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[20];
            var rnd = new Random();
            for (int index = 0; index < getallen.Length; index++)
            {
                getallen[index] = rnd.Next(150);
            }
            int i = 0;
            foreach (var getal in getallen)
            {
                Console.WriteLine("Element " + i + " is " + getal);
                i++;
            }
            int kleinste = getallen.Min(x => x);
            Console.WriteLine(kleinste + " is het kleinste getal");
            Console.WriteLine(kleinste+" komt "+getallen.Count(x=>x == kleinste)+ " voor");
            Console.ReadKey();
        }
    }
}
