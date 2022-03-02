// See https://aka.ms/new-console-template for more information

int numeroOne;
int numeroTwo;
int totalSuma;
int totalResta;
int totalMultiplicacion;
int totalDivision;

Console.WriteLine("Ingrese número uno");
numeroOne=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese número dos");
numeroTwo = Convert.ToInt32(Console.ReadLine());

totalSuma = Suma(numeroOne,numeroTwo);
totalResta = Resta(numeroOne, numeroTwo);
totalMultiplicacion = Multiplicacion(numeroOne, numeroTwo);
totalDivision = Division(numeroOne, numeroTwo);
Console.WriteLine($"total suma es :{totalSuma}\n total resta es :{totalResta}\n total multiplicacion es:{totalMultiplicacion} \n total divison es:{totalDivision}");


int Suma (int numeroOne, int numeroTwo)
{
    int suma;
    suma = numeroOne + numeroTwo;
    return suma;
}

int Resta (int numeroOne, int numeroTwo)
{
    int resta;
    resta = numeroOne - numeroTwo;
    return resta;
}

int Multiplicacion(int numeroOne, int numeroTwo)
{
    int multiplicacion;
    multiplicacion = numeroOne * numeroTwo;
    return multiplicacion;
}

int Division(int numeroOne, int numeroTwo)
{
    int division;
    division = numeroOne / numeroTwo;
    return division;
}