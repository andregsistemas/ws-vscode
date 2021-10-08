using System;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
              int a, b, d;
           double resultado, c;

            a = 5;
            b = 2;
            c = 5.0;
            d = (int) a;


           resultado = (double) a / b;

           Console.WriteLine (resultado);
           Console.WriteLine();
           Console.WriteLine (d);

        }
    }
}
