using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil6
{
    class Item
    {
        public int id;
        public string name;
        public int price;
        public string description;
        public Item(int id, string name, int price, string description)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
        }
    }
}
