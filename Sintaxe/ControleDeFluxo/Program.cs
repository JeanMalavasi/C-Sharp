using System;

namespace ControleDeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF
            int idade = 15;
            bool acompanhado = true;
            if (idade > 18 || acompanhado)
                Console.WriteLine("Permitido.");
            else{
                Console.WriteLine("Negado.");
            }

            //WHILE
            double investimento = 1000;
            int meses = 1;           
            while (meses <= 12)
            {
                investimento += investimento * 0.0036;
                Console.WriteLine($"Investimento: {investimento}");
                meses++;
            }

            //FOR
            investimento = 1000;
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento += investimento * 0.0036;
                Console.WriteLine($"Investimento: {investimento}");
            }
        }
    }
}