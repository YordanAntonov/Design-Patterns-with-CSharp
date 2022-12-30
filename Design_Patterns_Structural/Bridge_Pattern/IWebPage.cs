using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public interface IWebPage
    {
        void GetContent();

        void ChangeThemeColor(ITheme theme);
    }
}
