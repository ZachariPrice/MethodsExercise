using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 
            //Name: Lars
            //Favorite Color: Forest Green
            //Favorite Animal: Hippo
            //Favorite Band: Marron 5
            Console.WriteLine("Hello - What is your name?"); 
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($" Nice! {color} is fire! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("That's my favorite animal as well! What your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"All amazing choices {userName}! Here is your profile");
            Console.WriteLine("---------------------------------");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");



            Console.WriteLine($"All amazing choices {userName}! Here is your profile");
            Console.WriteLine("---------------------------------");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

        }
    }
}
