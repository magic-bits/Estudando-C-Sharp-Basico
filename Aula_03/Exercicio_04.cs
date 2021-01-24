using System;

public void Comparar (decimal a, int b, string c){
	var typea = a.GetType();
	var typeb = b.GetType();
	var typec = c.GetType();
	Console.WriteLine (typea == typeof(int));
	Console.WriteLine (typeb == typeof(int));
	Console.WriteLine (typec == typeof(int));
}

Console.WriteLine ("Digite o primeiro numero");
decimal a = Convert.ToDecimal (Console.ReadLine());
Console.WriteLine ("Digite o segundo numero");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Digite o terceiro numero");
string c = Console.ReadLine();
Comparar (a, b, c);
