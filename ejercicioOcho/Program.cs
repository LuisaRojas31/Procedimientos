// See https://aka.ms/new-console-template for more information

//**Dise˜ne un algoritmos con funciones y procedimientos que indique si
//un n´umero entero x se encuentra por dentro o por fuera el intervalo
//cerrado-cerrado [minimoV alor, maximoV alor)]
//Por ejemplo: Si los valores m´ınimos y m´aximo son 3 y 7
//respectivamente, el valor 5 est´a dentro, mientras que el valor de 8
//est´a por fuera del intervalo

double rangoUno, rangoDos, numero;
rangoUno = preguntas("Ingrese rango uno");
rangoDos = preguntas("Ingrese rando dos");
numero = preguntas("ingrese numero");
bool rango = resultado(rangoUno, rangoDos, numero);
respuesta(rango);

int preguntas(string mensaje)
{
    Console.WriteLine(mensaje);
    return Convert.ToInt32(Console.ReadLine());
}

bool resultado (double randoUno, double randoDos, double numero)
{
    if (numero >= randoUno && numero <= randoDos)
    {
        return true;
    }
    return false;   
    
}    

void respuesta (bool rango)
{
    if (rango)
    {
        Console.WriteLine("si esta dentro del rango");
    }
    else
    {
        Console.WriteLine("No esta dentro del rango");
    }
}