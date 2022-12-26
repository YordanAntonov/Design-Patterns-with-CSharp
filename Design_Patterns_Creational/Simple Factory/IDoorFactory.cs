using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    //3) After that we create the interface for the factory!
    public interface IDoorFactory
    {
        public IDoor MakeDoor(int height, int width);
    }
}
