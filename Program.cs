using System;

namespace Pension
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensionÅlder = 65;
            int pensionen;

            Console.BackgroundColor = ConsoleColor.Blue;
            
            Console.Write("Skriv in ditt förnamn: ");
            string förnamn = Console.ReadLine();
            if (förnamn != "")
            {
                Console.Write("Skriv in ditt efternamn: ");
                string efternamn = Console.ReadLine();
                if (efternamn != "")
                {
                    Console.Write("Skriv in ditt ålder: ");
                    int ålder = Convert.ToInt32(Console.ReadLine());
                    if (ålder > 0)
                    {
                        pensionen = (pensionÅlder - ålder);

                        if (pensionen > 0)
                        {
                            Console.WriteLine("Hej " + förnamn.ToUpper() + " " + efternamn.ToUpper() + "! " + "Det är nu " + pensionen + " år kvar till du går i pension." );
                        } 
                        else if (pensionen == 0)
                        {
                            Console.WriteLine("Hej " + förnamn.ToUpper() + " " + efternamn.ToUpper() + "! " + "Du blir pensionär i år." );
                        } 
                        else
                        {
                            Console.WriteLine("Hej " + förnamn.ToUpper() + " " + efternamn.ToUpper() + "! " + "Du är redan pensionär." );
                        }

                        Console.ReadKey();
                    } 
                    else
                    {
                        Console.WriteLine("Det är inte din ålder !!!");
                        Console.ReadKey();
                    }
                } 
                else
                {
                    Console.Write("Du glömmer att skriva ditt Efternamn!!!");
                    Console.ReadKey();
                }
            } else
            {
                Console.Write("Du glömmer att skriva ditt Förnamn!!!");
                Console.ReadKey();
            }       
        }
    }
}
