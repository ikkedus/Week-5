using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    internal class StudentModel
    {
        public int Cijfer { get; set; }
        public string Naam { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef het vaknaam:");
            string vaknaam = Console.ReadLine();
            Console.Write("geef het aantal studenten:");
            int aantalStudenten = int.Parse(Console.ReadLine());

            StudentModel[] studenten = new StudentModel[aantalStudenten];

            for (int i = 0; i < aantalStudenten; i++)
            {
                var stu = new StudentModel();
                Console.Write("geef Naam van "+(i + 1)+"e student : ");
                stu.Naam = Console.ReadLine();
                Console.Write("geef cijfer van : "+ stu.Naam);
                stu.Cijfer = int.Parse(Console.ReadLine());
                studenten[i] = stu;
            }

            Console.WriteLine("Het gemiddelde cijfer is : "+studenten.Average(x=>x.Cijfer));
            Console.WriteLine("Hoogste behaalde cijfer is : "+studenten.Max(x=>x.Cijfer));

            foreach (var student in studenten)
            {
                Console.WriteLine("student {0} heeft voor {1} het cijfer : {2}",student.Naam,vaknaam,student.Cijfer);
            }
            Console.ReadLine();
        }
    }
}
