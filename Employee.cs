using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk11_employeeWages
{
    public abstract class Employee
    {
        // attributes
        private string employeeID;
        private string employeeName;

        // property
        public string ID
        {
            get { return employeeID; }
        }
        public string Name
        {
            get { return employeeName; }
        }

        // constructor 
        public Employee(string ID, string Name)
        {
            this.employeeID = ID;
            this.employeeName = Name;
        }

        // behaviour 
        public override string ToString()
        {
            return $"Employee ID: {employeeID} \nEmployee Name: {employeeName}";
        }

        public abstract double employeeWage();


    }
}
