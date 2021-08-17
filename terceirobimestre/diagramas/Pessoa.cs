namespace terceirobimestre.diagramas
{
  public abstract class Pessoa
  {
    private int id;
    private string nome;
    private string nomeFantasia;
    private string logradouro;
    private int numero;
    private string complemento;
    private string bairro;
    private string cep;
    private string cidade;
    private string uf;

    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
    public string Logradouro { get => logradouro; set => logradouro = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Complemento { get => complemento; set => complemento = value; }
    public string Bairro { get => bairro; set => bairro = value; }
    public string Cep { get => cep; set => cep = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Uf { get => uf; set => uf = value; }
  }
}