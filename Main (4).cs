using System;
  // Explicação again pq jo soy muy boa
namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            
        Console.WriteLine("Digite um valor:"); //Digite um valor aí
        int valor = int.Parse(Console.ReadLine()); //Le esse valor

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 }; //uma array para armazenar esse tantão de notas
        
        Console.WriteLine($"Valor informado: {valor}"); // escreve isso ai
        Console.WriteLine("Notas necessarias:"); // escreve isso ai

        foreach (int nota in notas) // loopzin básico
        {
            int quantidade = valor / nota; // calculozinho1
            valor %= nota; // calculo2 basiquinho               

            if (quantidade > 0) // condicional se for maior que 0 vai fazer um trem
            {
                Console.WriteLine($"{quantidade} nota(s) de R$ {nota},00"); // esse aqui é o trem
    
                }
            }
        }
    }
}