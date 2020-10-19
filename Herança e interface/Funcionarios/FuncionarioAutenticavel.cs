
using Herança_e_interface.Sistemas;
namespace Herança_e_interface.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
    {
        public string senha { get; set; }
         public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}