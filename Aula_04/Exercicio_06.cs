```csharp
using System;

namespace Exercicio01
{
    class Program
    {
        public static string VerificarMinuscula(string entrada)
        {
            if (entrada == entrada.ToLower())
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
        static void Main(string[] args)
        {
            string texto = "Entrada";
            Console.Write("Digite uma palavra: ");
            string entrada = Console.ReadLine();
            string saida = VerificarMinuscula(entrada);
            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}
```
