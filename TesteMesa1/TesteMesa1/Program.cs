namespace TesteMesa1
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
                        TesteMesa1_1.Resp1();
                        break;
                    case 2:
                        TesteMesa1_2.Resp2();
                        break;
                    case 3:
                        TesteMesa1_3.Resp3();
                        break;
                    default:
                        Console.WriteLine("Você não digitou um número correto");
                        break;
                }
            } while (numTeste != 0);
        }
    }
}