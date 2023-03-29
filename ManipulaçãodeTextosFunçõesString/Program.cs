namespace ManipulaçãodeTextosFunçõesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Divide a frase em palavras//
            string[] palavras = frase.Split(' ');

            // Converte a primeira letra de cada palavra para maiúscula//
            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i].Length > 0)
                {
                    palavras[i] = char.ToUpper(palavras[i][0]) + palavras[i].Substring(1);
                }
            }

            // Junta as palavras novamente em uma frase
            string novaFrase = string.Join(" ", palavras);

            Console.WriteLine("A frase em Title Case é:");
            Console.WriteLine(novaFrase);
        }
    }
}