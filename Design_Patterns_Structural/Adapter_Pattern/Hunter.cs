using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public class Hunter : IHunter
    {
        public void Hunt(ILion lion)
        {
            Console.WriteLine("I Hunt Lions");
        }
    }
}
