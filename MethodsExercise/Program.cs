using System;

namespace MethodsExercise
{
    class Program
    {
        // Exercise 2 Methods
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

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

            var amountOfCars = Sum(2, 6);
            Console.WriteLine($"There are {amountOfCars} cars");

            var blah = Multiply(60, 2, 4);
            Console.WriteLine(blah);

        }
    }

}
