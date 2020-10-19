namespace Herança_e_interface.Funcionarios
{
    public class Designer : Funcionario
    {
        //Construtor pegando parametros da mae(base)
        public Designer(string cpf) : base(cpf, 3000)
        {
        } 
        //Metodos
        public override double getBonificacao()
        {
            return salario *= 0.17;
        }
        public override void aumentarSalaario()
        {
            salario *= 1.11;
        } 
    }
}