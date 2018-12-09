using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the type of Calculator: \"1\" for Basic Calcualtor, \"2\" for Advanced Calculator \"3\" for BMI Calculator: ");
            int typeOfCalculator = Convert.ToInt32(Console.ReadLine());

            switch (typeOfCalculator)
            {
                case 1:

                    Console.Write("Choose the type of operation: \"1\" to Add, \"2\" to Subract, \"3\" to Mutliply, \"4\" to Divide: ");
                    string typeOfOperation = Console.ReadLine();

                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the first number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    if (typeOfOperation == "1")
                    {
                        Console.WriteLine(num1 + num2); 
                    } else if(typeOfOperation == "2")
                    {
                        Console.WriteLine(num1 - num2);
                    } else if(typeOfOperation == "3")
                    {
                        Console.WriteLine(num1 * num2);
                    } else if(typeOfOperation == "4")
                    {
                        Console.WriteLine(num1 / num2);
                    } else
                    {
                        Console.WriteLine("Unexpected error");
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Choose \"1\" for squareroot or \"2\" for Power Number: ");
                    string typeOfOperation1 = Console.ReadLine();

                    if (typeOfOperation1 == "1")
                    {
                        Console.Write("Enter a number: ");
                        double numsq = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(numsq));

                    }else if (typeOfOperation1 == "2")
                    {
                        Console.Write("Enter the base number: ");
                        double numpw1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the power number: ");
                        double numpw2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Pow(numpw1, numpw2));
                    }else
                    {
                        Console.WriteLine("Invalid input");
                    }

                    Console.ReadLine();
                    break;


                case 3:

                    Console.Write("Choose the unit measurement: \"1\" for Metric and \"2\" for Imperial: ");
                    string typeOfUnits = Console.ReadLine();

                    if(typeOfUnits == "1")
                    {
                        Console.Write("Enter weight in Kilograms: ");
                        double numKg = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter height in meters: ");
                        double numM = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(numKg/(numM * numM));

                    }else if (typeOfUnits == "2")
                    {
                        Console.Write("Enter weight in lb: ");
                        double numKg1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter height in inches: ");
                        double numM1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine((numKg1 * 703 )/ (numM1 * numM1));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
