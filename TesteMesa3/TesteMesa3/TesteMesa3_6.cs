using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa3
{
    internal class TesteMesa3_6
    {
        public static void Resp6()
        {
            Console.WriteLine("\nExercício 6: Teste de Mesa 3");

            bool continuar = true;

            while (continuar)
            {
                Console.Write("\nDigite o valor presente: R$");
                double vp = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a taxa de juros: ");
                double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

                DateTime periodo = DateTime.Now;
                Console.Write("Digite a quantidade de anos: ");
                periodo = periodo.AddYears(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Digite a quantidade de meses: ");
                periodo = periodo.AddMonths(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Digite a quantidade de dias: ");
                periodo = periodo.AddDays(Convert.ToInt32(Console.ReadLine()));

                double vf = vp * Math.Pow((1 + taxa), (periodo - DateTime.Now).TotalDays / 30 - 0.1);
                Console.WriteLine($"\nO valor futuro é R${vf:F2}");

                Console.Write("Deseja continuar? S (sim) ou N (não) = ");
                string resposta = Console.ReadLine();

                if (resposta == "N" || resposta == "n")
                {
                    continuar = false;
                }
            }
        }
    }
}
