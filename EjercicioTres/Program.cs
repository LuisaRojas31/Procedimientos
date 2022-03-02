// See https://aka.ms/new-console-template for more information

int cantidad;

Console.WriteLine("Ingrese la cantidad");
cantidad = Convert.ToInt32(Console.ReadLine());
serieTres(cantidad);
Console.WriteLine("serie cinco");
serieCinco(cantidad);

void serieTres(int numero)
{
    for (int i = 3; i <=numero; i+=3)
    {
        Console.WriteLine(i);
    }
}

void serieCinco(int numero)
{
    int contador = 5;
    while(contador <= numero)
    {
        Console.WriteLine(contador);
        contador += 5;
    }
}