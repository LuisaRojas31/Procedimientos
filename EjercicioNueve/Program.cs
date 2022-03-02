// See https://aka.ms/new-console-template for more information
//Realice un algoritmo que muestre la suma de los numeros de -10 hasta n

int numero;
double suma;

numero = pregunta("ingrese numero");
suma = resultado(numero);
Console.WriteLine("la suma es" + suma);

int pregunta (string mensaje)
{
    Console.WriteLine(mensaje);
    return Convert.ToInt32(Console.ReadLine());
}

double resultado (int numero)
{
    double suma = 0;

    for (int i = -10; i <= numero; i++)
    {
        suma += i;
        
    }
    return suma;
}
