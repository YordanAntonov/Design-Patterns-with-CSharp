using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark";
        }
    }
}
