namespace terceirobimestre.agregacaoecomposicao
{
    public class CarroAgregacao {
      private string modeloCarro;
      private Porta pErq = new Porta("azul");
      private Porta pDir = new Porta("azul");
      private Motor motor = new Motor(1.6);
      public CarroAgregacao(string m){
        this.ModeloCarro=m; 
      }

    public string ModeloCarro { get => modeloCarro; set => modeloCarro = value; }
    public Porta PErq { get => pErq; set => pErq = value; }
    public Porta PDir { get => pDir; set => pDir = value; }
    public Motor Motor { get => motor; set => motor = value; }
  }
}