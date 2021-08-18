using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk11_employeeWages
{
    public class CSEmployee : Employee
    {
        // attributes
        private double ratePerHour;
        private double hoursWorked;

        // property
        public double Rate
        {
            get { return ratePerHour; }
        }
        public double Hours
        {
            get { return hoursWorked; }
        }

        // constructor
        public CSEmployee(string ID, string Name, double Rate, double Hours) : base (ID, Name)
        {
            this.ratePerHour = Rate;
            this.hoursWorked = Hours;
        }

        public override string ToString()
        {
            return $"Employee ID: {ID} \nEmployee Name: {Name} \nRate: ${ratePerHour} \nHours: {hoursWorked}";
        }

        public override double employeeWage()
        {
            return ratePerHour * hoursWorked;
        }

    }
}
