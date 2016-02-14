using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 0; i < lineCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num>maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
