using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            
            while (true)
            { 
                Console.WriteLine("Are you good?");
                answer = Console.ReadLine();

                if (answer == "yes" || answer == "YES")
                {
                    Console.WriteLine("Oh thats nice... Are you gonna ask me " +
                        "how i am?");
                    answer = Console.ReadLine();
                    if (answer == "no" || answer == "NO")
                    {
                        Console.WriteLine("Okay.. I guess i will go now BYE!");
                    }
                    else if (answer == "yes" || answer == "YES")
                    {
                        Console.WriteLine("Thanks for asking! Am fine bye!");
                    }
                }

                else if (answer == "no")
                {
                    Console.WriteLine("Oh well it happens.");
                }
            }

        }
    }
}
