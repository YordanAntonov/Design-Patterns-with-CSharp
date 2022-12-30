using System;
using System.Buffers.Text;

namespace Bridge_Pattern
{
    public class BridgePattern
    {
        //*** Real world example:

        //Consider you have a website with different pages and you are supposed to allow the user to change the theme.What would you do? Create multiple copies of each of the pages for each of the themes or would you just create separate theme and load them based on the user's preferences? Bridge pattern allows you to do the second i.e.

        //*** In Plain Words:

        //        Bridge pattern is about preferring composition over inheritance.Implementation details are pushed from a hierarchy to another object with a separate hierarchy.

        //*** Wikipedia says:

        //The bridge pattern is a design pattern used in software engineering that is meant to "decouple an abstraction from its implementation so that the two can vary independently"

        static void Main(string[] args)
        {
            ITheme darkTheme = new DarkTheme();
            ITheme whiteTheme= new WhiteTheme();

            IWebPage carreerPage = new WebPage(darkTheme);
            IWebPage aboutUsPage = new WebPage(whiteTheme);

            carreerPage.GetContent();
            aboutUsPage.GetContent();

            carreerPage.ChangeThemeColor(whiteTheme);
            carreerPage.GetContent();
        }
    }
}
