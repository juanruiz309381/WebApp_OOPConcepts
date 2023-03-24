namespace WebApp_OOPConcepts
{
    internal class BaseCommissionEmployee : CommissionEmployee
    {
        #region Property
        public decimal Base { get; set; } 

        #endregion
        
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Base............{Base:C2}\n\t" +               
                $"Total...........{GetValueToPay():C2}\n\t";

        }   
    }
}
