using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public abstract class Employee : IEmployee
    {
        private const decimal MinimumSalary = 1000;
        private string name;
        private decimal salary;
        private string position;
        private string status;


        protected Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
            this.status = "Active";
            this.Position = this.GetType().Name;
        }
        public string Name
        {
            get { return name;  } 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect Name");
                }
                name = value;
            }
        }

        public string Position
        {
            get { return position; }
            private set
            {
                if (value != nameof(Developer) && value != nameof(SolutionAnalyst))
                {
                    throw new ArgumentException("Invalid position");
                }
                position = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < MinimumSalary)
                {
                    throw new ArgumentException("Salary cannot be under the minimum wage!");
                }
                salary = value;
            }
        }
        public string ChangeStatus(int days)
        {
            string status = "Active";
            if ( days <= 1)
            {
                status = "Away";
                
            }
            else
            {
                status = "In Vacation"; 
            }
            this.status = status;
            return this.status;
        }

        public string GetEmployeeName()
        {
            return this.Name;
        }

        public string GetEmployeePosition()
        {
            return this.Position;
        }

        public decimal GetEmployeeSalary()
        {
            return this.Salary;
        }
    }
}
