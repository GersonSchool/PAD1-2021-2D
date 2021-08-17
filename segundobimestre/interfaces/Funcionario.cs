namespace segundo_d.interfaces
{
  public class Funcionario
  {
    //declaração de constates
    public const int FUNCIONARIO_CAIXA = 0;
    public const int FUNCIONARIO_GERENTE = 1;
    //declaração de atributos
    private string nome;
    private string matricula;
    private int rg;
    private double salario;
    private int cargo;
    //método construtor
    public Funcionario(string n, int rg, int cg,
    double sal)
    {
      this.Nome = n;
      this.Rg = rg;
      this.Cargo = cg;
      this.Salario = sal;
    }
    //método construtor
    public Funcionario(string n, string mat, int cg,
    double sal)
    {
      this.Nome = n;
      this.Matricula = mat;
      this.Cargo = cg;
      this.Salario = sal;
    }

    public string Nome { get => nome; set => nome = value; }
    public string Matricula { get => matricula; set => matricula = value; }
    public int Rg { get => rg; set => rg = value; }
    public double Salario { get => salario; set => salario = value; }
    public int Cargo { get => cargo; set => cargo = value; }


    //exibe informações do Funcionario
    public void getInformacaoFuncao()
    {
      if (this.Cargo == FUNCIONARIO_CAIXA)
        System.Console.WriteLine("O caixa " +
        this.Nome + ", RG " + this.Rg + ", recebe R$" + this.Salario);

      if (this.Cargo == FUNCIONARIO_GERENTE)
        System.Console.WriteLine("O gerente " +
        this.Nome + ", matricula " + this.Matricula + ", recebe R$" + this.Salario);
    }
  }
}