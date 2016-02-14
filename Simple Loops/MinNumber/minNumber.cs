using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class minNumber
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 0; i < lineCount; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < minNumber) 
                {
                    minNumber = num;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
