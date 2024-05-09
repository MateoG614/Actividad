using System;

public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

public class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Circulo circulo = new Circulo { Radio = 5 };
        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };

        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
    }
}
