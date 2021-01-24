int LerEntrada ()
{
    int a = Convert.ToInt32 (Console.ReadLine());
    return a;
}

bool EscreverSaida ()
{
    int a = LerEntrada ();
    int b = LerEntrada ();
    return ((a>0)&&(b>0));
}

bool s = EscreverSaida ();
Console.WriteLine (s);
