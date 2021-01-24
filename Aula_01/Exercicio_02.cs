int v = 42;
float f = 3.14f;
double d = 2.5;
decimal d2 = 5.55m;
string s = "Tetra" + 1994;
string s2 = "texto";
char c = 'P';
bool b = false;


Console.WriteLine (v + " " + v.GetType());
Console.WriteLine (f + " " + f.GetType());
Console.WriteLine (d + " " + d.GetType());
Console.WriteLine (d2 + " " + d2.GetType());
Console.WriteLine (c + " " + c.GetType());
Console.WriteLine (s + " " + s.GetType());
Console.WriteLine (s2 + " " + s.GetType());
Console.WriteLine (b + " " + b.GetType());
Console.WriteLine (("Tetra" + 1994) + " " + ("Tetra" + 1994).GetType())
