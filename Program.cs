using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detta vill jag göra: 
            //1. Gör en uträkning
            //2. Välj mellan att se tidigare uträkning eller göra en ny uträkning.....
            // ...skriv hela programmet med pseudokod för att styra upp. 

            int start = 0;

            // Gör om hela detta stycket till en metod? 
            Console.WriteLine("Välkommen till Miniräknaren!");
            Console.WriteLine();
            Console.Write("Skriv in ditt namn: ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hej {0}, vad kul att se dig :) ", userName);
            Console.WriteLine("I den här miniräknaren kommer du få mata in två tal, välja ett räknesätt och se sen resultatet.");
            Console.WriteLine("Tryck 1 för att börja räkna.");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Vart ska jag ha en bool???

            List<string> calculations = new List<string>(); // Min tomma lista

            do
            {
                Console.Write("Skriv in tal 1: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Skriv in tal 2: ");
                int tal2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Välj ett räknesätt: +, -, *, /: ");
                char choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                Console.Write("{0} {1} {2} ", tal1, choice, tal2);

                int addition = tal1 + tal2;
                int subtraktion = tal1 - tal2;
                int multiplikation = tal1 * tal2;
                double division = (double)tal1 / tal2;

                if (choice == '+') // Varje if-sats är en metod, dessa ligger nedanför. Gör hela if-satsen till en metod?
                {
                    MethodPlus();
                }
                else if (choice == '-')
                {
                    MethodMinus();
                }
                else if (choice == '*')
                {
                    MethodMultiplication();
                }
                else if (choice == '/')
                {
                    MethodDivision();
                }

                Console.WriteLine("För att fortsätta räkna tryck: 1");
                Console.WriteLine("För att se en sammanställning på dina tidigare uträkningar tryck: 2");
                start = Convert.ToInt32(Console.ReadLine());

                // Metoder

                void MethodPlus()
                {
                    Console.WriteLine("Resultatet är: " + addition);
                    string nr1 = tal1.ToString(); // Konverterar till string
                    string nr2 = tal2.ToString();
                    string userChoice = choice.ToString();
                    string result = addition.ToString(); // Denna behövs inte...för att? Konverteras den till string för att den skrivs ut i en textsträng ovan?
                    string calculation = nr1 + userChoice + nr2 + "=" + addition; // Konverterar hela uträkningen till en string
                    calculations.Add(calculation); // Lägger till min textsträng i min lista
                    Console.WriteLine();
                }

                void MethodMinus()
                {
                    Console.WriteLine("Resultatet är: " + subtraktion);
                    string nr1 = tal1.ToString();
                    string nr2 = tal2.ToString();
                    string userChoice = choice.ToString();
                    string result = subtraktion.ToString();
                    string calculation = nr1 + userChoice + nr2 + "=" + subtraktion;
                    calculations.Add(calculation);
                    Console.WriteLine();
                }

                void MethodMultiplication()
                {
                    Console.WriteLine("Resultatet är: " + multiplikation);
                    string nr1 = tal1.ToString();
                    string nr2 = tal2.ToString();
                    string userChoice = choice.ToString();
                    string result = multiplikation.ToString();
                    string calculation = nr1 + userChoice + nr2 + "=" + multiplikation;
                    calculations.Add(calculation);
                    Console.WriteLine();
                }

                void MethodDivision()
                {
                    Console.WriteLine("Resultatet är: " + division);
                    string nr1 = tal1.ToString();
                    string nr2 = tal2.ToString();
                    string userChoice = choice.ToString();
                    string result = division.ToString();
                    string calculation = nr1 + userChoice + nr2 + "=" + division;
                    calculations.Add(calculation);
                    Console.WriteLine();
                }

            } while (start == 1); // Detta villkoret uppfylls när användaren trycker 1. 

            // Lägg även denna if-sats i do while loopen ändra till en bool någonstans.
            if (start == 2) // Om användaren väljer 2 skickas man till denna if-sats
            {
                PreviousCalculations();
            }

            // Metod
            void PreviousCalculations()
            {
                Console.WriteLine();
                Console.WriteLine("Tidigare uträkningar: ");
                foreach (string item in calculations)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Nu är det färdigräknat för idag, bra jobbat! :) "); // Hade varit kul att kunna välja att börja räkna igen här
            }


            // Slut.
        }
    }
}
