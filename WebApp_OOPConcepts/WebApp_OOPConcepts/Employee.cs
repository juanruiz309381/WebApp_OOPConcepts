using System;
using System.Collections.Generic;
using System.Text;
/*
 * nn
 * -Siempre que se hable de dinero se pone con "decimal"
 * -base en C# es el super en java
 * -Casting (decimal) e.g
 * -Utilizar constantes en la interfaz
 * 
 * 
*/
namespace WebApp_OOPConcepts
{
    public abstract class Employee
    {
        #region
        //prop ,, Para los booleanos se pone un Is 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDay { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        public abstract decimal GetValueToPay(); //Abstact method

        public override string ToString()
        {
            return ("$---EMPLOYEE---\n\t" +
                $"ID....{Id}\n\t" +
                $"First Name.....{FirstName}\n\t" +
                $"Last Name.....{LastName}\n\t" +
                $"Birth Day.....{BirthDay}\n\t" +
                $"Hiring date.....{HiringDate}\n\t"+
                $"Is active?.....{IsActive}\n\t")
                ;
        }

    }
}
