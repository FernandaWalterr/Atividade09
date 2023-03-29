namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Frase em letras maiúsculas:");
            Console.WriteLine(frase.ToUpper());

            Console.WriteLine("Frase em letras minúsculas:");
            Console.WriteLine(frase.ToLower());

            Console.WriteLine("Quantidade de caracteres da frase:");
            Console.WriteLine(frase.Length);

            Console.WriteLine("Primeira palavra da frase:");
            Console.WriteLine(frase.Split()[0]);

            Console.WriteLine("Última palavra da frase:");
            Console.WriteLine(frase.Split()[^1]);
        }
    }
}