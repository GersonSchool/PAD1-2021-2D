namespace segundo_d.abstrato
{
  public class Assalariado : Empregado
  {

    public double salario;

    public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome, sobrenome, cpf)
    {
        this.salario = salario;
    }

    public override double Salario()
    {
      return this.salario;
    }
  }
}