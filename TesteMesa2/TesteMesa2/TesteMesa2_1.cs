﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa2
{
    class TesteMesa2_1
    {
        public static void Resp1()
        {
            Console.WriteLine("\nExercício 1: Teste de Mesa 2");

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
    }
}