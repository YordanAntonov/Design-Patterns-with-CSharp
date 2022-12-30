using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    class TeaShop
    {
        private Dictionary<int, KarakTea> mOrders = new Dictionary<int, KarakTea>();
        private readonly TeaMaker mTeaMaker;

        public TeaShop(TeaMaker teaMaker)
        {
            this.mTeaMaker = teaMaker ?? throw new ArgumentNullException("teaMaker", "teaMaker cannot be null");
        }

        public void TakeOrder(string teaType, int table)
        {
            mOrders[table] = mTeaMaker.Make(teaType);
        }

        public void Serve()
        {
            foreach (var table in mOrders.Keys)
            {
                Console.WriteLine($"Serving Tea to table # {table}");
            }
        }
    }
}
