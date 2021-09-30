using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite subject in school?");
            string userGuess = Console.ReadLine();

            switch (userGuess)
            {
                case "Math":
                    Console.WriteLine($"Math is hard!");
                    break;
                case "English":
                    Console.WriteLine($"English helps expand your vocabulary");
                    break;
                case "Music":
                    Console.WriteLine($"Music teaches us diversity");
                    break;
                case "Science":
                    Console.WriteLine($"Science is fun");
                    break;
                case "Choir":
                    Console.WriteLine($"Choir trains our vocal cords");
                    break;

                default:
                    Console.WriteLine("That's an interesting choice!");
                    break;
        }
             

        }
    }
}
