using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LandRsum
    {
        static void Main(string[] args)
        {
            int LineCount = int.Parse(Console.ReadLine());
            int sumL = 0;
            int sumR = 0;
            int diff = 0;

            for (int cnt = 0; cnt < LineCount; cnt++)
            {
                int numL = int.Parse(Console.ReadLine());
                sumL += numL;
            }
            for (int j = 0; j < LineCount; j++)
            {
                int numR = int.Parse(Console.ReadLine());
                sumR += numR;
            }
            diff = Math.Abs(sumL - sumR);
            if (sumL == sumR)
            {
                Console.WriteLine("Yes sum {0}", sumL);
            }
            else
            {
                Console.WriteLine("No diff {0}", diff);
            }
        }
    }
}
