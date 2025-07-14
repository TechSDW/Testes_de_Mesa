namespace TesteMesa3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numTeste;

            do
            {
                Console.Write("Digite o número do execício (0 = sair): ");
                numTeste = Convert.ToInt32(Console.ReadLine());

                switch (numTeste)
                {
                    case 0:
                        break;
                    case 6:
                        TesteMesa3_6.Resp6();
                        break;
                    case 7:
                        TesteMesa3_7.Resp7();
                        break;
                    case 8:
                        TesteMesa3_8.Resp8();
                        break;
                    default:
                        Console.WriteLine("Você não digitou um número válido");
                        break;
                }
            } while (numTeste != 0);
        }
    }
}