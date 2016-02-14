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

            for (int cnt = 0; cnt < LineCount; cnt++)
            {
                int num1L = int.Parse(Console.ReadLine());
                int num2L = int.Parse(Console.ReadLine());
                sumL = num1L + num2L;
            }
            Console.WriteLine(sumL);
        }
    }
}
