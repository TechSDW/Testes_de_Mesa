using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa3
{
    internal class TesteMesa3_8
    {
        public static void Resp8()
        {
            Console.Write("Digite o valor presente: R$");
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

            ClassTM8 classe = new ClassTM8(vp, taxa);
            classe.calcularVf_Rend((periodo - DateTime.Now).TotalDays / 30 - 0.1);

            Console.WriteLine($"\nO valor futuro será R${classe.getVf():F2}" +
                              $"O Rendimento será R${classe.getRend():F2}");
        }
    }
}