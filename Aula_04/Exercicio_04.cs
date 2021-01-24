using System;

namespace Exercicio01
{
    class Program
    {
        public static string Truncar (string s, int x)
        {
            string saida = s.Substring(0, x);
            return saida;
        }
        public static string Truncar2(string s, int x)
        {
            string saida = s.Substring(x);
            return saida;
        }
        static void Main(string[] args)
        {
            string texto = "Entrada";
            Console.Write("Digite uma palavra: ");
            string entrada = Console.ReadLine();
            int posição = Convert.ToInt32(Console.ReadLine());
            string metade1 = Truncar(texto, posição);
            string metade2 = Truncar2(texto, posição);
            string saida = metade1 + entrada + metade2;
            Console.WriteLine(texto);
            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}
