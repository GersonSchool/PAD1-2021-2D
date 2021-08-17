using System;
using terceirobimestre.agregacaoecomposicao;

namespace terceirobimestre
{
    class Program
    {
        static void Main(string[] args)
        {
          CarroAgregacao carro = new CarroAgregacao("Passeio");
          Console.WriteLine("Descrição do carro:\n"
          + "Modelo: "+carro.ModeloCarro + "Cor da porta esquerda" + carro.PErq.cor +
          "Potência do motor" + carro.Motor.potencia);
        }
    }
}
