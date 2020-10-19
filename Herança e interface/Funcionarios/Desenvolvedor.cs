namespace Herança_e_interface.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        //Construtor pegando parametros da mae(base)
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {
        } 
        //Metodos
        public override double getBonificacao()
        {
            return salario *= 0.1;
        }
        public override void aumentarSalaario()
        {
            salario *= 0.15;
        } 
    }
}