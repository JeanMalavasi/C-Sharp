using Herança_e_interface.Funcionarios;

namespace Herança_e_interface
{
    public class GerenciadorBonificacao
    {
        private double totalBonificação;

        //Metodos
        public void Registrar(Funcionario funcionario)
        {
           totalBonificação += funcionario.getBonificacao();
        }
        public double getTotalBonificacao()
        {
            return totalBonificação;
        }
    }
}