//this class apply control the data, for that reason the "try-catch" in this class

using System;

namespace WebApp_OOPConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create try-catch for month
            try
            {
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
                          

                Employee salaryEmployee = new SalaryEmployee()
                {

                    Id = 1,
                    FirstName = "Patricia",
                    LastName = "Alvarez",
                    BirthDay = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
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
                    BirthDay = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = false,
                    CommissionPercentage = 5,
                    Sales = 20000000

                };
                Console.WriteLine(CommissionEmployee);
                Console.WriteLine(" ");


                Console.Write("Please type the ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type the first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Please type the last name: ");
                string fastName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Please type the if is active: ");
                bool isActive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type the number of hours: ");
                float hours = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type value per hour: ");
                decimal hoursValue = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" ");


                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = fastName,
                    BirthDay = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = isActive,
                    Hours= hours,
                    HourValue = hoursValue,                              
                };            
                Console.WriteLine(hourlyEmployee); //min. 28
                Console.WriteLine(" ");


        }
            catch (Exception message) { 
                Console.WriteLine(message); 
            }

        }
    }
}
