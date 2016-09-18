using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus_and_Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int strings;
            int stringLenght;
            string A = "A: ";
            string T = "T: ";
            string C = "C: ";
            string G = "G: ";
            int counterA=0;
            int counterT=0;
            int counterC=0;
            int counterG=0;
            bool enterAgain;
            do
            {
                Console.WriteLine("How much DNA strings you want to enter? n<=10");
                input = Console.ReadLine();
                strings = int.Parse(input);
            } while (strings > 10);
            List<string> listOFStrings = new List<string>(strings);
            do
            {
                stringLenght = 0;
                enterAgain = false;
                listOFStrings.Clear();
                for (int i = 0; i < strings; i++)
                {
                    Console.WriteLine("Enter DNA string (" + (i+1) + ")");
                    input = Console.ReadLine();
                    listOFStrings.Add(input);
                    if (stringLenght == 0) stringLenght = input.Length;
                }

                foreach (var item in listOFStrings)
                {
                    if (item.Length == stringLenght) enterAgain = false;
                    else
                    {
                        enterAgain = true;
                        Console.WriteLine("You entered wrong string legth somewhere, try again!");
                        break;
                    }
                }
            } while (enterAgain == true);

            for (int i = 0; i < stringLenght; i++)
            {
                counterA = 0;
                counterT = 0;
                counterC = 0;
                counterG = 0;
                foreach (var item in listOFStrings)
                {
                    if (item.ElementAt(i) == 'A') counterA++;
                    if (item.ElementAt(i) == 'T') counterT++;
                    if (item.ElementAt(i) == 'C') counterC++;
                    if (item.ElementAt(i) == 'G') counterG++;
                }
                A += counterA.ToString() + " ";
                T += counterT.ToString() + " ";
                C += counterC.ToString() + " ";
                G += counterG.ToString() + " ";
            }
            Console.WriteLine(A);
            Console.WriteLine(T);
            Console.WriteLine(C);
            Console.WriteLine(G);
            Console.WriteLine("Enter any button to quit");
            Console.ReadLine();
        }
    }
}
