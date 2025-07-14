using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa2
{
    class TesteMesa2_5
    {
        public static void Resp5()
        {
            Console.WriteLine("\nExercício 5: Teste de Mesa 2");

            Console.Write("Digite o valor futuro: ");
            double vf = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Digite o período (em meses): ");
            int periodo = Convert.ToInt32(Console.ReadLine());

            double vp = vf / Math.Pow((1 + taxa), periodo);

            Console.WriteLine($"\n{periodo}º Mês:" +
                              $"\nO valor presente será R${vp:F2}");
        }
    }
}
