namespace Herança_e_interface.Funcionarios
{
    public abstract class Funcionario
    {
        public string nome;
        public string cpf;
        public double salario {get; protected set;}
        public static int TotalDeFuncioarios {get; private set;}
       
        //Construtor
        public Funcionario(string cpf, double salario)
        {
            this.cpf = cpf;
            this.salario = salario;
            TotalDeFuncioarios++;
        }

        //Metodos
        public abstract double getBonificacao();
        public abstract void aumentarSalaario();
      
        //Getters e Setters
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }
            /*   public void setCpf(string cpf)
        {
            this.cpf = cpf;
        } */

       /*  public double getSalario()
        {
            return this.salario;
        }
        private void setSalario(double salario)
        {
            this.salario = salario;
        } */
    }
}