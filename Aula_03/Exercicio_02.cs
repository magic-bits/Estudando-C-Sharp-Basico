using System;
					
public decimal DecemalPrecisao (decimal num, int prec){
	decimal r = Math.Round(num, prec);
	return r;
}

Console.WriteLine ("Digite o numero decimal");
decimal p = Convert.ToDecimal (Console.ReadLine());
Console.WriteLine ("Digite o numero de casa de  precisão");
int u = Convert.ToInt32 (Console.ReadLine());
decimal s = DecemalPrecisao (p, u);
Console.WriteLine (s);
