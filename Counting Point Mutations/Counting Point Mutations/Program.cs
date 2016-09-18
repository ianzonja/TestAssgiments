using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Point_Mutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            string input2;
            int counter = 0;
            do
            {
                Console.WriteLine("Enter 2 DNA strings of equeal length (only letters 'T', 'C', 'A' and 'G')");
                Console.WriteLine("'T' stands for Thymine, 'C' stands for Guanine, 'A' stands for Adenine and 'G' stands for Guanine");
                input1 = Console.ReadLine();
                input2 = Console.ReadLine();
                if (input1.Length != input2.Length) Console.WriteLine("Inputs are not with same length, try again!");
            } while (input1.Length != input2.Length);

            for(int i = 0; i < input1.Length; i++)
            {
                if (input1.ElementAt(i) != input2.ElementAt(i)) counter++;
            }

            Console.WriteLine("Point mutations: " + counter);
            Console.WriteLine("Enter any button to exit");
            Console.ReadLine();
        }
    }
}
