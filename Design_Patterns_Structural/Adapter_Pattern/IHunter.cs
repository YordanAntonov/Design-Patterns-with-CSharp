using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public interface IHunter
    {
        void Hunt(ILion lion);
    }
}
