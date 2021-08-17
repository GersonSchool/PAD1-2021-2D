namespace segundo_d.interfaces
{
  //Modificador que implementa uma interface (Caixa) para a classe Funcionario. Definirá tudo que será acessível ao objeto do tipo Caixa na classe Program.
  public interface IGerente
  {
    // constante declarada para o objeto gerente
    const int FUNCIONARIO_GERENTE = 1;
    //Métodos que poderão ser utilizados. Observe que o a Propriedade Rg não foi definido, logo um objeto Caixa não poderá utilizá-lo.
    string Nome { get; set; }
    string Matricula { get; set; }
    int Cargo {get; set;}
    double Salario { get; set; }
    void getInformacaoFuncao();
  }
}