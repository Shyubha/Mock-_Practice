using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock2
{
    internal class Product
    {
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Price
        {
            get { return Price; }
            set { Price = value; }
        }
        int id;
        string name;
        int price;

        public Product()
        {

        }
        public Product(int id , string name,int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;

        }
        public override string ToString()
        {
            return id + " " + name + " " + price;
        }

    }
}
