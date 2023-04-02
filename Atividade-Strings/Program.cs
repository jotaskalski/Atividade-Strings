namespace AtividadeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 01 - Title case");

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] separarPalavras = frase.Split(' ');

            for (int i = 0; i < separarPalavras.Length; i++)
            {

                separarPalavras[i] = separarPalavras[i].Substring(0, 1).ToUpper() + separarPalavras[i].Substring(1).ToLower();
            }

            frase = string.Join(" ", separarPalavras);
            Console.WriteLine(frase);
            Console.ReadLine();

        }
    }
}