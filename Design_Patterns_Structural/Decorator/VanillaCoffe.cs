using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class VanillaCoffe : ICoffee
    {
        private readonly ICoffee mCoffee;
        public VanillaCoffe(ICoffee mCoffee)
        {
            this.mCoffee = mCoffee ?? throw new ArgumentNullException("mCoffee", "mCoffee should not be null");
        }
        public int GetCost()
        {
            return mCoffee.GetCost() + 1;
        }

        public string GetDescription()
        {
            return mCoffee.GetDescription() + " with vanilla";
        }
    }
}
