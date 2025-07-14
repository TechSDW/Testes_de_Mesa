namespace TesteMesa2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numTeste;

            do
            {
                Console.Write("Digite o número do exercício (0 = sair): ");
                numTeste = Convert.ToInt32(Console.ReadLine());

                switch (numTeste)
                {
                    case 0:
                        break;
                    case 1:
                        TesteMesa2_1.Resp1();
                        break;
                    case 2:
                        TesteMesa2_2.Resp2();
                        break;
                    case 3:
                        TesteMesa2_3.Resp3();
                        break;
                    case 4:
                        TesteMesa2_4.Resp4();
                        break;
                    case 5:
                        TesteMesa2_5.Resp5();
                        break;
                    default:
                        Console.WriteLine("Você não digitou um número válido");
                        break;
                }
            } while (numTeste != 0);
        }
    }
}