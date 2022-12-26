using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public interface IDoorFactory
    {
        public IDoor MakeDoor();

        public IDoorFittingExpert MakeDoorFittingExpert();
    }
}
