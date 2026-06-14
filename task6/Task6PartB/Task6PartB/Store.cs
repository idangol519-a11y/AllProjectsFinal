using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Task6PartB
{
    public class Store
    {
        DBConnection db;

        public Store()
        {
            db = new DBConnection();
        }

        public DataTable ItemsTable()
        {
            return db.ItemsTable();
        }

        public DataTable FilterByAbovePrice(int price)
        {
            return db.FilterByAbovePrice(price);
        }

        public DataTable InsertItem(Item item)
        {
            return db.InsertItem(item);
        }

        public DataTable DeleteItem(int code)
        {
            return db.DeleteItem(code);
        }

        public void UpdateDB(DataTable dt)
        {
            db.UpdateDB(dt);
        }
    }
}
