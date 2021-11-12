using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Reveiew { get; set; }
        public bool isLike { get; set; }
    }
}
