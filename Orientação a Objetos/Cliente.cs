namespace Orientação_a_Objetos
{
    public class Cliente
  {
    public string nome;
    public string cpf;
    public string profissao;

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
    public void setCpf(string cpf)
    {
      this.cpf = cpf;
    }

    public string getProfissao()
    {
      return this.profissao;
    }
    public void setProfissao(string profissao)
    {
      this.profissao = profissao;
    }



  }
}