using System.Globalization;

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
        public override double payment()
        {
            return base.payment() + (1.1 * AdditionalCharge);
        }
        public override string ToString()
        {
            return "Name: "
                + _name
                + ", Hours: "
                + _hours
                + ", Value/Hour: "
                + _valuePerHour.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
