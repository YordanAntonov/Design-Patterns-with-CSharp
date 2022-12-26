using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am iron door");
        }
    }
}
