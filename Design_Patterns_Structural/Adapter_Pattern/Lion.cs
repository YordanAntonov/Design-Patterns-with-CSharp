using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public class Lion : ILion
    {
        public void Roar()
        {
            Console.WriteLine("ROAAR");
        }
    }
}
