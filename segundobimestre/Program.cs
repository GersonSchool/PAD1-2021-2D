using System;
// using segundo_d.encapsulamento;
using segundo_d.heranca;
using segundo_d.abstrato;
using segundo_d.interfaces;
using segundo_d.revisao;

namespace segundo_d
{
  class Program
  {
    static void Main(string[] args)
    {
      // encapsulamento();
      // heranca();
      // SemInterfaces();
      // ComInterfaces();
      // revisao();
      pratica();
    }

    public static void pratica(){
      IRacional homem = new Animal();
      homem.falar();
      IIrracional cachoro = new Animal();
      cachoro.latir();
    }

    public static void revisao(){
      Produto i = new Inorganico("vidro", 500, "Jarro de Vidro", 2000.0, 3);
      Produto o = new Organico("Maçã", 5.50, 40, 0301);

      o.CalcularDecomposicao();
    }

    public static void ComInterfaces(){
      //Observe que o objeto c pertence a interface Caixa, logo só poderá fazer uso dos métodos, propriedades e constantes declaradas na interface Caixa. Da mesma forma que o objeto g só poderá fazer uso do que foi liberado pela interface Gerente.
      ICaixa c = new Funcionario2_0("joaquim Silva", 1234567, 0, 1000.00);
      IGerente g = new Funcionario2_0("Rico D'Emery", "001-G", 1, 3000.00);
      //Chamada de método para exibir as informações dos funcionários
      c.getInformacaoFuncao();
      g.getInformacaoFuncao(); 
      // System.Console.WriteLine("RG do gerente: " + g.Rg);
    }

    public static void SemInterfaces()
    {
      //cria os objetos
      Funcionario a = new Funcionario("Joaquim Silva", 1234567, 0, 1000.00);
      Funcionario b = new Funcionario("Rico D'Emery", "001-G", 1, 3000.00);
      //chamada de método para exibir as informações dos funcionários
      a.getInformacaoFuncao();
      b.getInformacaoFuncao();
      //exemplo de instrução que utiliza um método que não deveria ser permitido
      System.Console.WriteLine("RG do gerente: " + b.Rg);
    }
    public static void abstrato() {
      Eletronico tv = new TV(220.0, 100.0, false, 42, 0);
      Eletronico radio = new Radio(220.0, 50.0, false);

      Console.WriteLine(tv.status);
      tv.Ligar();
      Console.WriteLine(tv.status);
    }
    public static void heranca()
    {

      Gerson g1 = new Gerson("gerson", 29);

      Joao j1 = new Joao("joão", 17, 1.7);

      Gerson g2 = j1;

      Gerson j2 = new Joao("joao", 16, 1.3);

      Console.WriteLine(g2.nome);
    }
    public static void encapsulamento()
    {
      // Produto p1 = new Produto("macarrão", 2.0, 20);

      // Produto p2 = new Produto();
      // p2.Description = "maçã";
      // p2.Value = 4.30;
      // p2.Storage = 55700;

      // Produto p3 = new Produto();
      // p3.Description = "arroz";
      // p3.Value = 2.30;
      // p3.Storage = 78;

      // Console.WriteLine(p2.Description);
      // Console.WriteLine(p2.Value);
      // Console.WriteLine(p2.Storage);

      // Console.WriteLine(p3.Description);
      // Console.WriteLine(p3.Value);
      // Console.WriteLine(p3.Storage);
    }
  }
}
