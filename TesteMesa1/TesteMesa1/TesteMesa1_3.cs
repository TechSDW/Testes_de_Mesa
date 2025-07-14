using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa1
{
    internal class TesteMesa1_3
    {
        public static void Resp3()
        {
            int a = 7;
            int b = a - 6;
            int[] v = new int[4];

            Console.WriteLine($"a = {a}\n" +
                              $"b = {b}\n");

            while (b < a)
            {
                Console.WriteLine($"v[{b}] = {b + a}");
                b = b + 2;
            }

            Console.WriteLine($"\nO programa parou pois b = {b}");
        }
    }
}