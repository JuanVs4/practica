internal class Program
{
    private static void Main(string[] args)

    {
        {

            {
                Console.WriteLine("Resolver la ecuación de primer grado: a * x + b = 0");

                // Pedir el coeficiente a
                Console.Write("Ingrese el coeficiente a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                // Pedir el coeficiente b
                Console.Write("Ingrese el coeficiente b: ");
                double b = Convert.ToDouble(Console.ReadLine());


                // Calcular la solución
                if (a == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("La ecuación tiene infinitas soluciones.");
                    }
                    else
                    {
                        Console.WriteLine("La ecuación no tiene solución.");
                    }
                }
                else
                {
                    double x = -b / a;
                    Console.WriteLine($"La solución de la ecuación es: x = {x}");
                }
            }
        }





    }
}