using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimpleCoffee : ICoffee
    {
        private const int SimpleCoffeePrice = 5;
        public int GetCost()
        {
            return SimpleCoffeePrice;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
