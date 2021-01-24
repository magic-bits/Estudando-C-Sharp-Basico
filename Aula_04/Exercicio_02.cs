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
        static void Main(string[] args)
        {
            Console.Write("String de entrada: ");
            string entrada = Console.ReadLine();
            Console.Write("Valor para truncar: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            string saida = Truncar(entrada, valor);
            Console.Write(saida);
            Console.ReadLine();
        }
    }
}
```
