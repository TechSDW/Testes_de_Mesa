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
            Console.WriteLine("\nExercício 7: Teste de Mesa 3");

            Console.Write("Digite o valor presente: R$");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Digite o período (em meses): ");
            int periodo = Convert.ToInt32(Console.ReadLine());

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
                    double resgate = 0;

                    do
                    {
                        Console.Write("Digite um valor para resgatar: R$");
                        resgate = Convert.ToDouble(Console.ReadLine());

                        if (resgate <= classe.getVf())
                        {
                            vp = classe.getVf() - resgate;
                            classe.setVf(vp);
                            Console.WriteLine($"Você resgatou R${resgate} com sucesso! Seu saldo agora é R$ {classe.getVf():F2}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Você não possui essa quantia, digite outro valor.\n");
                        }
                    } while (resgate > classe.getVf());
                }

                i++;

                Console.Write("Deseja continuar? S (sim) / N (não) = ");
                string resposta = Console.ReadLine();

                if (resposta == "N" || resposta == "n")
                {
                    continuar = false;
                }

            } while (continuar && i <= periodo);
        }
    }
}
