﻿using System;

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
                Console.Write("\nSkriv in ditt efternamn: ");
                string efternamn = Console.ReadLine();
                if (efternamn != "")
                {
                    Console.Write("\nSkriv in ditt ålder: ");
                    int ålder = Convert.ToInt32(Console.ReadLine());
                    if (ålder > 0)
                    {
                        pensionen = (pensionÅlder - ålder);

                        if (pensionen > 0)
                        {
                            Console.WriteLine("\nHej " + förnamn.ToUpper() + " " + efternamn.ToUpper() + "! " + "Det är nu " + pensionen + " år kvar till du går i pension." );
                        } 
                        else if (pensionen == 0)
                        {
                            Console.WriteLine("\nHej " + förnamn.ToUpper() + " " + efternamn.ToUpper() + "! " + "Du blir pensionär i år." );
                        } 
                        else
                        {
                            Console.WriteLine("\nHej " + förnamn.ToUpper() + " " + efternamn.ToUpper() + "! " + "Du är redan pensionär för " + Math.Abs(pensionen) + " år!!!" );
                        }

                        Console.ReadKey();
                    } 
                    else
                    {
                        Console.WriteLine("\nDet är inte din ålder !!!");
                        Console.ReadKey();
                    }
                } 
                else
                {
                    Console.Write("\nDu glömmer att skriva ditt Efternamn!!!");
                    Console.ReadKey();
                }
            } else
            {
                Console.Write("\nDu glömmer att skriva ditt Förnamn!!!");
                Console.ReadKey();
            }       
        }
    }
}