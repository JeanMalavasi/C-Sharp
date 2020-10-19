using System;

namespace Variaveis
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            //INTEIRO
            int idade = 32;
            Console.WriteLine($"Idade: {idade}");
            //idade = idade + 10
            idade += 10;
            Console.WriteLine($"Idade: {idade}");

            //FLOAT
            double salario = 2000.50;
            Console.WriteLine($"Salario: {salario}");
            //Divisão para retornar com ponto flutuante
            salario = 15.0 / 2;
            Console.WriteLine($"Salario: {salario}");

            //CARACTERE E STRING
            char letra = 'a';
            Console.WriteLine($"Letra: {letra}");

            string texto = "Hello word!";
            Console.WriteLine($"Texto: {texto}");
        }
    }
}
