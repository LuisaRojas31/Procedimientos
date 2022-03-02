// See https://aka.ms/new-console-template for more information

int numeroUno;
int numeroDos;
int totalResta;

Console.WriteLine("Ingrese Número Uno");
numeroUno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese Número Dos");
numeroDos = Convert.ToInt32(Console.ReadLine());

totalResta = Resta(numeroUno, numeroDos);
Console.WriteLine("la resta es: {0}", totalResta);

int Resta(int numeroUno, int numeroDos)
{
    int resta;
    resta=numeroUno - numeroDos;
    return resta;
}