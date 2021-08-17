namespace terceirobimestre.diagramas
{
  public abstract class Juridica: Pessoa
  {
    private string cnpj;
    private string inscricaoEstadual;
    private string fundacao;

    public string Cnpj { get => cnpj; set => cnpj = value; }
    public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
    public string Fundacao { get => fundacao; set => fundacao = value; }
  }
}