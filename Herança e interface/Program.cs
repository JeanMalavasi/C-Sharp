using System;
using Herança_e_interface.Funcionarios;
using Herança_e_interface.Sistemas;

namespace Herança_e_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
        }
        
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor diretor1 = new Diretor("222.222.222-22");
            diretor1.nome = "Roberta";
            diretor1.senha = "123";
            
            GerenteDeConta gerenteDeConta1 = new GerenteDeConta("444.444.444-44");
            gerenteDeConta1.nome = "Camila";
            gerenteDeConta1.senha = "123";

            ParceiroComercial parceiroComercial1 = new ParceiroComercial();
            parceiroComercial1.senha = "123";

            sistemaInterno.Logar(diretor1, "123");
            sistemaInterno.Logar(gerenteDeConta1, "123");
            sistemaInterno.Logar(parceiroComercial1, "123");
            
        }

        public static void calcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer designer1 = new Designer("111.111.111-11");
            designer1.nome = "Pedro";

            Diretor diretor1 = new Diretor("222.222.222-22");
            diretor1.nome = "Roberta";

            Auxiliar auxiliar1 = new Auxiliar("333.333.333-33");
            auxiliar1.nome = "Igor";

            GerenteDeConta gerenteDeConta1 = new GerenteDeConta("444.444.444-44");
            gerenteDeConta1.nome = "Camila";

            Desenvolvedor desenvolvedor1 = new Desenvolvedor("555.555.555-55");
            desenvolvedor1.nome = "Guilherme";

            gerenciadorBonificacao.Registrar(designer1);
            gerenciadorBonificacao.Registrar(diretor1);
            gerenciadorBonificacao.Registrar(auxiliar1);
            gerenciadorBonificacao.Registrar(gerenteDeConta1);
            gerenciadorBonificacao.Registrar(desenvolvedor1);

            Console.WriteLine($"Total de bonificação do mês: {gerenciadorBonificacao.getTotalBonificacao()}");
        }
    }
}
