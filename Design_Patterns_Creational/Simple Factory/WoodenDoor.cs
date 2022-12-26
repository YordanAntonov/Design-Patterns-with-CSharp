using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    //2) We implement the IDoor interface, to an type of Door!
    public class WoodenDoor : IDoor
    {
        public WoodenDoor(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        private int Height { get; set; }
        private int Width { get; set; }

        public int GetHeight() => this.Height;


        public int GetWidth() => this.Width;

    }
}
