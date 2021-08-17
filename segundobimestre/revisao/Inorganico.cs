namespace segundo_d.revisao
{
  public class Inorganico : Produto
  {
    private string material;
    private int decomposicao;

    public Inorganico(string materialProduto, int descomposicaoProduto, string descricaoProduto, double valorProduto, int estoqueProduto) : base(descricaoProduto, valorProduto, estoqueProduto)
    {
      this.material = materialProduto;
      this.decomposicao = descomposicaoProduto;
    }
    public override void CalcularDecomposicao()
    {
      System.Console.WriteLine("o produto {0}, é feito de {1} e custa {2}", Descricao, material, Valor);
    }

    public override void RetornaValor()
    {
      System.Console.WriteLine(Valor);
    }
  }
}