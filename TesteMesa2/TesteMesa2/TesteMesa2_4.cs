using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa2
{
    class TesteMesa2_4
    {
        public static void Resp4()
        {
            Console.Write("Digite o valor presente: ");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            double vf = vp * Math.Pow((1 + taxa), 1);
            int i = 1;
            bool continuar = true;

            do
            {
                Console.WriteLine($"\n{i}º Mês:" +
                                  $"\nO valor futuro será R${vf:F2}" +
                                  $"\nO rendimento líquido será R${vf - vp:F2}");

                if (i == 5)
                {
                    vf -= 1000;
                    i -= 4;
                    vp = vf;
                    Console.WriteLine($"Você resgatou R$1000! Seu saldo agora é R$ {vf:F2}");
                }

                i++;
                vf = vp * Math.Pow((1 + taxa), i);

                Console.Write("Deseja continuar? S (sim) / N (não) = ");
                string resposta = Console.ReadLine();

                if (resposta == "N" || resposta == "n")
                {
                    continuar = false;
                }

            } while (continuar);
        }
    }
}