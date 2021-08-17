namespace segundo_d.encapsulamento
{
    public class Produto
    {
        private string description;
        private double value;
        private int storage;

        public string Description {get; set;}
        public double Value {get; set;}
        public int Storage {get; set;}

        public Produto(){}

        public Produto(string descricao, double valor, int estoque){
            this.description = descricao;
            this.value = valor;
            this.storage = estoque;
        }

        // public string getDescription(){
        //     return this.description;
        // }
        // public double getValue(){
        //     return this.value;
        // }
        // public int getStorage(){
        //     return this.storage;
        // }
        // public void setDescription(string descricao){
        //     this.description = descricao;
        // }
        // public void setValue(double valor){
        //     this.value = valor;
        // }
        // public void setStorage(int estoque){
        //     this.storage = estoque;
        // }
    }
}