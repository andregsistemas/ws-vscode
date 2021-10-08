using System;

namespace saidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            double B, b, h, area;

            B = 8.0;
            b = 6.0;
            h = 5.0;

            area = (( b + B ) /2)  * h;

            Console.WriteLine( area );
        }
    }
}