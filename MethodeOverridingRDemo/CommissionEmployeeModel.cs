namespace MethodeOverridingRDemo
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPayCheckAmount(int hoursWorked)
        {
            decimal initialPay =  base.GetPayCheckAmount(hoursWorked);
            return initialPay + CommissionAmount;
        }
    }

}
