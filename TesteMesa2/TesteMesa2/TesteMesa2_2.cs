using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa2
{
    internal class TesteMesa2_2
    {
        public static void Resp2()
        {
            Console.Write("Digite o valor presente: ");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;


            for (int i = 1; i <= 6; i++)
            {
                double vf = vp * Math.Pow((1 + taxa), i);

                Console.WriteLine($"\n{i}º Mês:" +
                                  $"\nO valor futuro será R${vf:F2}" +
                                      $"\nO rendimento líquido será R${vf - vp:F2}");
            }
        }
    }
}
