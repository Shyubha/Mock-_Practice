using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product(1,"Amul Lassi",80));
            list.Add(new Product(2, "Colgate", 70));
            list.Add(new Product(3, "Maggi", 50));
            list.Add(new Product(4, "Hair and Shoulder", 90));
            list.Add(new Product(5, "Chitale Bakarwadi", 130));


            list.Insert(0, new Product(12,"Deodrant",150));

            var x = from p in list
                    orderby p.Name descending
                    select p;
            foreach (Product p in x)
            {
                Console.WriteLine(p);
            }


            var y = from p in list
                    where p.Name.StartsWith("c")
                    orderby p.Price
                    select p;
            foreach (Product p in y)
            {
                Console.WriteLine(p);
            }

            var z = from p in list
                   where !p.Name.StartsWith("c")
                   select p;
            foreach (Product p in z)
            {
                Console.WriteLine(p);
            }






            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------");
            Console.ReadLine();
        }
    }
}
