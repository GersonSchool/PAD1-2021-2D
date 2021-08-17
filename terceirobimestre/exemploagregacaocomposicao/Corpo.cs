namespace terceirobimestre.exemploagregacaocomposicao
{
    public class Corpo
    {
        private Cabeca cabeca;
        private Braco braco;
        private Perna perna;

        public Corpo() {
          this.cabeca = new Cabeca();
          this.braco = new Braco();
          this.perna = new Perna();
        }
    }
}