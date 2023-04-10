namespace MethodeOverridingRDemo
{
    public class EmployeeModel : PersonModel 
    {
        public decimal HourlyRate { get; set; }
        public virtual decimal GetPayCheckAmount(int hoursWorked) 
        {

            return HourlyRate * hoursWorked;
        }
    }


}
