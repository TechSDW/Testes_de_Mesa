namespace TesteTM3
{/*
    class TesteMesa3_6
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Digite o valor presente: R$");
                double vp = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a taxa de juros: ");
                double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

                double vf = vp * Math.Pow((1 + taxa), 8.33);
                Console.WriteLine($"O valor futuro é R${vf:F2}");

                Console.Write("Deseja continuar? S (sim) ou N (não) = ");
                string resposta = Console.ReadLine();

                if (resposta == "N" || resposta == "n")
                {
                    continuar = false;
                }
            }
        }
    }*/
    /*
    class TesteMesa3_7
    {
        static void Main(string[] args)
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
    }*/
    /*
    class TesteMesa3_8
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor presente: R$");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Digite o período: ");
            double periodo = Convert.ToDouble(Console.ReadLine());

            ClassTM8 classe = new ClassTM8(vp, taxa);
            classe.calcularVf_Rend(periodo);
        }
    }*/
}