using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class LabDoor : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Closing lab door");
        }

        public void Open()
        {
            Console.WriteLine("Opening lab door");
        }
    }
}
