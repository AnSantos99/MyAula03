using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c;

            c = ++a + b++;


            Console.WriteLine("{0}\t{1}\t{2}", a, b, c);
        }
    }
}
