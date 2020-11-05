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
        /// UC1
        /// </summary>
        public void GetAllRecords(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\n\nAll records :-\n");
            Console.WriteLine("userId" + " ProcuctId" + " Rating" + " Review" + "\t\tIsLiked");
            foreach (var item in listProductReview)
            {
                Console.WriteLine(item.UserID + "\t" + item.ProductID + "\t " + item.Rating + " \t" + item.Review + "\t\t" + item.isLike);
            }
        }
        /// <summary>
        /// UC2
        /// </summary>
        /// <param name="listProductReview"></param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\n\nTop 3 reviewed products : \n");
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);


            Console.WriteLine("userId" + " ProcuctId" + " Rating" + " Review" + "\t\tIsLiked");
            foreach (var item in recordedData)
            {
                Console.WriteLine(item.UserID + "\t" + item.ProductID + "\t " + item.Rating + " \t" + item.Review + "\t\t" + item.isLike);
            }
        }

        /// <summary>
        /// UC3
        /// </summary>
        /// <param name="listProductReview"></param>
        public void UC3_GetRecords(List<ProductReview> listProductReview)
        {
            var records = from reviews in listProductReview
                          where reviews.Rating > 3 &&
                          (reviews.ProductID == 101|| reviews.ProductID==104||reviews.ProductID==109)
                          select reviews;

            Console.WriteLine("\n\nSelected Records having rating greater than 3 and having product Id either 101/104/109 are : \n");
            Console.WriteLine("userId" + " ProcuctId" + " Rating" + " Review" + "\t\tIsLiked");
            foreach (var item in records)
            {
                Console.WriteLine(item.UserID + "\t" + item.ProductID + "\t " + item.Rating + " \t" + item.Review + "\t\t" + item.isLike);

            }
        }

        /// <summary>
        /// UC4
        /// </summary>
        /// <param name="listProductReview"></param>
        public void UC4_GetCount(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\n\nCount of records : \n");

            var records = listProductReview.GroupBy(x => x.ProductID).Select(x=>new { ProductID=x.Key,Count=x.Count()});
            foreach(var record in records)
            {
                Console.WriteLine(record.ProductID + "--->" + record.Count);
            }
        }

        /// <summary>
        /// UC5
        /// </summary>
        /// <param name="listProductReview"></param>
        public void UC5_GetRecords(List<ProductReview> listProductReview)
        {
            var records = listProductReview.Select((x, y) =>(x.ProductID,x.Review));

            Console.WriteLine("\n\nProductID\tReview  \n");
            foreach (var record in records)
            {
                Console.WriteLine(record.ProductID + "\t\t" + record.Review);
            }
        }

        /// <summary>
        /// UC5
        /// </summary>
        /// <param name="listProductReview"></param>
        public void UC6_GetRecords(List<ProductReview> listProductReview)
        {
            var records = listProductReview.Select((x, y) => (x.ProductID, x.Review)).Skip(5);

            Console.WriteLine("\n\nProductID\tReview  \n");
            foreach (var record in records)
            {
                Console.WriteLine(record.ProductID + "\t\t" + record.Review);
            }
        }
    }
}