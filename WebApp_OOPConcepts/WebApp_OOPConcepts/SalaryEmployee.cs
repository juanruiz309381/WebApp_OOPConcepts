﻿namespace WebApp_OOPConcepts
{
    internal class SalaryEmployee : Employee
    {
        #region Property
        public decimal Salary { get; set; } //{get; set; }???
        #endregion
        //23:00
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" + //base same to super in java
                $"Salary........{GetValueToPay():C2}"; //Currency with 2 decimals
        }
    }
}
