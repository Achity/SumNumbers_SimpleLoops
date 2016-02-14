using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoewesSum
{
    class vowesSum
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            byte a = 1;
            byte e = 2;
            byte i = 3;
            byte o = 4;
            byte u = 5;
            int sum = 0;
            int suma = 0;
            int sume = 0;
            int sumi = 0;
            int sumo = 0;
            int sumu = 0;

            for (int vow = 0; vow < word.Length; vow++)
            {
                if (word[vow]=='a' )
                {
                    suma += a;
                }
                if (word[vow] == 'e' )
                {
                    sume += e;
                }
                if (word[vow] == 'i' )
                {
                    sumi += i;
                }
                if (word[vow] == 'o' )
                {
                    sumo += o;
                }
                if (word[vow] == 'u')
                {
                    sumu += u;
                }
            }
            sum = suma + sume + sumi + sumu + sumo;
            Console.WriteLine(sum);

        }
    }
}
