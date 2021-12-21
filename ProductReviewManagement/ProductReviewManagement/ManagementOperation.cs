using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    class ManagementOperation
    {
        public static void Display(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine("Productid:" + product.productId + "UserId:" + product.userId + "Rating:" + product.rating
                    + "Review" + product.review + "isLike" + product.isLike);
            }
        }
        public static void SelectTopRatingsRecords(List<ProductReview> list)
        {
            var records = (from product in list orderby product.rating descending select product).Take(3);
            foreach (ProductReview product in records)
            {
                Console.WriteLine("ProductId : " + product.productId + " UserId : " + product.userId + " Rating : " + product.rating + " Review : " + product.review + " IsLike : " + product.isLike);
            }
        }
        public static void SelectRecordsBasedOnProductId(List<ProductReview> list)
        {
            var records = (list.Where(r => r.rating > 3 && (r.productId == 1 || r.productId == 4 || r.productId == 9))).ToList();
            foreach (ProductReview product in records)
            {
                Console.WriteLine("ProductId : " + product.productId + " UserId : " + product.userId + " Rating : " + product.rating + " Review : " + product.review + " IsLike : " + product.isLike);
            }
        }
    }
}
