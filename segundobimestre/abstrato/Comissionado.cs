namespace segundo_d.abstrato
{
  public class Comissionado : Empregado
  {
      public double totalVendas;
      public double taxaComissao;
    public Comissionado(string nome, string sobrenome, string cpf) : base(nome, sobrenome, cpf)
    {
    }

    public override double Salario()
    {
      return (this.totalVendas * this.taxaComissao);
    }
  }
}