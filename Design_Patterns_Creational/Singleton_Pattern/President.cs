using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public class President
    {
        static President instance;
        private President() 
        {

        }

        public static President GetInstance()
        {
            if (instance == null)
            {
                instance = new President();
            }

            return instance;
        }

    }
}
