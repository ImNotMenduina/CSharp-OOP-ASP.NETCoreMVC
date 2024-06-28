namespace EmployeePayment.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
        : base(name, hours, valuePerHour)
        { 
            AdditionalCharge = additionalCharge;
        }
    }
}
