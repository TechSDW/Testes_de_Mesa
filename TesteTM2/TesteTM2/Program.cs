namespace Program
{/*
    class TesteMesa2_1
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor presente: ");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Digite o período (em meses): ");
            int periodo = Convert.ToInt32(Console.ReadLine());

            double vf = vp * Math.Pow((1 + taxa), periodo);

            Console.WriteLine($"\nO valor futuro será R${vf:F2}" +
                              $"\nO rendimento líquido será R${vf - vp:F2}");
        }
    }*/
    /*
    class TesteMesa2_2
    {
        static void Main(string[] args)
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
    }*/
    /*
    class TesteMesa2_3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor presente: ");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Digite o período (em anos): ");
            int periodo = Convert.ToInt32(Console.ReadLine());

            double vf = vp * Math.Pow((1 + taxa), periodo);

            Console.WriteLine($"\nO rendimento líquido será R${vf - vp:F2}");
        }
    }*/
    /*
    class TesteMesa2_4
    {
        static void Main(string[] args)
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
    }*/
    /*
    class TesteMesa2_5
    {
        static void Main(string[] args)
        {
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
    }*/
}