﻿using System;
namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tHomeWork 2");
            Console.WriteLine();
            //part 1
            Console.WriteLine("\tPart 1");
            Console.Write("Input first  float number: \t");
            float firstValue = float.Parse(Console.ReadLine());
            if (firstValue > (-5) && firstValue < 5)
            {
                Console.WriteLine($"Argument {firstValue} within range [-5.5]");
            }
            else
            {
                Console.WriteLine($"Argument {firstValue} out of range [-5.5]");
            }
            Console.Write("Input second  float number: \t");
            float secondValue = float.Parse(Console.ReadLine());
            if (secondValue > (-5) && secondValue < 5)
            {
                Console.WriteLine($"Argument {secondValue} within range [-5.5]");
            }
            else
            {
                Console.WriteLine($"Argument {secondValue} out of range [-5.5]");
            }
            Console.Write("Input third  float number: \t");
            float thirdValue = float.Parse(Console.ReadLine());
            if (thirdValue > (-5) && thirdValue < 5)
            {
                Console.WriteLine($"Argument {thirdValue} within range [-5.5]");
            }
            else
            {
                Console.WriteLine($"Argument {thirdValue} out of range [-5.5]");
            }
            Console.WriteLine("For next step type Enter");
            Console.ReadLine();

            //part 2
            Console.WriteLine("\tPart 2");
            int[] arr2 = new int[3];
            Console.Write("Input first number: \t");
            arr2[0] = int.Parse(Console.ReadLine());
            Console.Write("Input second number: \t");
            arr2[1] = int.Parse(Console.ReadLine());
            Console.Write("Input third number: \t");
            arr2[2] = int.Parse(Console.ReadLine());

            int min = arr2[0];
            for (int i = 1; i < arr2.Length; i++)
            {
                if (arr2[i] < min)
                {
                    min = arr2[i];
                }
            }
            int max = arr2[0];
            for (int i = 1; i < arr2.Length; i++)
            {
                if (arr2[i] > max)
                {
                    max = arr2[i];
                }
            }
            Console.WriteLine($"Min value is {min}");
            Console.WriteLine($"Max value is {max}");
            Console.WriteLine("For next step type Enter");
            Console.ReadLine();

            //part 3
            Console.WriteLine("\tPart 3");
            Console.Write("Enter number of status code: \t");
            int value = int.Parse(Console.ReadLine());
            HTTPError error = (HTTPError)value;
            Console.WriteLine($"{value} it means {error}");
            Console.WriteLine("For next step type Enter");
            Console.ReadLine();

            //part 4
            Console.WriteLine("\tPart 4");
            Dog myDog = new Dog();
            myDog.Name = "Brick";
            myDog.Mark = "Mustiff";
            myDog.Age = "4";
            Console.WriteLine(myDog);
            Console.WriteLine();
            Console.WriteLine("Thank you for your work!");
            Console.ReadLine();
        }
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
            Not_Found,
            Method_Not_Allowed
        }
        struct Dog
        {
            public string Name;
            public string Mark;
            public string Age;
            public override string ToString()
            {
                return $"Your dog`s name is {Name}, it is {Mark}, it is {Age} years old";
            }
        }
    }
}
