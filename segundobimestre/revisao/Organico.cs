namespace segundo_d.revisao
{
  public class Organico : Produto
  {
    private int validade;
    public Organico(string descricaoProduto, double valorProduto, int estoqueProduto, int validade) : base(descricaoProduto, valorProduto, estoqueProduto)
    {
      this.Validade = validade;
    }
    public int Validade { get => validade; set => validade = value; }
    public override void CalcularDecomposicao()
    {
      System.Console.WriteLine($"O produto {Descricao}, tem validade até {Validade}");
    }
    public override void RetornaValor()
    {
      System.Console.WriteLine(Valor * Validade);
    }
  }
}