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

                    Id = 100,
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

                    Id = 200,
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

                
                /*
                 * created object propertyRead
                 */
                PropertyRead propertyRead = new PropertyRead();
                Employee hourlyEmployee = new HourlyEmployee()
                {
                    
                    Id = propertyRead.id,
                    FirstName = propertyRead.firstName,
                    LastName = propertyRead.lastName,
                    BirthDay = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = propertyRead.isActive,
                    Hours= propertyRead.hours,
                    HourValue = propertyRead.hourValue,                              
                };            
                Console.WriteLine(hourlyEmployee); //min. 28
                Console.WriteLine(" ");

                Employee BaseCommissionEmployee = new BaseCommissionEmployee()
                {

                    Id = 400,
                    FirstName = "Armando",
                    LastName = "Tirado",
                    BirthDay = new Date(year, month, day),
                    HiringDate = new Date(year, month, day),
                    IsActive = true,
                    CommissionPercentage = 10,
                    Sales = 30000000,
                    Base = 5000000

                };
                Console.WriteLine(BaseCommissionEmployee);
                Console.WriteLine(" ");
            }
            catch (Exception message) { 
                Console.WriteLine(message); 
            }

        }
    }
}
