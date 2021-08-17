namespace segundo_d.abstrato
{
  public class TV : Eletronico
  {
    public int polegada;
    public int canal;
    public TV(double consumo, double voltagem, bool status, int polegada, int canal) : base(consumo, voltagem, status){
        this.polegada = polegada;
        this.canal = canal;
    }
    public override void Ligar()
    {
      this.status = true;
      this.canal = 12;
    }
    public override void Desligar()
    {
      this.status = false;
    }
  }
}