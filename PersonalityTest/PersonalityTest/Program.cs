using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //the program asks user to entertheir favorite color 
            //the program display the usre's personality traits:
            //"red"-romantic ,"blue"-reliable , "yellow "- cheerful
            //if the user enters anything else , the program displays
            //"you are a {userInput} unnicorn."
            string FColor;
            Console.WriteLine("Enter your favorite color: " );
            FColor = Console.ReadLine();

            if (FColor=="Red")
                Console.WriteLine($"You picked {FColor}.You are romantic");
            else if (FColor == "Blue")
                Console.WriteLine($"You picked {FColor}.You are reliable ");
            else if (FColor == "Yellow")
                Console.WriteLine($"You picked {FColor}.You are cheerful ");
            else 
                Console.WriteLine($"You are a {FColor}unicorn. ");
        }
    }
}
