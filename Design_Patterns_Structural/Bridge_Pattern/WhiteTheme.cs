using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class WhiteTheme : ITheme
    {
        public string GetColor()
        {
            return "White";
        }
    }
}
