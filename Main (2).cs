using System;
  // Muy facito,nao precisa de explicacao
namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            
        Console.WriteLine("Digite a primeira data (no formato dd/MM/yyyy):");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda data (no formato dd/MM/yyyy):");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

       
        int diferencaDias = (data2 - data1).Duration().Days;

        Console.WriteLine($"A quantidade de dias entre {data1:dd/MM/yyyy} e {data2:dd/MM/yyyy} e de {diferencaDias} dias.");
            
        }
    }
}