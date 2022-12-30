using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public class WildDogAdapter : ILion
    {
        private WildDog mDog;

        public WildDogAdapter(WildDog dog)
        {
            mDog = dog;
        }
        public void Roar()
        {
            mDog.Bark();
        }
    }
}
