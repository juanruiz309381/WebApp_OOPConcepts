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
        public string Id { get; set; }
        public string FirstName { get; set; }
        public Date BirthDay { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        public abstract decimal GetValueToPay(); //Para metodos abstractos

        public override string ToString()
        {
            return ("$---EMPLOYEE---\n\t" +
                $"ID....{Id}\n\t" +
                $"First Name" +
                $"Last Name" +
                $"Birth Day" +
                $"")
                ;
        }

    }
}
