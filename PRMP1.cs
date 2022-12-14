using System;
using System.Collections.Generic;

namespace PRMP1
{
    public class Product
    {
        public int productid { get; set; }
        public int userid { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool islike { get; set; }
    }
    public class PRMP1
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>();
            { 
                p.Add(new Product { productid = 1, userid = 1, rating = 4.5, review = "Very Good", islike = true });
                p.Add(new Product { productid = 2, userid = 1, rating = 5.0, review = "Excellent", islike = true });
                p.Add(new Product { productid = 3, userid = 2, rating = 2.5, review = "Average", islike = true });
                p.Add(new Product { productid = 4, userid = 3, rating = 3.1, review = "Good", islike = true });
                p.Add(new Product { productid = 5, userid = 5, rating = 4.3, review = "Very Good", islike = true });
                p.Add(new Product { productid = 6, userid = 2, rating = 3.3, review = "Good", islike = true });
                p.Add(new Product { productid = 7, userid = 4, rating = 1.4, review = "Poor", islike = true });
                p.Add(new Product { productid = 8, userid = 4, rating = 2.1, review = "Average", islike = true });
                p.Add(new Product { productid = 9, userid = 3, rating = 1.5, review = "Poor", islike = true });
                p.Add(new Product { productid = 10, userid = 5, rating = 5.0, review = "Excellent", islike = true });
            };

            foreach(var a in p)
            {
                Console.WriteLine("ProductId:"+a.productid);
                Console.WriteLine("UserId:"+a.userid);
                Console.WriteLine("Rating:"+a.rating);
                Console.WriteLine("Review:"+a.review);
                Console.WriteLine("IsLike:"+a.islike);
                Console.WriteLine("\n");
            }
        }
    }
}
