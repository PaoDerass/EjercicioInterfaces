
using EjercicioInterfaces;

IOperaciones procedimientos = new Procedimientos();

Console.Write("Ingrese el largo del rectángulo: ");
double largo = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el ancho del rectángulo: ");
double ancho = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el lado del cubo: ");
double lado = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el radio del círculo: ");
double radio = Convert.ToDouble(Console.ReadLine());


(procedimientos as Procedimientos)?.Imprimir(largo, ancho, lado, radio);
Console.ReadLine();