namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoOriginal = "DIEGO";
            int deslocamento = 2;

            string textoCifrado = CifraDeCesar(textoOriginal, deslocamento);

            Console.WriteLine($"Texto original: {textoOriginal}");
            Console.WriteLine($"Texto cifrado: {textoCifrado}");
        }

        static string CifraDeCesar(string texto, int deslocamento)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int tamanhoAlfabeto = alfabeto.Length;

            string textoCifrado = "";

            foreach (char letra in texto)
            {
                int posicaoAtual = alfabeto.IndexOf(letra);
                int posicaoCifrada = (posicaoAtual + deslocamento) % tamanhoAlfabeto;

                textoCifrado += alfabeto[posicaoCifrada];
            }

            return textoCifrado;
        }
    }
}