using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Developer : Employee
    {
        public Developer(string name, decimal salary) : base(name, salary)
        {
        }
    }
}
