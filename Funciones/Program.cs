// See https://aka.ms/new-console-template for more information

// calcular el area de un cuadrado

double lado;
double areacuadrado;

Console.WriteLine("Ingrese el lado: ");
lado = Convert.ToDouble(Console.ReadLine());
areacuadrado = AreaCuadrado(lado);
Console.WriteLine("El area del cuadrado es {0}", areacuadrado);



double AreaCuadrado (double lado)
{
    double areaCuadrado;
    areaCuadrado = lado * lado;
    return areaCuadrado;
}