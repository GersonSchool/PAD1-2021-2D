namespace segundo_d.heranca
{
    public class Gabriel : Gerson
    {
        public double altura;

        public Gabriel(string nome, int idade, double altura)
         : base(nome, idade){
            this.altura = altura;
        }

        public void pula(){
            System.Console.WriteLine("Gabriel pulando");
        }

    }
}