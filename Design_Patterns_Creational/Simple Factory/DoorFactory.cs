using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    // 4) Instantiate Factory class
    public class DoorFactory : IDoorFactory
    {
        public DoorFactory()
        {

        }
        public IDoor MakeDoor(int height, int width)
        {
            IDoor currDoor = new WoodenDoor(height, width);
            return currDoor;
        }
    }

    //5) Implement it in the Main method!
}
