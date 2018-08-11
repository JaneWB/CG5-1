using System;

namespace CG5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user to enter their first name. Then have it enter their last name.
            //Create a method that combines the first and last name and returns it as a new value. Print the new value.
            //Upload your program to a new repository called CG 5 - 1.
            //Upload a link to your repository here when you are finished.

            Console.WriteLine("What is your first name?");
            string myFirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string myLastName = Console.ReadLine();

            //string myName = fullName(myFirstName, myLastName);
            //Console.WriteLine("Hello " + myName);
            //or
            Console.WriteLine("Hello " + fullName(myFirstName, myLastName));
            Console.ReadLine();



        }
        /// <summary>
        /// First and last name.
        /// </summary>
        /// <param name="myFirstName"></param>
        /// <param name="myLastName"></param>
        /// <returns>First and name</returns>
        private static string fullName(string myFirstName, string myLastName)
        {
            return (myFirstName + " " + myLastName);
        }
                    
          
      
    }
}
