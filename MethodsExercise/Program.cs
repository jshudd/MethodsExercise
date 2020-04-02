using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name?");
            var fullName = Console.ReadLine();

            Console.WriteLine("Fave Color?");
            var faveColor = Console.ReadLine();

            Console.WriteLine("Fave Animal?");
            var faveAnimal = Console.ReadLine();

            Console.WriteLine("Fave Band?");
            var faveBand = Console.ReadLine();

            Console.WriteLine($"One day, {fullName} was walking through the woods wearing {faveColor} pants. Suddenly, a {faveAnimal} appeared with an iPod. It was listening to {faveBand}. {fullName} was surprised it liked {faveBand}, too!");
        }
    }
}
