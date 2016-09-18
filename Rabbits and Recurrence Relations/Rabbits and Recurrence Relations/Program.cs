using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbits_and_Recurrence_Relations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int n;
            int k;
            int result;
            bool badInput;
            do
            {
                badInput = false;
                Console.WriteLine("Insert number of months (n<=40) :");
                input = Console.ReadLine();
                if (int.TryParse(input, out n) == false) badInput = true;
                Console.WriteLine("Insert number of rabbit pairs (k<=5) :");
                input = Console.ReadLine();
                if (int.TryParse(input, out k) == false) badInput = true;
                if (badInput == true) Console.WriteLine("Bad input made. Try again!");
            } while (badInput == true || n > 40 || k > 5);
            result = LogicClass.FibbonacciOrder(n, k);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Press any key to finish");
            Console.ReadLine();
        }
    }
}
