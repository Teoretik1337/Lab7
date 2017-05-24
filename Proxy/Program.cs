using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main()
        {
            // Эземпляр заместителя
            ICalculate p = new CalculateProxy();

            // Вычисления при помощи заместителя
            Console.WriteLine("In proxy : 178 + 21 = " + p.Sum(178, 21));
            Console.WriteLine("In proxy : 178 - 21 = " + p.Sub(178, 21));
            Console.WriteLine("In proxy : 178 * 21 = " + p.Mult(178, 21));
            Console.WriteLine("In proxy : 178 / 21 = " + p.Div(178, 21));

            Console.Read();
        }
    }
}
