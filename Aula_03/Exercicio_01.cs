using System;
					
public int Aleatorio (int primeiro, int ultimo){
	Random num = new Random();
	return num.Next(primeiro, ultimo);
}

Console.WriteLine ("Digite o primeiro valor");
int p = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Digite o segundo valor");
int u = Convert.ToInt32 (Console.ReadLine());
int s = Aleatorio (p, u);
Console.WriteLine (s);
