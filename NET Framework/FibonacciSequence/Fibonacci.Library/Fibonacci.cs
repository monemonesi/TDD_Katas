using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Library
{
    public class Fibonacci
    {
        public static int GetValue(int position)
        {
            List<int> fibonacciSeq = new List<int>();

            if (position <= 1)
            {
                return position;
            }
            else
            {

                fibonacciSeq.Add(0);
                fibonacciSeq.Add(1);
                for (int i = 2; i <= position; i++)
                {
                    int numToAdd = fibonacciSeq[i - 1] +
                        fibonacciSeq[i - 2];
                    fibonacciSeq.Add(numToAdd);
                }

                return fibonacciSeq[position];
            }
            
        }
    }
}
