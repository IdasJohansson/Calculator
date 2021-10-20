﻿using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = 0;
            bool loop = true;

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

                if (choice == '+') // Varje if-sats är en metod, dessa ligger nedanför. 
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
                Console.WriteLine("För att avsluta tryck: 3");
                start = Convert.ToInt32(Console.ReadLine());

                if (start == 2) // Om användaren väljer 2 skickas man till denna if-sats
                {
                    PreviousCalculations();
                }

                if (start == 3) // Om användaren väljer 3 skickas man till denna if-sats
                {
                    loop = false; // Denna avbryter while-loopen
                    Console.WriteLine("Nu är det färdigräknat för idag, bra jobbat! :) ");
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
                }


                // Metoder till första if-satsen

                void MethodPlus()
                {
                    Console.WriteLine("Resultatet är: " + addition);
                    string nr1 = tal1.ToString(); // Konverterar till string
                    string nr2 = tal2.ToString();
                    string userChoice = choice.ToString();
                    string result = addition.ToString(); 
                    string calculation = nr1 + userChoice + nr2 + "=" + result; // Konverterar hela uträkningen till en string
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
                    string calculation = nr1 + userChoice + nr2 + "=" + result;
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
                    string calculation = nr1 + userChoice + nr2 + "=" + result;
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
                    string calculation = nr1 + userChoice + nr2 + "=" + result;
                    calculations.Add(calculation);
                    Console.WriteLine();
                }

            } while (loop); 
        }
    }
}
