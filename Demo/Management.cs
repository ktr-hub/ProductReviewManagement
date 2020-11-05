using Demo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        /// <summary>
        /// UC2
        /// </summary>
        /// <param name="list"></param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\n\n Top 3 reviewed products : ");
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var item in recordedData)
            {
                Console.WriteLine(item.UserID + "\t" + item.ProductID + "\t " + item.Rating + " \t" + item.Review + "\t\t" + item.isLike);
            }
        }
    }
}
