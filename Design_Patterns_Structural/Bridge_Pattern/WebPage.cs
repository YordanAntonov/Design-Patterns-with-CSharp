using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class WebPage : IWebPage
    {
        protected ITheme theme;

        public WebPage(ITheme theme)
        {
            this.theme = theme;
        }

        public void ChangeThemeColor(ITheme theme) => this.theme = theme;
        

        public void GetContent()
        {
            Console.WriteLine($"The theme of this page is {this.theme.GetColor()}");
        }
    }
}
