using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk11_employeeWages
{
    public class FTEmployee : Employee
    {
        // attributes
        private int annualWage;

        // property
        public int AnnualWage
        {
            get { return annualWage; }
        }

        // constructor
        public FTEmployee(string ID, string Name, int AnnualWage) : base (ID, Name)
        {
            this.annualWage = AnnualWage;
        }

        // behaviour 
        public override string ToString()
        {
            return base.ToString() + $"\nAnnual Wage: ${annualWage}";
        }

        public override double employeeWage()
        {
            return annualWage / 52;
        }

    }
}
