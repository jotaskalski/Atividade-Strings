namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 03 - Cifra de César");

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoArray = alfabeto.ToCharArray();

            Console.WriteLine("Digite o número secreto: ");
            int numeroSecreto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma palavra para ser encriptada: ");
            string palavraEncriptada = Console.ReadLine();
            string palavra = palavraEncriptada.ToUpper();

            string novaPalavra = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                int index = alfabeto.IndexOf(palavra[i]);
                string novaLetra = alfabetoArray[index + numeroSecreto].ToString();
                novaPalavra += string.Concat(novaLetra);
            }

            Console.WriteLine(novaPalavra);
            Console.ReadLine();

        }
    }
}