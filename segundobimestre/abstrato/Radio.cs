namespace segundo_d.abstrato
{
  public class Radio : Eletronico
  {
    public const int AM = 1;
    public const int FM = 2;
    public int banda;
    public double sintonia;
    public int volume = 0;
    public Radio(double consumo, double voltagem, bool status) : base(consumo, voltagem, status)
    {
    }
    public override void Ligar()
    {
      this.status = true;
      this.sintonia = 88.1;
      this.volume = 10;
      this.banda = AM;
    }
    public override void Desligar()
    {
      this.status = false;
      this.volume = 0;
    }
  }
}