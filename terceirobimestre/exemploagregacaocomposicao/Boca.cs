namespace terceirobimestre.exemploagregacaocomposicao
{
    public class Boca
    {
        private Dentes dentes = new Dentes();
        private Lingua lingua;
        public Boca(){
          this.lingua = new Lingua();
        }
    }
}