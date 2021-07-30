using System;

namespace Tres_números
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double a;
            double b;
            double c;

            //cargar datos
            Console.Write("Primer número: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Tercer número: ");
            c = Double.Parse(Console.ReadLine());

            //menu
            Console.WriteLine("\n Elige alguna de las dos opciones presionando 1 o 2");

            Console.WriteLine("\n Validar suma" + "(" + "1" + ")");
            Console.WriteLine("Salida" + "(" + "2" + ")");

            Console.Write("\n Ingrese el número de su elección: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (numero)
            {
                case 1:
                    Console.WriteLine("SON IGUALES");
                    break;
                case 2:
                    Console.WriteLine("SON DISTINTOS");

                    Console.WriteLine("\n Hasta luego!");
                    break;
                default:
                    Console.WriteLine("No es un número válido");
                    break;
            }
            Console.ReadKey();

        }
    }
}
