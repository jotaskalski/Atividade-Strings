namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            string arquivo = @"C:\Users\Juju\Desktop\Academia do Programador\Atividade-Strings\Exercicio06\Dados\Cidades.csv";
            string[] arquivoCSV = File.ReadAllLines(arquivo);

            string[] cidades = new string[arquivoCSV.Length];
            string[] estados = new string[arquivoCSV.Length];

            List<string> cidadesLista = new List<string>();
            List<string> estadosLista = new List<string>();

            do
            {
                Console.Clear();
                Console.Write("[1] para ordem alfabética;\n[2] para agrupar cidade/estado;\n[3] para sair.\n> ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        SepararCidadesEstados(arquivoCSV, cidades, estados, ref cidadesLista, ref estadosLista);
                        Console.Clear();

                        ImprimirOrdemAlfabeticaCidades(cidadesLista);
                        Console.ReadLine();

                        break;

                    case "2":
                        SepararCidadesEstados(arquivoCSV, cidades, estados, ref cidadesLista, ref estadosLista);
                        Console.Clear();
                        int k = 0;

                        ImprimirConjuntoEstadoCidade(cidades, estados, estadosLista);

                        Console.ReadLine();
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Saindo...");
                        Console.ReadLine();
                        Console.ResetColor();
                        continuar = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entre com um valor válido!");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            } while (continuar == true);
        }

        private static void ImprimirConjuntoEstadoCidade(string[] cidades, string[] estados, List<string> estadosLista)
        {
            for (int i = 0; i < estadosLista.Count; i++)
            {
                Console.WriteLine($"\t{estadosLista[i]}");
                Console.WriteLine();

                for (int j = 0; j < estados.Length; j++)
                {

                    if (estadosLista[i] == estados[j])
                    {
                        Console.WriteLine(cidades[j]);
                    }
                }

                Console.WriteLine();
            }
        }

        private static void ImprimirOrdemAlfabeticaCidades(List<string> cidadesLista)
        {
            for (int valor = 65; valor <= 90; valor++)
            {
                char valorChar = Convert.ToChar(valor);

                Console.WriteLine($"\t{valorChar}");
                Console.WriteLine();


                for (int i = 0; i < cidadesLista.Count - 1; i++)
                {
                    if (cidadesLista[i].StartsWith(valorChar))
                    {
                        Console.WriteLine(cidadesLista[i]);
                    }

                }

                Console.WriteLine();
            }
        }

        private static void SepararCidadesEstados(string[] arquivoCSV, string[] cidades, string[] estados, ref List<string> cidadesLista, ref List<string> estadosLista)
        {
            for (int i = 1; i < arquivoCSV.Length; i++)
            {
                string[] elementos = arquivoCSV[i].Split(';');

                for (int j = 0; j < elementos.Length; j++)
                {
                    cidades[i - 1] = elementos[2];
                    estados[i - 1] = elementos[3];
                }
                cidadesLista = cidades.ToList();

                estadosLista = estados.ToList();

                cidadesLista = cidadesLista.Distinct().ToList();
                estadosLista = estadosLista.Distinct().ToList();
            }
        }
    }
}

