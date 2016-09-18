using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_DNA_Nucleotides
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int t = 0;
            int c = 0;
            int a = 0;
            int g = 0;
            int badInputs = 0;
            Console.WriteLine("Enter DNA string (only letters 'T', 'C', 'A' and 'G')");
            Console.WriteLine("'T' stands for Thymine, 'C' stands for Guanine, 'A' stands for Adenine and 'G' stands for Guanine");
            input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (input.ElementAt(i) == 'T') t += 1;
                else if (input.ElementAt(i) == 'C') c += 1;
                else if (input.ElementAt(i) == 'A') a += 1;
                else if (input.ElementAt(i) == 'G') g += 1;
                else
                {
                    badInputs += 1;
                }
            }
            Console.WriteLine("T: " + t + " C: " + c + " A: " + a + " G: " + g);
            if (badInputs > 0) Console.WriteLine("You entered " + badInputs + " bad letters (or lowercase characters used).");
            Console.WriteLine("Enter any key");
            Console.ReadLine();
        }
    }
}
