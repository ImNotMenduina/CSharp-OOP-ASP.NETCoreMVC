using System.Globalization;

namespace EmployeePayment.Entities
{
    internal class Employee
    {
        protected string _name;
        protected int _hours;
        protected double _valuePerHour;

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            this._name = name;
            this._hours = hours;
            this._valuePerHour = valuePerHour;
        }

        public string Name { get { return _name; } }
        public int Hours { get { return _hours; } }
        public double ValuePerHour {  get { return _valuePerHour; } }
        public virtual double payment() {  
            return _valuePerHour * _hours; 
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
