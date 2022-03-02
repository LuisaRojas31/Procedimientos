// See https://aka.ms/new-console-template for more information
double ValorArticulo;
const double descuento = 0.05;
double valorDescuento;

ValorArticulo = obtenerValorArticulo();
valorDescuento = calcularDescuento(ValorArticulo, descuento);
Console.WriteLine("el valor del articulo es"+valorDescuento);

bool validaciones(double valorArticulo)
{
    if(valorArticulo > 150000)
    {
        return true;
    }
    return false;
}

double obtenerValorArticulo()
{
    Console.WriteLine("Ingrese el valor del articulo");
    return Convert.ToDouble(Console.ReadLine());
}

double calcularDescuento(double valorArticulo)
{
    double valorTotalDescuento;
    valorTotalDescuento = valorArticulo * descuento;
    return valorTotalDescuento; 
}

