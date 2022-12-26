using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert MakeDoorFittingExpert()
        {
            return new Welder();
        }
    }
}
