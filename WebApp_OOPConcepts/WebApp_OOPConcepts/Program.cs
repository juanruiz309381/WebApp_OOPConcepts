//this class apply control the data, for that reason the "try-catch" in this class

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

                Employee salaryEmployee = new SalaryEmployee() { 
                
                    Id = 1,
                    FirstName = "Patricia",
                    LastName = "Alvarez",
                    BirthDay = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = 1160000
                };
                Console.WriteLine(salaryEmployee); //Same to say salaryEmployee.ToString()
                Console.WriteLine(" ");

                Employee CommissionEmployee = new CommissionEmployee()
                {

                    Id = 1,
                    FirstName = "Julio",
                    LastName = "Perez",
                    BirthDay = dateObject,
                    HiringDate = dateObject,
                    IsActive = false,
                    CommissionPercentage= 0.05,
                    Sales = 20000000 
                 
                };
                Console.WriteLine(salaryEmployee); //Same to say salaryEmployee.ToString()


            }
            catch (Exception message) { 
                Console.WriteLine(message); 
            }

        }
    }
}
