using System;
namespace WebApp_OOPConcepts
{
    internal class PropertyRead 
    {

        /*
         * This methods are use in class program
         * 
         */
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public float hours { get; set; }
        public decimal hourValue { get; set; }
        public Date birthDay { get; set; }
        public Date hiringDate { get; set; }
        public bool isActive { get; set; }
        public 
            PropertyRead() {
                Console.Write("Please type the ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type the first name: ");
                firstName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Please type the last name: ");
                lastName = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Please type the if is active: ");
                isActive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type the number of hours: ");
                hours = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Please type value per hour: ");
                hourValue = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" ");



        }
                            
        
    }
}
