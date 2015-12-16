using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kleuters = new int[10];
            int[] kinderen = new int[10];
            int[] volwassenen = new int[10];
            bool _continue = true;
            while (_continue)
            {
                var newgetal = int.Parse(Console.ReadLine());

                if (newgetal != 0)
                {
                    if (newgetal < 4)
                    {
                        kleuters[] =newgetal;
                    }
                    else if (newgetal < 18)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    _continue = false;
                }
            }
        }
    }
}
