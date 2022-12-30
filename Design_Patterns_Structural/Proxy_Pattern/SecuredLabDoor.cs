using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class SecuredLabDoor : IDoor
    {
        private readonly IDoor mDoor;

        public SecuredLabDoor(IDoor door)
        {
            mDoor = door ?? throw new ArgumentNullException(nameof(door), "door can not be null");
        }
        //public void Open()
        //{
        //    Console.WriteLine("Opening lab door");
        //}

        public void Open(string password)
        {
            if (Authenticate(password))
            {
                mDoor.Open();
            }
            else
            {
                Console.WriteLine("Big no! It ain't possible.");
            }
        }

        private bool Authenticate(string password)
        {
            return password == "$ecr@t";
        }

        public void Close()
        {
            mDoor.Close();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
