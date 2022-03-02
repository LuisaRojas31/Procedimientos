// See https://aka.ms/new-console-template for more information

int numero;
double respuesta;
numero = Dolares("ingrese cantidad de dolares");
Console.WriteLine(numero);
respuesta = Procedimiento(numero);
Console.WriteLine(respuesta);

int Dolares(string mensaje)
{
    Console.WriteLine(mensaje);
    return Convert.ToInt32(Console.ReadLine());
}

double Procedimiento(double numeroS)
{
    const double dolar = 3882.67;
    double resultado;
    resultado = numeroS * dolar;
    
    return resultado;
}