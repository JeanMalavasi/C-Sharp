namespace Herança_e_interface.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        //Construtor pegando parametros da mae(base)
        public Auxiliar(string cpf) : base(cpf, 2000)
        {  
        } 
        //Metodos
        public override double getBonificacao()
        {
            return salario *= 0.2;
        }
        public override void aumentarSalaario()
        {
            salario *= 1.1;
        } 
    }
}