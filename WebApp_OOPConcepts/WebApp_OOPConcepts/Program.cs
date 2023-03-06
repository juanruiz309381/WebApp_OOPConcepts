//this class apply control the data, for that reason the "try-catch" in this class

//Obs. I cannot send the last part to github
using System;

namespace WebApp_OOPConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create try-catch for month
            try {
                Console.WriteLine("**************************");
                Console.WriteLine("My first day class");
                Console.WriteLine("**************************");

                Console.WriteLine("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                var dateObject = new Date(year, month, day);
                Console.WriteLine("The data entered is: "+ dateObject);
            }
            catch (Exception message) { 
                Console.WriteLine(message); 
            }

        }
    }
}
