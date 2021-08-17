namespace segundo_d.abstrato
{
  public abstract class Eletronico
  {
    public double consumo;
    public double voltagem;
    public bool status;

    public Eletronico(double consumo, double voltagem, bool status)
    {
      this.consumo = consumo;
      this.voltagem = voltagem;
      this.status = status;
    }

    public abstract void Ligar();
    public abstract void Desligar();

    public bool isLigado(){
        return this.status;
    }
  }
}