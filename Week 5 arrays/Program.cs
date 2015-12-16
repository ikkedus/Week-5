using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_arrays
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] getallen = new int[20];
            var rnd = new Random();
            for (int index = 0; index < getallen.Length; index++)
            {
                getallen[index] = rnd.Next(200);
                Console.WriteLine("Element "+index+" is "+ getallen[index]);
            }
            
            double avg = getallen.Average(x => x);
            Console.WriteLine("het gemiddelde is "+avg);
            int i = 0;
            foreach (var getal in getallen)
            {
                Console.WriteLine("Verschil gemiddelde en element "+i+" is "+Math.Abs(getal - avg));
                i++;
            }
            Console.ReadKey();
        }
    }
}
