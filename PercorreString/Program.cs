using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            string s, cStr;
            char c;

            //pedir string
            Console.WriteLine("Input String");
            s = Console.ReadLine();

            //pedir char
            Console.WriteLine("Input Char");
            cStr = Console.ReadLine();

            //converção de string para char
            c = Convert.ToChar(cStr);

            //ciclo para percorrer a string
            foreach (char cInString in s)
            {
                if (cInString != c)
                {
                    Console.Write(cInString);
                }
            }
        }
    }
}
