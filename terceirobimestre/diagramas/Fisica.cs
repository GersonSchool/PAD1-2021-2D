namespace terceirobimestre.diagramas
{
  public abstract class Fisica: Pessoa
  {
    private string cpf;
    private string rg;
    private string genero;
    private string nasc;

    public string Cpf { get => cpf; set => cpf = value; }
    public string Rg { get => rg; set => rg = value; }
    public string Genero { get => genero; set => genero = value; }
    public string Nasc { get => nasc; set => nasc = value; }
  }
}