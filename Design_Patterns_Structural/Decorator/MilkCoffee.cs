using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MilkCoffee : ICoffee
    {
        private readonly ICoffee mCoffee;
        public MilkCoffee(ICoffee mCoffee)
        {
            this.mCoffee = mCoffee ?? throw new ArgumentNullException("mCoffee", "mCoffee should not be null");
        }

        public int GetCost()
        {
            return this.mCoffee.GetCost() + 1;
        }

        public string GetDescription()
        {
            return mCoffee.GetDescription() + " with milk,";
        }
    }
}
