// See https://aka.ms/new-console-template for more information
// elabore un algoritmo que solicite tres notas de un estudiante entre 0 y 5 y decir cual
// es el promedio de esas notas

double notaUno, notaDos, notaTres;
double promedio;
notaUno = pregunta("ingrese nota uno");
notaDos = pregunta("ingrese nota dos");
notaTres = pregunta("ingrese nota tres");
if(validacion(notaUno, notaDos, notaTres))
{
    promedio = procedimiento(notaUno, notaDos,notaTres);
    Console.WriteLine("promedio es " + promedio);
} else
{
    Console.WriteLine("las notas deben ser entre 0 y 5");
}

double pregunta (string mensaje)
{
    Console.WriteLine(mensaje);
    return Convert.ToDouble(Console.ReadLine());
}

bool validacion (double notaUno, double notaDos, double notaTres)
{
    if ((notaUno >= 0 && notaUno <= 5) && (notaDos >= 0 && notaDos <= 5) && (notaTres >= 0 && notaTres <= 5))
    {
        return true;
    }
    return false;
}

double procedimiento (double notaUno, double notaDos, double notaTres)
{
    double promedio;
    const int cantidad = 3;
  
        promedio = (notaUno + notaDos + notaTres) / cantidad;
    
    return promedio;
}