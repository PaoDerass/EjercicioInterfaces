using EjercicioInterfaces;

public class Procedimientos : IOperaciones
{
    public double AreaRectangulo(double largo, double ancho)
    {
        return largo * ancho;
    }

    public double PerimetroRectangulo(double largo, double ancho)
    {
        return 2 * (largo + ancho);
    }

    public double VolumenCubo(double lado)
    {
        return Math.Pow(lado, 3);
    }

    public double AreaCubo(double lado)
    {
        return 6 * Math.Pow(lado, 2);
    }

    public double Circunferencia(double radio)
    {
        return 2 * Math.PI * radio;
    }

    public void Imprimir(double largo, double ancho, double lado, double radio)
    {
        Console.WriteLine($"Área del rectángulo: {AreaRectangulo(largo, ancho)}");
        Console.WriteLine($"Perímetro del rectángulo: {PerimetroRectangulo(largo, ancho)}");
        Console.WriteLine($"Volumen del cubo: {VolumenCubo(lado)}");
        Console.WriteLine($"Área del cubo: {AreaCubo(lado)}");
        Console.WriteLine($"Circunferencia del círculo: {Circunferencia(radio)}");
    }
}
