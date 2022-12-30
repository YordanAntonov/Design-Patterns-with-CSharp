using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WhipCoffee : ICoffee
    {
        private readonly ICoffee mCoffee;
        public WhipCoffee(ICoffee mCoffee)
        {
            this.mCoffee = mCoffee ?? throw new ArgumentNullException(nameof(mCoffee), "mCoffee should not be null");
        }

        public int GetCost()
        {
            return this.mCoffee.GetCost() + 1;
        }

        public string GetDescription()
        {
            return this.mCoffee.GetDescription() + " with whip,";
        }
    }
}
