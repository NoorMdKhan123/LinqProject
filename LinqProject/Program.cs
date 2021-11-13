using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId = 1, UserID=1, Rating = 5, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 2, UserID=1, Rating = 5, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 3, UserID=3, Rating = 4, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 4, UserID=1, Rating = 5, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 5, UserID=4, Rating = 3, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 6, UserID=1, Rating = 4, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 7, UserID=4, Rating = 4, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 8, UserID=1, Rating = 3, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 9, UserID=7, Rating = 4, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 10, UserID=1, Rating = 3, Reveiew ="Good",
                isLike = true },
                new ProductReview(){ProductId = 11, UserID=7, Rating = 2, Reveiew ="Good",
                isLike = true },
                 new ProductReview(){ProductId = 12, UserID=5, Rating = 4, Reveiew ="Good",
                isLike = true },
                  new ProductReview(){ProductId = 13, UserID=3, Rating = 3, Reveiew ="Good",
                isLike = true },
                   new ProductReview(){ProductId = 14, UserID=7, Rating = 5, Reveiew ="Good",
                isLike = true },
                    new ProductReview(){ProductId = 15, UserID=2, Rating = 4, Reveiew ="Good",
                isLike = true },
                     new ProductReview(){ProductId = 16, UserID=7, Rating = 3, Reveiew ="Good",
                isLike = true },

                      new ProductReview(){ProductId = 17, UserID=4, Rating = 5, Reveiew ="Good",
                isLike = true },
                       new ProductReview(){ProductId = 18, UserID=2, Rating = 4, Reveiew ="Good",
                isLike = true },
                        new ProductReview(){ProductId = 19, UserID=1, Rating = 4, Reveiew ="Good",
                isLike = true },
                         new ProductReview(){ProductId = 20, UserID=2, Rating = 3, Reveiew ="Good",
                isLike = true },
                          new ProductReview(){ProductId = 21, UserID=4, Rating = 5, Reveiew ="Good",
                isLike = true },
                           new ProductReview(){ProductId = 22, UserID=3, Rating = 5, Reveiew ="Good",
                isLike = true },
                            new ProductReview(){ProductId = 23, UserID=3, Rating = 4, Reveiew ="Good",
                isLike = true },
                             new ProductReview(){ProductId = 24, UserID=4, Rating = 3, Reveiew ="Good",
                isLike = true },
                              new ProductReview(){ProductId = 25, UserID=4, Rating = 5, Reveiew ="Good",
                isLike = true },



            };
            //foreach(var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:" + list.UserID +
            //        " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Reveiew + " "+
            //        "People liked:-" + list.isLike);
            //}
            Management management = new Management();
            management.TopRecords(productReviewList);
        }
    }
}
