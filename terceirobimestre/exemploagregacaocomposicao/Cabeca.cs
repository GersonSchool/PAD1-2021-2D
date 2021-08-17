namespace terceirobimestre.exemploagregacaocomposicao
{
  public class Cabeca
  {
    private Boca boca;
    private Olhos olhos;
    private Cabelo cabelo = new Cabelo();
    private Orelhas orelhas;
    public Cabeca(){
      this.boca = new Boca();
      this.olhos = new Olhos();
      this.orelhas = new Orelhas();
    }
  }
}