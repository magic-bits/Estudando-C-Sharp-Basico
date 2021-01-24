```csharp
using System;

public void Comparar (int a, double b, double c, float d, int e){
	var typea = a.GetType();
	var typeb = b.GetType();
	var typec = c.GetType();
	var typed = d.GetType();
	var typee = e.GetType();
	Console.WriteLine (typea == typeof(int));
	Console.WriteLine (typeb == typeof(int));
	Console.WriteLine (typec == typeof(int));
	Console.WriteLine (typed == typeof(int));
	Console.WriteLine (typee == typeof(int));
}

int a = 32;
double b = 5e2;
var c = Double.NaN;
float d = 3.1415f;
int e = -32;
Comparar (a, b, c, d, e);
```
