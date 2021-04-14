using System;

namespace Pension1
{
    class Program
    {
        static void Main(string[] args)
        {
            string förnamn;
            string efternamn;
            int ålder;
            int pensionen;

            Console.BackgroundColor = ConsoleColor.Blue;
            
            Console.Write("Skriv in ditt förnamn: ");
            förnamn = (Console.ReadLine());

            Console.Write("Skriv in ditt efternamn: ");
            efternamn = Console.ReadLine();

            Console.Write("Skriv in ditt ålder: ");
            ålder = Convert.ToInt32(Console.ReadLine());

            pensionen = (65 - ålder);


            Console.WriteLine("Hej " + förnamn.ToUpper() + " " + efternamn.ToUpper() + "! " + "Det är nu " + pensionen + " år kvar till du går i pension." );

            Console.ReadKey();
        }
    }
}
