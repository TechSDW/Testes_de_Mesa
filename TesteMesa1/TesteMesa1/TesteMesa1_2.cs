using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa1
{
    internal class TesteMesa1_2
    {

        public static void Resp2()
        {
            int a = 2;
            int[] v = new int[4];

            Console.WriteLine($"a = {a}\n");

            while (a < 6)
            {
                v[a - 2] = 10 * a;
                Console.WriteLine($"O valor de v[{a - 2}] = {v[a - 2]}");
                a++;
            }

            Console.WriteLine($"\nO programa parou pois a = {a}");
            
        }
    }
}
