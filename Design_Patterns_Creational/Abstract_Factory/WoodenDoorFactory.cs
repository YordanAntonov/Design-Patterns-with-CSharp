using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert MakeDoorFittingExpert()
        {
            return new Carpenter();
        }
    }
}
