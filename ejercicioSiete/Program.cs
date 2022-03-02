// See https://aka.ms/new-console-template for more information
// Dise˜ne un algoritmos con funciones y procedimientos que indique si
//la llave de un tanque de agua debe ser abierta o cerrada. El tanque
//debe estar siempre entre 250 y 450 litros.

int litrosAgua;



int obtenerLitro()
{

}

Console.WriteLine("ingrese los litros de agua");
litrosAgua = Convert.ToInt32(Console.ReadLine());

int validacion( int listrosAgua, bool cerrado)
{
    if(listrosAgua < 250 && listrosAgua > 450)
    {
        return (false);
    }
}
