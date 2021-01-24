using System;

public double Pitagoras (int a, int b){
	double h = Math.Sqrt(Math.Pow(a, 2)+Math.Pow(b, 2));
	return h;
}
Console.WriteLine ("Digite o primeiro cateto");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Digite o segundo cateto");
int b = Convert.ToInt32 (Console.ReadLine());
double s = Math.Round(Pitagoras (a, b), 2);
Console.WriteLine ("Hipotenusa = " + s);
