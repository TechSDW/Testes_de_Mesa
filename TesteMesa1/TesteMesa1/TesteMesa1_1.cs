using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa1
{
    internal class TesteMesa1_1
    {
        public static void Resp1()
        {
            int a = 10;
            int b = 20;
            int c = (a + b) / 2;
            c = c - 40;
            int[] v = new int[4];

            Console.WriteLine($"a = {a}\n" +
                              $"b = {b}\n" +
                              $"c = {c}\n");

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = i;

                if (i == 3)
                {
                    Console.WriteLine($"O valor de v[3] = {a + b + c}");
                }
                else
                {
                    Console.WriteLine($"O valor de v[{i}] = 0");
                }
            }
        }
    }
}
