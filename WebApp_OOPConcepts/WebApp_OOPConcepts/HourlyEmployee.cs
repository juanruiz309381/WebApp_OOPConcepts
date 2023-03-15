namespace WebApp_OOPConcepts
{
    internal class HourlyEmployee : Employee
    {
        #region Property
        public decimal Salary { get; set; } //{get; set; }???
        #endregion
        //23:00

        public float Hours { get; set; }
        public decimal HourValue { get; set; }


        public override decimal GetValueToPay()
        {
            return HourValue * (decimal)Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" + 
                $"Hours.................{Hours}\n\t" +
                $"Value per Hours.......{HourValue:C2}\n\t" +
                $"Get value to pay......{GetValueToPay():C}\n\t"; 
        }
    }
}
