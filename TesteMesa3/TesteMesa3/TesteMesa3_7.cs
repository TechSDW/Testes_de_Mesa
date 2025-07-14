using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa3
{
    internal class TesteMesa3_7
    {
        public static void Resp7()
        {
            Console.Write("Digite o valor presente: R$");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            int i = 1;
            bool continuar = true;

            do
            {
                ClassTM7 classe = new ClassTM7(vp, taxa);
                classe.calcularVf_Rend(i);

                Console.WriteLine($"\n{i}º Mês:" +
                  $"\nO valor futuro será R${classe.getVf():F2}" +
                  $"\nO rendimento líquido será R${classe.getRend():F2}");

                if (i == 5)
                {
                    vp = classe.getVf() - 1000;
                    classe.setVf(vp);
                    i -= 5;
                    Console.WriteLine($"Você resgatou R$1000! Seu saldo agora é R$ {classe.getVf():F2}");
                }

                i++;

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
