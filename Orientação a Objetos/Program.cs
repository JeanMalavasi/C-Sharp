using System;

namespace Orientação_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jeito 1
            ContaCorrente conta1 = new ContaCorrente(1,1);
            conta1.titular = new Cliente();
            conta1.titular.nome = "Gabriela";
            conta1.titular.cpf = "434.562.878-20";
            conta1.titular.profissao = "Desenvolvedora C#";
            conta1.setNumeroAgencia(836);
            conta1.numero = 863452;
            conta1.setSaldo(100);
            //Jeito 2
            Cliente cliente2 = new Cliente();
            cliente2.nome = "Pedro";
            cliente2.cpf = "111.111.111-11";
            cliente2.profissao = "Desenvolvedor Java";
            ContaCorrente conta2 = new ContaCorrente(1,1);
            conta2.titular = cliente2;
            conta2.setNumeroAgencia(0);
            conta2.numero = 1;
            conta2.setSaldo(0);

            Console.WriteLine($"titular Gabriela: {conta1.titular.nome}");
            Console.WriteLine($"Agencia Gabriela: {conta1.getNumeroAgencia()}");
            Console.WriteLine($"numero Gabriela: {conta1.numero}");
            Console.WriteLine($"Saldo Gabriela: {conta1.getSaldo()}");

            Console.WriteLine($"titular Gabriela: {conta2.titular.nome}");
            Console.WriteLine($"Agencia Gabriela: {conta2.getNumeroAgencia()}");
            Console.WriteLine($"numero Gabriela: {conta2.numero}");
            Console.WriteLine($"Saldo Gabriela: {conta2.getSaldo()}");

            //Verifica se foi realizado o saque;
            bool resultadoSaque = conta1.Sacar(50);
            Console.WriteLine($"Sacado?: {resultadoSaque}");
            //Realiza deposito
            conta1.Depositar(200);
            Console.WriteLine($"Saldo Gabriela: {conta1.getSaldo()}");
            //Realiza transferencia
            conta1.Transferir(100, conta2);
            Console.WriteLine($"Saldo Gabriela: {conta1.getSaldo()}");
            Console.WriteLine($"Saldo Pedro: {conta2.getSaldo()}");

            Console.WriteLine($"Agencia Gabriela: {conta1.getNumeroAgencia()}");
            Console.WriteLine($"Agencia Pedro: {conta2.getNumeroAgencia()}");

            Console.WriteLine($"Total de contas: {ContaCorrente.getTotalDeContas()}");
        }
    }
}