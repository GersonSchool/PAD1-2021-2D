namespace segundo_d.heranca
{
    public class Gerson
    {
        public string nome;
        public int idade;

        public Gerson(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }

        public void falar(){
            System.Console.WriteLine("Gerson falando");
        }
    }
}