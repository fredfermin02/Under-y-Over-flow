using System;

namespace Overflow_y_underflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma(200,215);

        }
        public static void Suma(byte a, byte b)
        {
        checked {

        try {
           byte suma = (byte)(a+b);
        }
        catch (OverflowException) {
           Console.WriteLine("Hay un overflow en la suma");
        }
        }


        }
        public static void Resta(byte a, byte b)
        {

            if (a - b < byte.MinValue)
            {
                Console.WriteLine("Hay un underflow");
            }
            else
            {
              Console.WriteLine("Tipo de dato correcto: "+ (a+b));
            }
        }
    }
}
