// See https://aka.ms/new-console-template for more information

string nombreOne;
string nombreTwo;

Console.WriteLine("Ingrese nombre One: ");
nombreOne = Console.ReadLine();

MostrarSaludo(nombreOne);

Console.WriteLine("Ingrese nombre Two: ");
nombreTwo = Console.ReadLine();

MostrarSaludo(nombreTwo);


void MostrarSaludo (string nombre)
{
    Console.WriteLine("Hola {0}", nombre);
}