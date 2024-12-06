using System;
  // Expliquei pra vc ver que eu não COLO.
namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            
        Console.WriteLine("Digite uma frase:");//pede para digitar uma frase
        string frase = Console.ReadLine(); // le a frase

        int contadorPalavras = 0; // declaro uma variavel como inteira
        bool dentrodaPalavra = false; // declaro uma variavel como booleana

        foreach (char letra in frase) // loopzin básico com o char de caracterer
        {
            if (!char.IsWhiteSpace(letra)) // verifica se tem o espaços
            {
                if (!dentrodaPalavra) // se a variavel for verdadeira
                {
                    dentrodaPalavra = true; // declaro a var como true again ;)
                    contadorPalavras++; // add um aí pra nós
                }
            }
            else //SENAAAAO
            {
                dentrodaPalavra = false; // declaro a var como false again ;(
            }
        }

        Console.WriteLine($"A frase contem {contadorPalavras} palavras."); // escreve esse texto aí
        }
    }
}