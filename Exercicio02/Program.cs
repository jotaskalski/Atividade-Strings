namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios 02 - Número de palavras");

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] subs = frase.Split(" ");

            Console.WriteLine(subs.Length);
            Console.ReadLine();

        }
    }
}