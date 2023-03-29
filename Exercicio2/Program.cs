namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Define os caracteres de separação de palavras//
            char[] separadores = { ' ', ',', '.', ':', '!', '?' };

            // Divide a frase em palavras usando os caracteres de separação//
            string[] palavras = frase.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            // Imprime o número de palavras//
            Console.WriteLine("Número de palavras na frase: {0}", palavras.Length);
        }
    }
}