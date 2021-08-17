namespace segundo_d.abstrato
{
  public abstract class Empregado
  {
    public string nome;
    public string sobrenome;
    public string cpf;

    protected Empregado(string nome, string sobrenome, string cpf)
    {
      this.nome = nome;
      this.sobrenome = sobrenome;
      this.cpf = cpf;
    }

    public abstract double Salario();// método abstrato
  }
}