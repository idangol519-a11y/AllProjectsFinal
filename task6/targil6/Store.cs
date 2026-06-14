using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil6
{
     class Store
    {
        public Item[] items;
        public int count=0;
        public DBConnection db;
        public Store(Item[] items, int count, DBConnection db)
        {
            this.items = items;
            this.count = count;
            this.db = db;
        }

    }
}
