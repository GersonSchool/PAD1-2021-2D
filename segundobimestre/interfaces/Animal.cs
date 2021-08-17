namespace segundo_d.interfaces
{
  public class Animal : IRacional, IIrracional
  {
    public void falar()
    {
      System.Console.WriteLine("Homem falando");
    }
    public void latir()
    {
      System.Console.WriteLine("cachorro latindo");
    }
  }
}