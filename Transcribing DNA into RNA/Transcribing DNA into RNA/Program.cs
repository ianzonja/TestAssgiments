using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcribing_DNA_into_RNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter DNA string (only letters 'T', 'C', 'A' and 'G')");
            Console.WriteLine("'T' stands for Thymine, 'C' stands for Guanine, 'A' stands for Adenine and 'G' stands for Guanine");
            input = Console.ReadLine();
            input = input.Replace('T', 'U');
            Console.WriteLine("Transcribed DNA into RNA: " + input);
            Console.WriteLine("Enter any key");
            Console.ReadLine();
        }
    }
}
