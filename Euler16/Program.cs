using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler16
{
    class Program
    {
        static int LIMIT = 1000;

        static void Main(string[] args)
        {
            List<int> digits = new List<int>();
            digits.Add(1);
            foreach(int n in Enumerable.Range(2, LIMIT))
            {
                int carry = 0;
                for(int i = 0; i < digits.Count; i++)
                {
                    int d = digits[i];
                    d = 2 * d + carry;
                    if(d < 10)
                    {
                        digits[i] = d;
                        carry = 0;
                    } else
                    {
                        digits[i] = d - 10;
                        carry = 1;
                    }
                }
                if (carry == 1)
                    digits.Add(1);
            }
            Console.WriteLine(digits.Sum());
            Console.ReadLine();
        }
    }
}
