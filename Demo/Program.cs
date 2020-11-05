using LinqDemo;
using System;
using System.Collections.Generic;
using System.Data;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review using Linq\n\n");
            List<ProductReview> list = new List<ProductReview>();
            list.Add(new ProductReview() { UserID = 1, ProductID = 101, Rating = 5, Review = "Best", isLike = true });
            list.Add(new ProductReview() { UserID = 7, ProductID = 107, Rating = 4.5, Review = "Best", isLike = true });
            list.Add(new ProductReview() { UserID = 2, ProductID = 102, Rating = 4, Review = "Good", isLike = true });
            list.Add(new ProductReview() { UserID = 3, ProductID = 103, Rating = 3, Review = "Average", isLike = true });
            list.Add(new ProductReview() { UserID = 4, ProductID = 104, Rating = 2, Review = "Bad", isLike = false });
            list.Add(new ProductReview() { UserID = 5, ProductID = 105, Rating = 1, Review = "Worst", isLike = false });
            list.Add(new ProductReview() { UserID = 6, ProductID = 106, Rating = 0, Review = "Worst", isLike = false });

            Console.WriteLine("userId" + " ProcuctId" + " Rating" + " Review"+"\t\tIsLiked");
            foreach(var item in list)
            {
                Console.WriteLine(item.UserID +"\t"+ item.ProductID+"\t "+item.Rating+" \t"+item.Review+"\t\t"+item.isLike);
            }

        }
    }
}
