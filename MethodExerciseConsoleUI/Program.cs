using System;
using System.Net.NetworkInformation;

namespace MethodExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add(5, 5);
            Console.WriteLine(result);

            var result2 = Multiply(10, 25);
            Console.WriteLine(result2);

            var result3 = Divide(50, 10);
            Console.WriteLine(result3);

            var result4 = Subtract(60, 7);
            Console.WriteLine(result4);

            Console.WriteLine("Please enter your name");
            var yourName = Console.ReadLine();           

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();            

            Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();           

            Console.WriteLine("What is your favorite animal ?");
            var favoriteAnimal = Console.ReadLine();
            
            Console.WriteLine("What's your favorite band?");
            var musicalBand = Console.ReadLine();
            
            string Name;
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();

            Console.WriteLine("State your age:");
            var yourAge = Console.ReadLine();
            
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            
            Console.WriteLine("What animal do you like best?");
            var animal = Console.ReadLine();
            
            Console.WriteLine("What is your favorite band of all time?");
            var band = Console.ReadLine();
            Console.WriteLine($"My favorite band of all time is {band}, John Bonham is the best drummer ever!");

            Console.WriteLine($"Hello, my name is {Name}. I am {yourAge} years old and my favorite band is {band}. My favorite color is {color} and my favorite animal is {animal}.");
            Console.WriteLine($"It's very nice to meet you {Name}! We have a lot in common because my favorite band is {band}, my favorite color is {color} and my favorite animal is {animal}. We're also the same age since my age is also {age}");
                        
        }

        public static int Add(int num1, int num2)

        {
            var result = num1 + num2;
            return result;
        }
        public static int Multiply(int num1, int num2)

        {
            var result2 = num1 * num2;
            return result2;
        }

        public static int Divide(int num1, int num2)

        { var result3 = num1 / num2;
            return result3;

        }
        public static int Subtract(int num1, int num2)

        {
            var result4 = num1 - num2;
            return result4;
        }
    }
}
