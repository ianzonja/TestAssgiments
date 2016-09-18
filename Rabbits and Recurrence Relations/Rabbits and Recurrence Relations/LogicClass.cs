using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbits_and_Recurrence_Relations
{
    static class LogicClass
    {
        public static int FibbonacciOrder(int n, int k)
        {
            int helper = 0;
            int firstNum = 0;
            int secondNum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    helper += i;
                    firstNum = i;
                }
                else if (i == 1)
                {
                    helper += i;
                    secondNum = i;
                }
                else
                {
                    helper = firstNum * k + secondNum;
                    firstNum = secondNum;
                    secondNum = helper;
                }

            }
            return helper;
        }
    }
}
