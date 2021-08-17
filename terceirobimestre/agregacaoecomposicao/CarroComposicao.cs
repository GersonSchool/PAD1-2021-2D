namespace terceirobimestre.agregacaoecomposicao
{
  public class CarroComposicao
  {
    private string modeloCarro;
    private Porta pEsq, pDir;
    private Motor motor;
    public CarroComposicao (string m, string c, double p) {
      this.ModeloCarro = m;
      PEsq = new Porta(c);
      PDir = new Porta(c);
      Motor = new Motor(p);
    }

    public string ModeloCarro { get => modeloCarro; set => modeloCarro = value; }
    public Porta PEsq { get => pEsq; set => pEsq = value; }
    public Porta PDir { get => pDir; set => pDir = value; }
    public Motor Motor { get => motor; set => motor = value; }
  }
}