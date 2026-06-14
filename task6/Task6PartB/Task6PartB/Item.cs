using System;
using System.Collections.Generic;
using System.Text;

namespace Task6PartB
{
    public class Item
 
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Description { get; set; }
            public Item()
            {
                Code = 0;
                Name = "";
                Price = 0;
                Description = "";
            }
            public Item(int code, string name, int price, string description)
            {
                this.Code = code;
                this.Name = name;
                this.Price = price;
                this.Description = description;
            }

        }
    }

