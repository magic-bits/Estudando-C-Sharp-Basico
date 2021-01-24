```csharp
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
        public static int EncontrarArroba(string email)
        {
            int encontrar = email.IndexOf("@");
            return encontrar;
        } 
        static void Main(string[] args)
        {
            Console.Write("Digite o e-mail: ");
            string entrada = Console.ReadLine();
            int posiçãoArroba = EncontrarArroba(entrada);
            int metade = posiçãoArroba / 2;
            string pontos = "...";
            string nome = Truncar(entrada, metade);
            string corpo = Truncar2(entrada, posiçãoArroba);
            nome = nome + pontos + corpo;
            Console.Write(nome);
            Console.ReadLine();
        }
    }
}
```
