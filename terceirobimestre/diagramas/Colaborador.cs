namespace terceirobimestre.diagramas
{
  public class Colaborador : Fisica
  {
    private string ctps;
    private string pis;
    private string tituloEleitor;
    private bool reservista;
    private string estadoCivil;
    private int numDependente;
    private bool ativo;
    private string setor;
    private string cargo;
    private double salario;
    private string telefone1;
    private string telefone2;
    private string emailPessoal;
    private string emailCorporativo;

    public string Ctps { get => ctps; set => ctps = value; }
    public string Pis { get => pis; set => pis = value; }
    public string TituloEleitor { get => tituloEleitor; set => tituloEleitor = value; }
    public bool Reservista { get => reservista; set => reservista = value; }
    public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public int NumDependente { get => numDependente; set => numDependente = value; }
    public bool Ativo { get => ativo; set => ativo = value; }
    public string Setor { get => setor; set => setor = value; }
    public string Cargo { get => cargo; set => cargo = value; }
    public double Salario { get => salario; set => salario = value; }
    public string Telefone1 { get => telefone1; set => telefone1 = value; }
    public string Telefone2 { get => telefone2; set => telefone2 = value; }
    public string EmailPessoal { get => emailPessoal; set => emailPessoal = value; }
    public string EmailCorporativo { get => emailCorporativo; set => emailCorporativo = value; }

    private void Admitir(){

    }
    private void Demitir(){
      
    }
  }
}