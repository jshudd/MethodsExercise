using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            //Console.WriteLine("Name?");
            //var fullName = Console.ReadLine();

            //string interpolation with $
            //Console.WriteLine($"Hi, {fullName}, what's your fave color?");
            //var faveColor = Console.ReadLine();

            //Console.WriteLine("Fave Animal?");
            //var faveAnimal = Console.ReadLine();

            //Console.WriteLine("Fave Band?");
            //var faveBand = Console.ReadLine();

            //Console.WriteLine($"One day, {fullName} was walking through the woods wearing {faveColor} pants. Suddenly, a {faveAnimal} appeared with an iPod. It was listening to {faveBand}. {fullName} was surprised it liked {faveBand}, too!");

            //start Exercise 2 code

            Console.WriteLine("1st Number?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2nd Number?");
            int num2 = int.Parse(Console.ReadLine());

            var num3 = Add(num1, num2);
            Console.WriteLine(num3);
        }

        public static int Add(int num1, int num2)
        {
           int num3 = num1 + num2;
           return num3;

        }
    }

}
