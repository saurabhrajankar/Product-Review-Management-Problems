using System;
using System.Collections.Generic;
using System.Linq;

namespace PRMP4
{
    public class Product
    {
        public int productid { get; set; }
        public int userid { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool islike { get; set; }
    }
    public class PRMP4
    {
        public void CountOfReview(List<Product> product)
        {
            var result=product.GroupBy(x=>x.productid).Select(x=>new {productid=x.Key,count=x.Count()});
            foreach (var a in result)
            {
                Console.WriteLine("ProductId:" + a.productid);
                Console.WriteLine("Count Is:"+a.count);
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            {
                product.Add(new Product { productid = 1, userid = 1, rating = 4.5, review = "Very Good", islike = true });
                product.Add(new Product { productid = 2, userid = 1, rating = 5.0, review = "Excellent", islike = true });
                product.Add(new Product { productid = 3, userid = 2, rating = 2.5, review = "Average", islike = true });
                product.Add(new Product { productid = 4, userid = 3, rating = 3.1, review = "Good", islike = true });
                product.Add(new Product { productid = 5, userid = 5, rating = 4.3, review = "Very Good", islike = true });
                product.Add(new Product { productid = 6, userid = 2, rating = 3.3, review = "Good", islike = true });
                product.Add(new Product { productid = 7, userid = 4, rating = 1.4, review = "Poor", islike = true });
                product.Add(new Product { productid = 8, userid = 4, rating = 2.1, review = "Average", islike = true });
                product.Add(new Product { productid = 9, userid = 3, rating = 1.5, review = "Poor", islike = true });
                product.Add(new Product { productid = 10, userid = 5, rating = 5.0, review = "Excellent", islike = true });
            };
            PRMP4 obj=new PRMP4();
            obj.CountOfReview(product);
        }
    }
}
