using Herança_e_interface.Sistemas;
namespace Herança_e_interface.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        //Construtor pegando parametros da mae(base)
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
            
        }
    
        //Metodos
        public override double getBonificacao()
        {
            return salario * 0.25;
        }
        public override void aumentarSalaario()
        {
            salario *= 1.05;
        } 
    }
}