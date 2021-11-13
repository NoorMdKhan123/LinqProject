using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqProject
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);


             

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:" + list.UserID +
                    " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Reveiew + " " +
                    "People liked:-" + list.isLike);
            }
        }
    }
}
