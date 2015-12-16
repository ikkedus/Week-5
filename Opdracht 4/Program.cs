using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[20];

            for (int index = 0; index < 21;)
            {
                var getal = int.Parse(Console.ReadLine());
                if (getal != 0 && index > 20)
                {
                    getallen[index] = getal;
                }
                if (getal == 0)
                {
                    index = 21;
                }
                if (index < 21)
                {
                    index++;
                }
            }
            Console.WriteLine("geef de zoekwaarde : ");
            int zoekgetal = int.Parse(Console.ReadLine());

            int count = getallen.Count(x => x == zoekgetal);
            Console.WriteLine("de zoek waarde komt "+ count +" keer voor");
        }
    }
}
