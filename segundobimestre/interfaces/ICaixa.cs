namespace segundo_d.interfaces
{
  //Modificador que implementa uma interface (Caixa) para a classe Funcionario. Definirá tudo que será acessível ao objeto do tipo Caixa na classe Program.
  public interface ICaixa
  {
    // constante declarada para o objeto caixa
    const int FUNCIONARIO_CAIXA = 0;
    //Métodos que poderão ser utilizados. Observe que o a Propriedade Matricula não foi definido, logo um objeto Caixa não poderá utilizá-lo.
    string Nome { get; set; }
    int Rg { get; set; }
    int Cargo { get; set; }
    double Salario { get; set; }
    void getInformacaoFuncao();
  }
}