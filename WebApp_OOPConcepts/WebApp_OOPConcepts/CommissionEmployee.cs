namespace WebApp_OOPConcepts
{
    internal class CommissionEmployee : Employee
    {
        #region Property
        public double CommissionPercentage { get; set; } 
        public decimal Sales { get; set; } 

        #endregion
        
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentage/100;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commission percentage........{CommissionPercentage:P2}\n\t" + //Percentage
                $"Sales........................{Sales:C2}\n\t" +
                $"Get value to pay.............{GetValueToPay():C2}\n\t";

        }
    }
}
