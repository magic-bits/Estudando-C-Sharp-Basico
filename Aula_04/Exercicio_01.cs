```csharp
using System;

namespace Exercicio01
{
    class Program
    {
        public static string Vazio (string s)
        {
            if (s == "")
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            string saida = Vazio(entrada);
            Console.Write(saida);
            Console.ReadLine();
        }
    }
}
```
