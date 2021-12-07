using System;

namespace exercisesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that asks for user's first and last name 
            // the program greets the user by their name 
            //the program ask the user to enter their year of birth and calculates the user's age
            //*Convert.ToInt32(stringToConvert);
            //if the user is 13 or older,then the program display "Welcome to Instagram " 
            //otherwice the program display "You are too young to have the Instagram account"
            string fName, lName;
        
            int yearOfBirth;
            Console.WriteLine("Enter yout fName:");
            fName = Console.ReadLine();
            Console.WriteLine("Enter yout lastName:");
            lName = Console.ReadLine();
           
            Console.WriteLine($"Hello ,{fName} {lName}");

            Console.WriteLine("enter your year of birth ");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());
            int age = currentYear - yearOfBirth;

            
            if (age>13)
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Not old enough");






        }
    }
}
