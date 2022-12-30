using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public interface IEmployee
    {
        public string Name { get; }
        public string Position { get; }
        public decimal Salary { get; }
        public string GetEmployeeName();
        public string GetEmployeePosition();
        public decimal GetEmployeeSalary();
        public string ChangeStatus(int days);

    }
}
