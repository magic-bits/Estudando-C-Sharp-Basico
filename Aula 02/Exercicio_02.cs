int Quadrado(int numero)
{
    return numero*numero;
}

bool Pitagoras (int x, int y, int z)
{
    return ((Quadrado(x)+Quadrado(y)) == Quadrado(z));
}

bool EscreverSaida()
{
    int a = LerEntrada();
    int b = LerEntrada();
    int c = LerEntrada();
    return Pitagoras(a, b, c);
}

bool s = EscreverSaida();
Console.WriteLine(s);
