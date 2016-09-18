using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementing_a_Strand_of_DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string result = "";
            int t = 0;
            int c = 0;
            int a = 0;
            int g = 0;
            int badInputs = 0;
            Console.WriteLine("Enter DNA string (only letters 'T', 'C', 'A' and 'G')");
            Console.WriteLine("'T' stands for Thymine, 'C' stands for Guanine, 'A' stands for Adenine and 'G' stands for Guanine");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
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
            
            for(int i = 0; i < t; i++)
            {
                result += "A";
            }

            for(int i = 0; i < g; i++)
            {
                result += "C";
            }

            for (int i = 0; i < c; i++)
            {
                result += "G";
            }

            for (int i = 0; i < a; i++)
            {
                result += "T";
            }
            Console.WriteLine("Complemented strand of DNA: " + result);
            Console.WriteLine("Enter any key");
            Console.ReadLine();
        }
    }
}
