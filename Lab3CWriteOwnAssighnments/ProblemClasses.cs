using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CWriteOwnAssighnments
{
    public class ProblemClasses
    {
        public void CalculateTuition()
        {
            Console.Clear();
            double tuition = 6000;
            Console.WriteLine("Select years of tuition: ");
            double year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"First year tuition will be {tuition:c}.");
            for (int i = 0; i < year; i++)
            {
                tuition += tuition * 0.02;
                Console.WriteLine($"Year {i + 1} tuition will be {tuition:c}.");
            }
            Console.Read();
        }

        public static void FeetToInches()
        {
            Console.Clear();
            Console.WriteLine("Number of feet: ");
            double feet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number of inches is: {feet * 12}");
            Console.Read();
        }

        public static void GreaterOfTwoNumbers()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Number 1: ");
                double num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number 2: ");
                double num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("Number 1 is greater.");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("Number 2 is greater.");
                }
                else
                {
                    Console.WriteLine("Both numbers are the same.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not a number, try again.");
            }

            Console.Read();
        }

        public void DisplayMenu()
        {
        displayMenu:
        Console.Clear();
        string display = "0";
        Console.WriteLine("Choose which thing you want to do.");
        Console.WriteLine();
        Console.WriteLine("{1}Tuition Calculator.");
        Console.WriteLine("{2}Convert feet to inches.");
        Console.WriteLine("{3}Greater of two numbers.");
        Console.WriteLine("{9}Exit.");
        Console.WriteLine();
        display = Console.ReadLine();

        while (display != "9")
            if (display == "1")
            {
                CalculateTuition();
                goto displayMenu;
            }
            else if (display == "2")
            {
                FeetToInches();
                goto displayMenu;
            }
            else if (display == "3")
            {
                GreaterOfTwoNumbers();
                goto displayMenu;
            }
            else if (display == "9")
            {
                break;
            }
            else
            {
                goto displayMenu;
            }
        }
    }
}
