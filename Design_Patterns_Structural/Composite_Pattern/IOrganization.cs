using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public interface IOrganization
    {
        string Name { get; }
        IReadOnlyCollection<IEmployee> Employees { get; }

        public decimal GetNetSalary();

        public void Hire(IEmployee employe);

        public bool Fire(string employeeName);
    }
}
