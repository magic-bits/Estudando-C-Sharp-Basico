```csharp
using System;

public int Maximo (int a, int b, int c, int d, int e){
	int m = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
	return m;
}

public int Minimo (int a, int b, int c, int d, int e){
	int m = Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))));
	return m;
}

public void Extremos (int a, int b, int c, int d, int e){
	int mx = Maximo(a, b, c, d, e);
	int mn = Minimo (a, b, c, d, e);
	Console.WriteLine ("Valor maximo: " + mx);
	Console.WriteLine ("Valor minimo: " + mn);
}

Console.WriteLine ("Digite o primeiro numero");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Digite o segundo numero");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Digite o terceiro numero");
int c = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Digite o quarto numero");
int d = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Digite o quinto numero");
int e = Convert.ToInt32 (Console.ReadLine());
Extremos (a, b, c, d, e);
```
