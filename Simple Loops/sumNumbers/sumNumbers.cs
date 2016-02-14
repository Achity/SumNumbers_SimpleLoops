using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumbers
{
    class sumNumbers
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i<lineCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
