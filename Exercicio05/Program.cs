namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios 05");
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Frase em maiúsculo: {frase.ToUpper()}");
            Console.WriteLine($"Frase em minúsculo: {frase.ToLower()}");
            Console.WriteLine($"Quantidade de caracteres na frase: {frase.Length}");

            string[] primeiraPalavra = frase.Split(' ');

            Console.WriteLine($"A primeira palavra da frase é: {primeiraPalavra[0]}");
            Console.WriteLine($"A ultima palavra da frase é: {primeiraPalavra[primeiraPalavra.Length - 1]}");
            Console.ReadLine();
        }
    }
}