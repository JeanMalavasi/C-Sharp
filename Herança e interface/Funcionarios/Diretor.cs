using Herança_e_interface.Sistemas;
namespace Herança_e_interface.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        //Construtor pegando parametros da mae(base)
        public Diretor(string cpf) : base(cpf, 5000)
        {
            
        } 
        //Metodos
        public override double getBonificacao()
        {
            return salario *= 0.5;
        }
        public override void aumentarSalaario()
        {
            salario *= 1.15;
        }
        
    }
}