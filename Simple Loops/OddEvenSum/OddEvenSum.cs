using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int LineCount = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            int sum = 0;
            int diff = 0;

            for (int cnt = 0; cnt < LineCount; cnt++)
            {
                int num = int.Parse(Console.ReadLine());
                if (cnt%2==1)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }
            diff = Math.Abs(sumEven - sumOdd);
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes sum {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No diff {0}", diff);
            }

        }
    }
}
