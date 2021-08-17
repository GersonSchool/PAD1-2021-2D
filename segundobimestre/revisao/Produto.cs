namespace segundo_d.revisao
{
  public abstract class Produto
  {
    private string descricao;
    private double valor;
    private int estoque;

    public Produto(string descricaoProduto, double valorProduto, int estoqueProduto)
    {
      this.Descricao = descricaoProduto;
      this.Valor = valorProduto;
      this.Estoque = estoqueProduto;
    }
    public string Descricao { get => descricao; set => descricao = value; }
    public double Valor { get => valor; set => valor = value; }
    public int Estoque { get => estoque; set => estoque = value; }
    public virtual void CalcularDecomposicao() {
      System.Console.WriteLine("produto sem validade");
    }
    public abstract void RetornaValor();
  }
}