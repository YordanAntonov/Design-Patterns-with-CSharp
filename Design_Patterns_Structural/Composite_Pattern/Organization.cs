using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Organization : IOrganization
    {
        private string name;
        private List<IEmployee> employees;
        public Organization()
        {
            employees = new List<IEmployee>();
        }

        public Organization(string name) : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }

        public IReadOnlyCollection<IEmployee> Employees => employees.AsReadOnly();


        public decimal GetNetSalary()
        {
            decimal total = 0;
            employees.ForEach(e => total += e.Salary);
            return total;
        }
        public bool Fire(string employeeName)
        {
            return employees.Remove(employees.FirstOrDefault(e => e.Name == employeeName));
        }

        public void Hire(IEmployee employe)
        {
            IEmployee currEmployee = employees.FirstOrDefault(e => e.Name == employe.Name);
            if (currEmployee != null)
            {
                Console.WriteLine("Employee already hired!");
            }
            else
            {
                employees.Add(employe);
                Console.WriteLine("New Employee hired!");
            }

        }
    }
}
